using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using NPoco;
using TreatyOfBabel;

namespace Chimera.domain
{
  [TableName("games")]
  [PrimaryKey("rowid")]
  public class GameModel
  {
    private readonly FileInfo file;
    private Image fullImage;
    private Image thumbImage;

    public GameModel()
    {
    }

    public GameModel(string filename, string rootPath)
    {
      file = new FileInfo(filename);

      Title = Path.GetFileNameWithoutExtension(file.Name); // "An Interactive Fiction"?
      Author = "Anonymous";
      FullPath = filename;
      RelativePath = filename.Substring(rootPath.Length + 1);

      extractMetadata();
    }

    public int Rowid { get; set; }
    public string FullPath { get; set; }
    public string RelativePath { get; private set; }
    //// Game metadata fields

    // identification
    public string Ifid { get; private set; }
    public string Format { get; private set; }
    public string Bafn { get; private set; }
    // bibliographic
    public string Title { get; private set; }
    public string Author { get; private set; }
    public string Language { get; private set; }
    public string Headline { get; private set; }
    public string FirstPublished { get; private set; }
    public string Genre { get; private set; }
    [Ignore]
    public string Group { get; private set; }
    public string Description { get; private set; }
    public string Series { get; private set; }
    public string SeriesNumber { get; private set; }
    public string Forgiveness { get; private set; }
    //// resources/auxiliary not used...

    //contact
    public string Url { get; private set; }
    public string AuthorEmail { get; private set; }
    // cover image
    [Ignore]
    public MemoryStream CoverImageStream { get; private set; }

    public Image FullImage
    {
      get
      {
        if (fullImage == null && CoverImageStream != null)
        {
          fullImage = ImageFromStream(CoverImageStream, 300, 300);
        }

        return fullImage;
      }
      set { fullImage = value; }
    }

    [Column("thumbnail")]
    public Image ThumbImage
    {
      get
      {
        if (thumbImage == null && CoverImageStream != null)
        {
          thumbImage = ImageFromStream(CoverImageStream, 100, 100);
        }

        return thumbImage;
      }
      set { thumbImage = value; }
    }

    private void extractMetadata()
    {
      var whitespace = new Regex(@"[ \t\n\v\r]+", RegexOptions.Compiled | RegexOptions.Multiline);

      // Should use treaty API here...
      var helper = new TreatyHelper();
      IStoryFileHandler handler;
      if (helper.TryGetHandler(FullPath, out handler))
      {
        //this.Genre = string.Format("(Unknown {0})", handler.Provider.FormatName);
        Genre = "Unknown Genre";

        using (var metadataStream = handler.GetStoryFileMetadata())
        {
          if (metadataStream != null)
          {
            var metadata = XDocument.Load(metadataStream);
            XNamespace ns = "http://babel.ifarchive.org/protocol/iFiction/";

            var lameReader = metadata.CreateReader();
            var xmlns = new XmlNamespaceManager(lameReader.NameTable);
            xmlns.AddNamespace("i", ns.NamespaceName);

            var ident = metadata.XPathSelectElement("/i:ifindex/i:story/i:identification", xmlns);
            var biblio = metadata.XPathSelectElement("/i:ifindex/i:story/i:bibliographic", xmlns);
            var contact = metadata.XPathSelectElement("/i:ifindex/i:story/i:contacts", xmlns);

            if (ident != null)
            {
              Ifid = valueOrDefault(ident, "i:ifid", xmlns, Ifid);
              Format = valueOrDefault(ident, "i:format", xmlns, Format);
              Bafn = valueOrDefault(ident, "i:bafn", xmlns, Bafn);
            }

            if (biblio != null)
            {
              Title = valueOrDefault(biblio, "i:title", xmlns, Title);
              Author = valueOrDefault(biblio, "i:author", xmlns, Author);
              Language = valueOrDefault(biblio, "i:language", xmlns, Language);
              Headline = valueOrDefault(biblio, "i:headline", xmlns, Headline);
              FirstPublished = valueOrDefault(biblio, "i:firstpublished", xmlns, FirstPublished);
              Genre = valueOrDefault(biblio, "i:genre", xmlns, Genre);
              Group = valueOrDefault(biblio, "i:group", xmlns, Group);
              Description = valueOrDefault(biblio, "i:description", xmlns, Description);
              Series = valueOrDefault(biblio, "i:series", xmlns, Series);
              SeriesNumber = valueOrDefault(biblio, "i:seriesnumber", xmlns, SeriesNumber);
              Forgiveness = valueOrDefault(biblio, "i:foregiveness", xmlns, Forgiveness);

              if (!string.IsNullOrEmpty(Description))
              {
                // only <br/> is supported... all other whitespace should
                // get normalized to single spaces...
                Description = whitespace.Replace(Description, " ").Trim();
                Description = Description.Replace("<br/>", "\n");
              }
            }

            if (contact != null)
            {
              Url = valueOrDefault(contact, "i:url", xmlns, Url);
              AuthorEmail = valueOrDefault(contact, "i:authoremail", xmlns, AuthorEmail);
            }
          }
        }

        using (var stream = handler.GetStoryFileCover())
        {
          if (stream != null)
          {
            // If the source stream supports seeking, we can get
            // the length, purely to avoid over-allocating memory.
            CoverImageStream = stream.CanSeek ? new MemoryStream((int) stream.Length) : new MemoryStream();
            stream.CopyTo(CoverImageStream);
            CoverImageStream.Position = 0;
          }
        }

        if (string.IsNullOrEmpty(Ifid))
        {
          ////System.Threading.ThreadPool.QueueUserWorkItem(state =>
          ////    {
          ////        var ifid = handler.GetStoryFileIfid();
          ////        if (string.IsNullOrEmpty(this.Ifid))
          ////        {
          ////            this.Ifid = ifid;
          ////        }
          ////    });
          //System.Threading.Tasks.Task.Factory.StartNew(() =>
          //    {
          //        var ifid = handler.GetStoryFileIfid();
          //        if (string.IsNullOrEmpty(this.Ifid))
          //        {
          //            this.Ifid = ifid;
          //        }
          //    });
          ////this.Ifid = handler.GetStoryFileIfid();
        }
      }
    }

    private Image ImageFromStream(MemoryStream stream, int width, int height)
    {
      if (stream == null) return null;

      var bmp = new Bitmap(stream);
      return new Bitmap(bmp, new Size(width, height));
    }

    private static string valueOrDefault(XNode node, string xpath, XmlNamespaceManager xmlns, string defaultValue)
    {
      var el = node.XPathSelectElement(xpath, xmlns);
      return !string.IsNullOrWhiteSpace(el?.Value) ? el.Value : defaultValue;
    }

    public void Play()
    {
      Process.Start(FullPath);
    }
  }
}