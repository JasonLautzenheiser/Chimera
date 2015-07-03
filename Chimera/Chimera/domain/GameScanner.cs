using System.Collections.Generic;
using System.IO;
using System.Linq;
using TreatyOfBabel;

namespace Chimera.domain
{
  public class GameScanner
  {
    public List<GameModel> RetrieveGamesFromDirectory(string pDir)
    {
      return getGames(pDir);
    }

    private List<GameModel> getGames(string rootPath)
    {
      if (string.IsNullOrEmpty(rootPath) || !Directory.Exists(rootPath))
      {
        return null;
      }

      // Use the Treaty of Babel helper to understand the files...
      var helper = new TreatyHelper();
      var files = Directory.EnumerateFiles(rootPath, "*.*", SearchOption.AllDirectories);
      return (from file in files where helper.IsTreatyFile(file) select new GameModel(file, rootPath)).ToList();
    }
  }
}