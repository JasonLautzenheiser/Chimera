using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace TreatyOfBabel.TreatyProviders
{
  [Export(typeof (ITreatyProvider))]
  internal class Tads3 : ITreatyProvider
  {
    private const string SIGNATURE = "T3-image\x0D\x0A\x1A";

    public string FormatName => "tads3";
    public string HomePage => "http://www.tads.org";
    public string[] FileExtensions => new[] {".t3"};
    public uint Popularity => 900;

    public bool ClaimStoryFile(IStoryFile storyFile)
    {
      var sig = Encoding.ASCII.GetBytes(SIGNATURE);
      var magic = storyFile.ReadBytes(0, (uint) sig.Length);

      return sig.SequenceEqual(magic);
    }

    public IStoryFileHandler GetStoryFileHandler(IStoryFile storyFile)
    {
      return new tads3Handler(this, storyFile);
    }

    private class tads3Handler : TreatyStoryFileHandlerBase
    {
      public tads3Handler(ITreatyProvider provider, IStoryFile storyFile)
        : base(provider, storyFile)
      {
      }

      public override string GetStoryFileExtension()
      {
        return ".t3";
      }

      public override string GetStoryFileIfid()
      {
        return null;
      }
    }
  }
}