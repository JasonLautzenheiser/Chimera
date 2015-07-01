using System.ComponentModel.Composition;
using System.IO;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace TreatyOfBabel.TreatyProviders
{
  [Export(typeof (ITreatyProvider))]
  ////[ExportMetadata("TreatyOfBabelPopularity", 2000)]
  internal class Blorb : ITreatyProvider
  {
    public string FormatName => "blorb";
    public string HomePage => "http://eblong.com/zarf/blorb";
    public string[] FileExtensions => new[] {".blorb", ".blb", ".zblorb", ".zlb", ".gblorb", ".glb"};
    public uint Popularity => 2000;

    public bool ClaimStoryFile(IStoryFile storyFile)
    {
      uint indexTemp;
      if (storyFile.Extent < 16 ||
          !storyFile.TryIndexOf("FORM", 0, 4, out indexTemp) ||
          !storyFile.TryIndexOf("IFRS", 8, 8 + 4, out indexTemp))
      {
        return false;
      }

      return true;
    }

    public IStoryFileHandler GetStoryFileHandler(IStoryFile storyFile)
    {
      return new blorbHandler(this, storyFile);
    }

    private class blorbHandler : TreatyStoryFileHandlerBase
    {
      private BlorbReader reader;

      public blorbHandler(ITreatyProvider provider, IStoryFile storyFile)
        : base(provider, storyFile)
      {
        reader = new BlorbReader(storyFile.Stream, false);
      }

      protected override void Dispose(bool disposing)
      {
        if (disposing)
        {
          if (reader != null)
          {
            reader.Dispose();
            reader = null;
          }
        }

        base.Dispose(disposing);
      }

      public override string GetStoryFileExtension()
      {
        //BabelTools.BlorbReader reader = new BlorbReader(storyFile.Stream, false);
        var ver = StoryFile.ReadByte(0);
        return $".z{ver:d}";
      }

      public override string GetStoryFileIfid()
      {
        var metadata = reader.GetMetadata();

        XNamespace ns = "http://babel.ifarchive.org/protocol/iFiction/";

        var lameReader = metadata.CreateReader();
        if (lameReader.NameTable != null)
        {
          var xmlns = new XmlNamespaceManager(lameReader.NameTable);
          xmlns.AddNamespace("i", ns.NamespaceName);

          var ifid = metadata.XPathSelectElement("/i:ifindex/i:story/i:identification/i:ifid", xmlns);

          return ifid?.Value;
        }

        return null;
      }

      public override Stream GetStoryFileMetadata()
      {
        return reader.GetMetadataStream();
      }

      public override Stream GetStoryFileCover()
      {
        return reader.GetCoverImageStream();
      }
    }
  }
}