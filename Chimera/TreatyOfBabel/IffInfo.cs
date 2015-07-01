using System.Diagnostics;

namespace TreatyOfBabel
{
  [DebuggerDisplay("{TypeId} @{Offset}, {Length}")]
  public class IffInfo
  {
    public IffInfo(uint offset, string typeId, uint length)
    {
      Offset = offset;
      TypeId = typeId;
      Length = length;
    }

    public uint Offset { get; }
    public string TypeId { get; } // add sub-type, for FORM?
    public uint Length { get; }

    public uint ContentOffset => Offset + 4 + 4;
  }
}