using System.IO;
using Chimera.domain;
using Chimera.repositories;

namespace Chimera
{
  public static class Session
  {
    public static GameDatabase CurrentDatabase { get; set; }


    public static void OpenDatabase(string pDatabase)
    {
      if (!DatabaseFactory.DatabaseFileExists(pDatabase))
        DatabaseFactory.CreateDatabase(pDatabase);

      var database = new GameDatabase
      {
        Path = pDatabase,
        Name = Path.GetFileName(pDatabase)
      };

      CurrentDatabase = database;
    }

  }
}