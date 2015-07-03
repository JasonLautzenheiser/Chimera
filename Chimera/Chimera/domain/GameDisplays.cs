using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Chimera.domain
{
  public class GameDisplays
  {
    public ListView MainListing { get; set; }

    public void ListingByGenre(List<GameModel> list)
    {
      MainListing.Columns.Clear();
      MainListing.Columns.Add("Title", "Title", 150);
      MainListing.Columns.Add("Author", "Author", 150);
      MainListing.Columns.Add("Description", "Description", 350);

      ImageList imgs = new ImageList();
      MainListing.SmallImageList = imgs;

      var genres = list.Select(p => p.Genre).Distinct().OrderBy(p => p);

      foreach (var genre in genres)
      {
        var games = list.Where(p => p.Genre == genre);
        MainListing.Groups.Add(new ListViewGroup(genre, genre));
        foreach (var game in games)
        {
          var item = new ListViewItem(new string[] {game.Title, game.Author, game.Description}, MainListing.Groups[genre]);
          item.Tag = game;
          if (game.ThumbImage != null)
          {
            imgs.Images.Add(game.ThumbImage);
            item.ImageIndex = imgs.Images.Count - 1;
          }          
          MainListing.Items.Add(item);
        }
      }

    }
  }
}