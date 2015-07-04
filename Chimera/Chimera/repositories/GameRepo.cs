using System.Collections.Generic;
using Chimera.domain;
using NPoco;

namespace Chimera.repositories
{
  public class GameRepo
  {

    public List<GameModel> GetAllGames()
    {
      var db = new Database(Session.CurrentDatabase.ConnectionString,DatabaseType.SQLite);
      var list = db.Fetch<GameModel>();
      return list;
    }

    public void SaveGame(GameModel game)
    {
      var db = new Database(Session.CurrentDatabase.ConnectionString, DatabaseType.SQLite);
      db.Save(game);
    }
  }
}