using System;
using System.Linq;
using System.Windows.Forms;
using Chimera.domain;

namespace Chimera
{
  public partial class MainForm : Form
  {
    const string GAME_PATH = @"C:\Users\Lautz\Dropbox\Interactive Fiction\games\Emily Short";

    private GameDisplays display;

    public MainForm()
    {
      InitializeComponent();
      display = new GameDisplays {MainListing = lvGames};
      Text = $"Chimera - v{Application.ProductVersion}";
    }

    private void btnGetGames_Click(object sender, EventArgs e)
    {
      var scanner = new GameScanner();
      var list = scanner.RetrieveGamesFromDirectory(GAME_PATH);

      display.ListingByGenre(list);

    }

    private void lvGames_SelectedIndexChanged(object sender, EventArgs e)
    {
      if (lvGames.SelectedItems.Count <= 0) return;

      GameModel game = null;


      var tag = lvGames.SelectedItems[0].Tag;
      if (tag != null)
      {
        game = (GameModel) tag;
      }
      pict.Image = game?.FullImage;
      lblAuthor.Text = game?.Author;
      lblDescription.Text = game?.Description;
      lblHeadline.Text = game?.Headline;
      lblTitle.Text = game?.Title;

    }
  }
}
