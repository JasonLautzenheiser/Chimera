using System.IO;
using System.Text.RegularExpressions;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;
using TreatyOfBabel;

namespace Chimera
{
    public class GameModel
    {
      private FileInfo file;

      public GameModel(string filename, string rootPath)
      {
        this.file = new FileInfo(filename);

        this.Title = Path.GetFileNameWithoutExtension(this.file.Name);  // "An Interactive Fiction"?
        this.Author = "Anonymous";
        this.FullPath = filename;
        this.RelativePath = filename.Substring(rootPath.Length + 1);

        this.ExtractMetadata();
      }

      public string FullPath { get; private set; }
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
      public MemoryStream CoverImageStream { get; private set; }

      private void ExtractMetadata()
      {
        var whitespace = new Regex(@"[ \t\n\v\r]+", RegexOptions.Compiled | RegexOptions.Multiline);

        // Should use treaty API here...
        var helper = new TreatyHelper();
        IStoryFileHandler handler;
        if (helper.TryGetHandler(this.FullPath, out handler))
        {
          //this.Genre = string.Format("(Unknown {0})", handler.Provider.FormatName);
          this.Genre = "Unknown Genre";

          using (var metadataStream = handler.GetStoryFileMetadata())
          {

            if (metadataStream != null)
            {
              XDocument metadata = XDocument.Load(metadataStream);
              XNamespace ns = "http://babel.ifarchive.org/protocol/iFiction/";

              var lameReader = metadata.CreateReader();
              XmlNamespaceManager xmlns = new XmlNamespaceManager(lameReader.NameTable);
              xmlns.AddNamespace("i", ns.NamespaceName);

              var ident = metadata.XPathSelectElement("/i:ifindex/i:story/i:identification", xmlns);
              var biblio = metadata.XPathSelectElement("/i:ifindex/i:story/i:bibliographic", xmlns);
              var contact = metadata.XPathSelectElement("/i:ifindex/i:story/i:contacts", xmlns);

              if (ident != null)
              {
                this.Ifid = this.ValueOrDefault(ident, "i:ifid", xmlns, this.Ifid);
                this.Format = this.ValueOrDefault(ident, "i:format", xmlns, this.Format);
                this.Bafn = this.ValueOrDefault(ident, "i:bafn", xmlns, this.Bafn);
              }

              if (biblio != null)
              {
                this.Title = this.ValueOrDefault(biblio, "i:title", xmlns, this.Title);
                this.Author = this.ValueOrDefault(biblio, "i:author", xmlns, this.Author);
                this.Language = this.ValueOrDefault(biblio, "i:language", xmlns, this.Language);
                this.Headline = this.ValueOrDefault(biblio, "i:headline", xmlns, this.Headline);
                this.FirstPublished = this.ValueOrDefault(biblio, "i:firstpublished", xmlns, this.FirstPublished);
                this.Genre = this.ValueOrDefault(biblio, "i:genre", xmlns, this.Genre);
                this.Group = this.ValueOrDefault(biblio, "i:group", xmlns, this.Group);
                this.Description = this.ValueOrDefault(biblio, "i:description", xmlns, this.Description);
                this.Series = this.ValueOrDefault(biblio, "i:series", xmlns, this.Series);
                this.SeriesNumber = this.ValueOrDefault(biblio, "i:seriesnumber", xmlns, this.SeriesNumber);
                this.Forgiveness = this.ValueOrDefault(biblio, "i:foregiveness", xmlns, this.Forgiveness);

                if (!string.IsNullOrEmpty(this.Description))
                {
                  // only <br/> is supported... all other whitespace should
                  // get normalized to single spaces...
                  this.Description = whitespace.Replace(this.Description, " ").Trim();
                  this.Description = this.Description.Replace("<br/>", "\n");
                }
              }

              if (contact != null)
              {
                this.Url = this.ValueOrDefault(contact, "i:url", xmlns, this.Url);
                this.AuthorEmail = this.ValueOrDefault(contact, "i:authoremail", xmlns, this.AuthorEmail);
              }
            }
          }

          using (var stream = handler.GetStoryFileCover())
          {
            if (stream != null)
            {
              // If the source stream supports seeking, we can get
              // the length, purely to avoid over-allocating memory.
              this.CoverImageStream = stream.CanSeek ? new MemoryStream((int)stream.Length) : new MemoryStream();
              stream.CopyTo(this.CoverImageStream);
              this.CoverImageStream.Position = 0;
            }
          }

          if (string.IsNullOrEmpty(this.Ifid))
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

      private string ValueOrDefault(XNode node, string xpath, XmlNamespaceManager xmlns, string defaultValue)
      {
        var el = node.XPathSelectElement(xpath, xmlns);
        if (el != null && !string.IsNullOrWhiteSpace(el.Value))
        {
          return el.Value;
        }

        return defaultValue;
      }
    }
  }

