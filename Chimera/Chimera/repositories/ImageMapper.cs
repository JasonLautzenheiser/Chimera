using System;
using System.CodeDom;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using Chimera.Extensions;
using NPoco;

namespace Chimera.repositories
{
  public class ImageMapper : DefaultMapper
  {
    public override Func<object, object> GetFromDbConverter(MemberInfo destMemberInfo, Type sourceType)
    {
      Debug.WriteLine(destMemberInfo.Name);
      if (destMemberInfo.Name == "FullImage" || destMemberInfo.Name == "ThumbImage")
      {
        return x => ((byte[])x).ToImage();
      }
      return base.GetFromDbConverter(destMemberInfo, sourceType);
    }

    public override Func<object, object> GetToDbConverter(Type destType, MemberInfo sourceMemberInfo)
    {
      if (sourceMemberInfo.Name == "FullImage" || sourceMemberInfo.Name == "ThumbImage")
      {
        return x => ((Image) x).ToBytes();
      }
      return base.GetToDbConverter(destType, sourceMemberInfo);
    }
  }
}