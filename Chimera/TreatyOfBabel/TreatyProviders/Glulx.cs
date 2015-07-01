using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace TreatyOfBabel.TreatyProviders
{
  [Export(typeof (ITreatyProvider))]
  internal class Glulx : ITreatyProvider
  {
    private const string SIGNATURE = "Glul";
    public string FormatName => "glulx";
    public string HomePage => "http://eblong.com/zarf/glulx";
    public string[] FileExtensions => new[] {".ulx"};
    public uint Popularity => 950;

    public bool ClaimStoryFile(IStoryFile storyFile)
    {
      if (storyFile.Extent > 256)
      {
        var sig = Encoding.ASCII.GetBytes(SIGNATURE);
        var magic = storyFile.ReadBytes(0, (uint) sig.Length);

        return sig.SequenceEqual(magic);
      }

      return false;
    }

    public IStoryFileHandler GetStoryFileHandler(IStoryFile storyFile)
    {
      return new glulxHandler(this, storyFile);
    }

    private class glulxHandler : TreatyStoryFileHandlerBase
    {
      public glulxHandler(ITreatyProvider provider, IStoryFile storyFile)
        : base(provider, storyFile)
      {
      }

      public override string GetStoryFileExtension()
      {
        return ".ulx";
      }

      public override string GetStoryFileIfid()
      {
        return null;
      }
    }
  }
}