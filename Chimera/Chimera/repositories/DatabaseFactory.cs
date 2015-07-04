using System.Data.SQLite;
using System.IO;
using NPoco;

namespace Chimera.repositories
{
  public static class DatabaseFactory
  {
    public static void CreateDatabase(string pDatabaseFile)
    {
      if (!DatabaseFileExists(pDatabaseFile))
      {
        SQLiteConnection.CreateFile(pDatabaseFile);
        setupTables(pDatabaseFile);
      }
    }

    private static void setupTables(string file)
    {
      var db = new Database($"Data Source = {file}; Version = 3; ", DatabaseType.SQLite);
      setupVersionTable(db);

      setupGameTable(db);
    }

    private static void setupVersionTable(Database db)
    {
      string sql = "create table version (appVersion text, appVersionDate numeric)";
      db.Execute(sql);
    }

    private static void setupGameTable(Database db)
    {
      string sql = "Create table games (fullpath text, relativepath text, ifid text, format text, bafn text, title text, author text, " +
                   "language text, headline text, firstpublished text, genre text, description text, series text, seriesnumber text, forgiveness text, " +
                   "url text, authoremail text, fullimage blob, thumbnail blob)";

      db.Execute(sql);
    }


    public static bool DatabaseFileExists(string pDatabaseFile)
    {
      return File.Exists(pDatabaseFile);
    }

  }
}