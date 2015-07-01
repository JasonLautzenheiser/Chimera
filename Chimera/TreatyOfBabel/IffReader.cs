using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace TreatyOfBabel
{
  public sealed class IffReader : IDisposable
  {
    private readonly bool disposeReader = true;
    private bool disposed;
    private BinaryReader reader;

    public IffReader(string file)
    {
      reader = new BinaryReader(File.OpenRead(file));
    }

    public IffReader(BinaryReader reader, bool disposeReader = true)
    {
      this.reader = reader;
      this.disposeReader = disposeReader;
    }

    public void Dispose()
    {
      if (!disposed)
      {
        if (reader != null)
        {
          if (disposeReader)
          {
            reader.Dispose();
          }

          reader = null;
        }

        disposed = true;
        GC.SuppressFinalize(this);
      }
    }

//    // Build a (nested?) tree of chunks...
//    private void ReadIff()
//    {
//    }

    // Get chunks from the current offset, or offset passed in?
    public IEnumerable<IffInfo> GetChunks(uint offset)
    {
      var currentOffset = offset;
      var typeId = "XXXX";

      while (!string.IsNullOrEmpty(typeId))
      {
        // IFF chunks *must* start on even byte boundaries...
        // Is this always true, or just for FORM?
        if ((currentOffset & 0x1) == 1)
        {
          ++currentOffset;
        }

        reader.BaseStream.Position = currentOffset;
        typeId = ReadTypeId();

        if (!string.IsNullOrEmpty(typeId))
        {
          var length = ReadUint();
          yield return new IffInfo(currentOffset, typeId, length);
          currentOffset += 4 + 4 + length;
        }
      }
    }

    public string ReadTypeId(uint offset)
    {
      reader.BaseStream.Position = offset;
      return ReadTypeId();
    }

    public string ReadTypeId()
    {
      var chars = reader.ReadChars(4);

      if (chars.Length == 0)
      {
        return null;
      }

      Debug.Assert(chars.Length == 4);
      return new string(chars);
    }

    public uint ReadUint(uint offset)
    {
      reader.BaseStream.Position = offset;
      return ReadUint();
    }

    public uint ReadUint()
    {
      return reader.ReadBigEndianUint32();
    }

    public byte[] ReadBytes(uint offset, uint length)
    {
      reader.BaseStream.Position = offset;
      return ReadBytes(length);
    }

    public byte[] ReadBytes(uint length)
    {
      return reader.ReadBytes((int) length);
    }
  }
}