using System;
using System.IO;

namespace TreatyOfBabel
{
  public abstract class TreatyStoryFileHandlerBase : IStoryFileHandler
  {
    private bool disposed;

    protected TreatyStoryFileHandlerBase(ITreatyProvider provider, IStoryFile storyFile)
    {
      Provider = provider;
      StoryFile = storyFile;
    }

    public IStoryFile StoryFile { get; private set; }
    public ITreatyProvider Provider { get; }
    // All implementations must provide this...
    public abstract string GetStoryFileExtension();
    // These methods are optional, not all formats support them.
    public virtual string GetStoryFileIfid()
    {
      return null;
    }

    public virtual Stream GetStoryFileMetadata()
    {
      return null;
    }

    public virtual Stream GetStoryFileCover()
    {
      return null;
    }

    public void Dispose()
    {
      Dispose(true);
      GC.SuppressFinalize(this);
    }

    protected virtual void Dispose(bool disposing)
    {
      if (!disposed)
      {
        if (disposing)
        {
          // Not sure if we want to do this here!
          ////if (this.StoryFile != null)
          ////{
          ////    this.StoryFile.Dispose();
          ////    this.StoryFile = null;
          ////}
        }

        disposed = true;
      }
    }
  }
}