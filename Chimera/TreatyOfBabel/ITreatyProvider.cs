namespace TreatyOfBabel
{
  public interface ITreatyProvider
  {
    string FormatName { get; }
    string HomePage { get; }
    string[] FileExtensions { get; }
    uint Popularity { get; }
    bool ClaimStoryFile(IStoryFile storyFile);
    IStoryFileHandler GetStoryFileHandler(IStoryFile storyFile);

    ////string GetStoryFileExtension(IStoryFile storyFile);

    ////string GetStoryFileIfid(IStoryFile storyFile);

    ////////void GetStoryFileMetadataExtent(IStoryFile storyFile);
    ////Stream GetStoryFileMetadata(IStoryFile storyFile);

    ////////void GetStoryFileCoverExtent(IStoryFile storyFile);
    ////////void GetStoryFileCoverFormat(IStoryFile storyFile);
    ////Stream GetStoryFileCover(IStoryFile storyFile);
  }
}