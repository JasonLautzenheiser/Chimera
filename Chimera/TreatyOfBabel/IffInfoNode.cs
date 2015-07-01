using System.Diagnostics;

namespace TreatyOfBabel
{
  [DebuggerDisplay("{TypeId} @{Offset}, {Length}")]
  public class IffInfoNode : IffInfo
  {
    public IffInfoNode(IffInfoNode parent, IffInfo info)
      : this(parent, info.Offset, info.TypeId, info.Length)
    {
    }

    public IffInfoNode(IffInfoNode parent, uint offset, string typeId, uint length)
      : base(offset, typeId, length)
    {
      Parent = parent;
    }

    public IffInfoNode Parent { get; private set; }
  }
}