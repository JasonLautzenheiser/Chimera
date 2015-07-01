using System;
using System.IO;

namespace TreatyOfBabel
{
  public interface IStoryFile : IDisposable
  {
    uint Extent { get; }
    Stream Stream { get; }
    byte ReadByte(uint position);
    byte[] ReadBytes(uint position, uint length);
    bool TryIndexOf(string sequence, out uint index);
    bool TryIndexOf(string sequence, uint start, out uint index);
    bool TryIndexOf(string sequence, uint start, uint end, out uint index);
    bool TryIndexOf(byte[] sequence, out uint index);
    bool TryIndexOf(byte[] sequence, uint start, out uint index);
    bool TryIndexOf(byte[] sequence, uint start, uint end, out uint index);
  }
}