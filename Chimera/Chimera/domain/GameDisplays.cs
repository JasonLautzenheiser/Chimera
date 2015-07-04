using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Chimera.repositories;

namespace Chimera.domain
{
  public class GameDisplays
  {
    public ListView MainListing { get; set; }

    public void ListingByGenre(List<GameModel> list, bool save = false)
    {
      MainListing.Clear();
      MainListing.Columns.Add("Title", "Title", 150);
      MainListing.Columns.Add("Author", "Author", 150);
      MainListing.Columns.Add("Format", "Format", 100);
      MainListing.Columns.Add("Year", "Year", 100);
      MainListing.Columns.Add("Description", "Description", 350);

      ImageList imgs = new ImageList();
      MainListing.SmallImageList = imgs;

      var repo = new GameRepo();

      if (list != null) {
        var genres = list.Select(p => p.Genre).Distinct().OrderBy(p => p);

        foreach (var genre in genres)
        {
          var games = list.Where(p => p.Genre == genre);
          MainListing.Groups.Add(new ListViewGroup(genre, genre));
          foreach (var game in games)
          {
            if (save) repo.SaveGame(game);
            var item = new ListViewItem(new string[] {game.Title, game.Author, game.Format, game.FirstPublished, game.Description}, MainListing.Groups[genre]);
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

    public void ListingByAuthor(List<GameModel> list)
    {
      MainListing.Clear();
      MainListing.Columns.Add("Title", "Title", 150);
      MainListing.Columns.Add("Genre", "Genre", 150);
      MainListing.Columns.Add("Format", "Format", 100);
      MainListing.Columns.Add("Description", "Description", 350);

      ImageList imgs = new ImageList();
      MainListing.SmallImageList = imgs;

      var authors = list.Select(p => p.Author).Distinct().OrderBy(p => p);

      foreach (var author in authors)
      {
        var games = list.Where(p => p.Author == author);
        MainListing.Groups.Add(new ListViewGroup(author, author));
        foreach (var game in games)
        {
          var item = new ListViewItem(new string[] { game.Title, game.Genre, game.Format, game.Description }, MainListing.Groups[author]);
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

    public void ListingByFormat(List<GameModel> list)
    {
      MainListing.Clear();
      MainListing.Columns.Add("Title", "Title", 150);
      MainListing.Columns.Add("Genre", "Genre", 150);
      MainListing.Columns.Add("Author", "Author", 100);
      MainListing.Columns.Add("Description", "Description", 350);

      ImageList imgs = new ImageList();
      MainListing.SmallImageList = imgs;

      var formats = list.Select(p => p.Format).Distinct().OrderBy(p => p);

      foreach (var format in formats)
      {
        var games = list.Where(p => p.Format == format);
        MainListing.Groups.Add(new ListViewGroup(format, format));
        foreach (var game in games)
        {
          var item = new ListViewItem(new string[] { game.Title, game.Genre, game.Author, game.Description }, MainListing.Groups[format]);
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