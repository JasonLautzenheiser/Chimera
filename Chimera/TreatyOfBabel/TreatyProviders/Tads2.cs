using System.ComponentModel.Composition;
using System.Linq;
using System.Text;

namespace TreatyOfBabel.TreatyProviders
{
  [Export(typeof (ITreatyProvider))]
  internal class Tads2 : ITreatyProvider
  {
    private const string SIGNATURE = "TADS2 bin\x0A\x0D\x1A";

    public string FormatName => "tads2";
    public string HomePage => "http://www.tads.org";
    public string[] FileExtensions => new[] {".gam"};
    public uint Popularity => 900;

    public bool ClaimStoryFile(IStoryFile storyFile)
    {
      var sig = Encoding.ASCII.GetBytes(SIGNATURE);
      var magic = storyFile.ReadBytes(0, (uint) sig.Length);

      return sig.SequenceEqual(magic);
    }

    public IStoryFileHandler GetStoryFileHandler(IStoryFile storyFile)
    {
      return new tads2Handler(this, storyFile);
    }

    private class tads2Handler : TreatyStoryFileHandlerBase
    {
      public tads2Handler(ITreatyProvider provider, IStoryFile storyFile)
        : base(provider, storyFile)
      {
      }

      public override string GetStoryFileExtension()
      {
        return ".gam";
      }

      public override string GetStoryFileIfid()
      {
        return null;
      }
    }
  }
}