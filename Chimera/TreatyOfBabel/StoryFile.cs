using System;
using System.IO;
using System.Linq;
using System.Text;

namespace TreatyOfBabel
{
  internal sealed class StoryFile : IStoryFile
  {
    private const int INITIAL_BUFFER_SIZE = 128;
    private bool disposed;
    private string filename;
    private byte[] initialBuffer;

    public StoryFile(string filename)
    {
      this.filename = filename;
      var info = new FileInfo(filename);

      var extent = (uint) info.Length;
      var stream = File.Open(filename, FileMode.Open, FileAccess.Read, FileShare.Read);

      init(stream, extent);
    }

    public StoryFile(Stream stream)
    {
      init(stream, (uint) stream.Length);
    }

    public StoryFile(Stream stream, uint extent)
    {
      init(stream, extent);
    }

    public Stream Stream { get; private set; }
    public uint Extent { get; private set; }

    public byte ReadByte(uint position)
    {
      if (position < initialBuffer.Length)
      {
        return initialBuffer[position];
      }

      Stream.Position = position;
      return (byte) Stream.ReadByte();
    }

    public byte[] ReadBytes(uint position, uint length)
    {
      var buffer = new byte[length];

      if (position + length < initialBuffer.Length)
      {
        Array.Copy(initialBuffer, position, buffer, 0, length);
      }
      else
      {
        Stream.Position = position;
        Stream.Read(buffer, 0, (int) length);
      }

      return buffer;
    }

    public bool TryIndexOf(string sequence, out uint index)
    {
      return TryIndexOf(sequence, 0, out index);
    }

    public bool TryIndexOf(string sequence, uint start, out uint index)
    {
      return TryIndexOf(sequence, start, Extent, out index);
    }

    public bool TryIndexOf(string sequence, uint start, uint end, out uint index)
    {
      var sequenceBytes = Encoding.ASCII.GetBytes(sequence);
      return TryIndexOf(sequenceBytes, start, end, out index);
    }

    public bool TryIndexOf(byte[] sequence, out uint index)
    {
      return TryIndexOf(sequence, 0, out index);
    }

    public bool TryIndexOf(byte[] sequence, uint start, out uint index)
    {
      return TryIndexOf(sequence, start, Extent, out index);
    }

    public bool TryIndexOf(byte[] sequence, uint start, uint end, out uint index)
    {
      var testEnd = end - sequence.Length;

      index = uint.MaxValue;

      for (var pos = start; pos <= testEnd; ++pos)
      {
        // This is a naive search, not a fast one (see Knuth!)
        var b = ReadByte(pos);

        if (b == sequence[0])
        {
          // Special-case short matches!
          if (sequence.Length == 1)
          {
            index = pos;
            return true;
          }

          var test = ReadBytes(pos, (uint) sequence.Length);
          if (sequence.SequenceEqual(test))
          {
            index = pos;
            return true;
          }
        }
      }


      return false;
    }

    public void Dispose()
    {
      if (!disposed)
      {
        disposed = true;

        if (Stream != null)
        {
          Stream.Dispose();
          Stream = null;
        }

        GC.SuppressFinalize(this);
      }
    }

    private void init(Stream stream, uint extent)
    {
      Stream = stream;
      Extent = extent;

      // Cache the first 'InitialBufferSize' bytes for
      // quick access...
      initialBuffer = new byte[Math.Min(INITIAL_BUFFER_SIZE, extent)];

      var read = Stream.Read(initialBuffer, 0, initialBuffer.Length);
    }
  }
}