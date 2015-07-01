using System.IO;

namespace TreatyOfBabel
{
  public static class BinaryReaderExtensions
  {
    public static uint ReadBigEndianUint32(this BinaryReader reader)
    {
      var bytes = reader.ReadBytes(4);

      if (bytes == null || bytes.Length != 4)
      {
        throw new InvalidDataException("Expected to read at least 4 bytes!");
      }

      return ((uint) bytes[0] << 24) | ((uint) bytes[1] << 16) | ((uint) bytes[2] << 8) | bytes[3];
    }
  }
}