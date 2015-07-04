using System.Collections.Generic;
using Chimera.domain;

namespace Chimera.repositories
{
  public class GameRepo
  {
    public List<GameModel> GetAllGames()
    {
      List<GameModel> list;
      using (var db = DatabaseFactory.InitializeFactory(Session.CurrentDatabase.Path).GetDatabase())
      {
        list = db.Fetch<GameModel>();
      }
      return list;
    }

    public void SaveGame(GameModel game)
    {
      using (var db = DatabaseFactory.InitializeFactory(Session.CurrentDatabase.Path).GetDatabase())
      {
        db.Save(game);
      }
    }

    public void SaveGames(List<GameModel> gameList)
    {
      using (var db = DatabaseFactory.InitializeFactory(Session.CurrentDatabase.Path).GetDatabase())
      {
        foreach (var gameModel in gameList)
        {
          db.Save(gameModel);
        }
      }
    }
  }
}