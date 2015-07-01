using System;
using System.IO;

namespace TreatyOfBabel
{
  public interface IStoryFileHandler : IDisposable
  {
    ITreatyProvider Provider { get; }
    string GetStoryFileExtension();
    string GetStoryFileIfid();
    Stream GetStoryFileMetadata();
    Stream GetStoryFileCover();
  }
}