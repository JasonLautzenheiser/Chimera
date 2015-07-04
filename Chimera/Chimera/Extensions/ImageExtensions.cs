using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

namespace Chimera.Extensions
{
  public static class ImageExtensions
  {
    public static Image ToImage(this System.Byte[] array)
    {
      try
      {
        MemoryStream ms = new MemoryStream(array, 0, array.Length);
        ms.Write(array, 0, array.Length);
        Image image = new Bitmap(ms);
        return image;
      }
      catch (Exception e)
      {
        return null;
      }
    }

    public static byte[] ToBytes(this Image img)
    {
      try
      {
        using (MemoryStream ms = new MemoryStream())
        {
          img.Save(ms, ImageFormat.Jpeg);
          byte[] imageBytes = ms.ToArray();
          return imageBytes;
        }
      }
      catch (Exception e)
      {
        return new byte[0];
      }
    }
  }
}