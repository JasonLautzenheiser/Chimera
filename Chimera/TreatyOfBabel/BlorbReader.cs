using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Windows.Media.Imaging;
using System.Xml.Linq;

namespace TreatyOfBabel
{
  public sealed class BlorbReader : IDisposable
  {
    private readonly bool disposeReader = true;
    private readonly List<IffInfoNode> infoNodes = new List<IffInfoNode>();
    private uint? coverImage;
    private Dictionary<uint, uint> dataResources;
    private bool disposed;
    private Dictionary<uint, uint> execResources;
    private XDocument metadata;
    private IffInfoNode metadataInfo;
    private Dictionary<uint, uint> pictResources;
    private IffReader reader;
    // resource index data...
    private bool sawResources;
    private Dictionary<uint, uint> sndResources;

    public BlorbReader(string file)
    {
      reader = new IffReader(file);
      readBlorb();
    }

    public BlorbReader(Stream stream, bool dispose = true)
    {
      // any way to prevent dispose of stream from BinaryReader?
      var bin = new BinaryReader(stream);
      reader = new IffReader(bin, dispose);
      readBlorb();
    }

    // Get metadata
    public XDocument Metadata => GetMetadata();

    public void Dispose()
    {
      if (disposed) return;
      if (reader != null)
      {
        if (disposeReader)
        {
          reader.Dispose();
        }

        reader = null;
      }

      disposed = true;
      GC.SuppressFinalize(this);
    }

    private void readBlorb()
    {
      foreach (var node in reader.GetChunks(0).Select(chunk => new IffInfoNode(null, chunk))) {
        handleIffInfoNode(node, 0);
      }
    }

    public XDocument GetMetadata()
    {
      if (metadata != null) return metadata;
      using (var stream = GetMetadataStream())
      {
        metadata = XDocument.Load(stream);
      }

      return metadata;
    }

    public BitmapImage GetCoverImage(int? width = null, int? height = null)
    {
      var stream = GetCoverImageStream();
      if (stream == null) return null;
      var bmp = new BitmapImage();
      bmp.BeginInit();
      bmp.StreamSource = stream;

      if (width.HasValue)
        bmp.DecodePixelWidth = width.Value;

      if (height.HasValue)
        bmp.DecodePixelHeight = height.Value;

      bmp.EndInit();

      return bmp;
    }

    public Stream GetCoverImageStream()
    {
      if (!coverImage.HasValue)
        return null;

      uint coverOffset;
      if (pictResources == null || !pictResources.TryGetValue(coverImage.Value, out coverOffset))
        return null;

      var artTypeId = reader.ReadTypeId(coverOffset);
      var artLength = reader.ReadUint();

      var bytes = reader.ReadBytes(artLength);

      var stream = new MemoryStream(bytes);

      return stream;
    }

    public Stream GetMetadataStream()
    {
      if (metadataInfo == null)
        return null;

      var bytes = reader.ReadBytes(metadataInfo.Offset + 8, metadataInfo.Length);
      var stream = new MemoryStream(bytes);
      return stream;
    }

    private void handleIffInfoNode(IffInfoNode info, int depth)
    {
      infoNodes.Add(info);

      switch (info.TypeId)
      {
        case "FORM":
          var formType = reader.ReadTypeId(info.ContentOffset);
          if (depth == 0 && formType != "IFRS")
            Console.WriteLine("Unexpected FORM subtype!");

          // ignore sounds!
          if (formType != "AIFF")
          {
            foreach (var node in reader.GetChunks(info.ContentOffset + 4).Select(chunk => new IffInfoNode(info, chunk))) {
              handleIffInfoNode(node, depth + 1);
            }
          }
          break;

        case "RIdx":
          if (sawResources)
            Console.WriteLine(" - already saw resource index!  Unexpected!");
          else
          {
            Console.WriteLine();
            var count = reader.ReadUint(info.Offset + 8);
            var expectedCount = (info.Length - 4)/12;
            Debug.Assert(count == expectedCount);
            for (uint i = 0; i < expectedCount; ++i)
            {
              var indexType = reader.ReadTypeId();
              var indexId = reader.ReadUint();
              var indexOffset = reader.ReadUint();

              switch (indexType)
              {
                case "Pict":
                  updateResourceIndex(ref pictResources, indexId, indexOffset);
                  break;
                case "Snd ":
                  updateResourceIndex(ref sndResources, indexId, indexOffset);
                  break;
                case "Data":
                  updateResourceIndex(ref dataResources, indexId, indexOffset);
                  break;
                case "Exec":
                  updateResourceIndex(ref execResources, indexId, indexOffset);
                  break;
                default:
                  Console.WriteLine("* unknown resource type {0}", indexType);
                  break;
              }
            }

            sawResources = true;
          }
          break;

        case "IFmd":
          if (metadataInfo != null)
            Console.WriteLine(" - extra ID metadata? This is unexpected!");
          else
            metadataInfo = info;
          break;

        case "Fspc":
          if (coverImage.HasValue)
            Console.WriteLine(" - already have a Frontspiece!  Unexpected!");
          else
            coverImage = reader.ReadUint(info.Offset + 8);
          break;
      }
    }

    private static void updateResourceIndex(ref Dictionary<uint, uint> resources, uint index, uint offset)
    {
      if (resources == null)
        resources = new Dictionary<uint, uint>();

      if (resources.ContainsKey(index))
      {
        Console.WriteLine("* resource dictionary already has an item with index {0}!", index);
        return;
      }

      resources.Add(index, offset);
    }
  }
}