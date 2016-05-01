using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Chimera.domain;
using Chimera.repositories;
using TreatyOfBabel;

namespace Chimera
{
  public partial class MainForm : Form
  {
    const string GAME_PATH = @"C:\Users\Lautz\Dropbox\Interactive Fiction\games\Emily Short";

    private readonly GameDisplays display;
    private List<GameModel> gameList;
    private Grouping currentGroup = Grouping.Genre;
    

    public MainForm()
    {
      InitializeComponent();

      Session.LoadOptions();

      display = new GameDisplays {MainListing = lvGames};
      Text = $"Chimera - v{Application.ProductVersion}";

      Session.OpenDatabase();

      var repo = new GameRepo();
      gameList = repo.GetAllGames();
      changeGrouping(currentGroup);

    }

    public override sealed string Text
    {
      get { return base.Text; }
      set { base.Text = value; }
    }

    private void btnGetGames_Click(object sender, EventArgs e)
    {
      var scanner = new GameScanner();
      gameList = scanner.RetrieveGamesFromDirectory(GAME_PATH);

      changeGrouping(currentGroup);

      var repo = new GameRepo();
      repo.SaveGames(gameList);
    }

    private void lvGames_SelectedIndexChanged(object sender, EventArgs e)
    {
      var game = getCurrentlySelectedGame();

      pict.Image = game?.FullImage;
      lblAuthor.Text = game?.Author;
      lblDescription.Text = game?.Description;
      lblHeadline.Text = game?.Headline;
      lblTitle.Text = game?.Title;

    }

    private void rGenre_CheckedChanged(object sender, EventArgs e)
    {
      changeGrouping(Grouping.Genre);
    }

    private void rAuthor_CheckedChanged(object sender, EventArgs e)
    {
      changeGrouping(Grouping.Author);
    }

    private void changeGrouping(Grouping group)
    {
      currentGroup = group;
      switch (currentGroup)
      {
        case Grouping.Genre:
          display.ListingByGenre(gameList);
          break;
        case Grouping.Author:
          display.ListingByAuthor(gameList);
          break;
        case Grouping.Format:
          display.ListingByFormat(gameList);
          break;
        default:
          throw new ArgumentOutOfRangeException(nameof(@group), @group, null);
      }
    }

    private void rFormat_CheckedChanged(object sender, EventArgs e)
    {
      changeGrouping(Grouping.Format);
    }

    private void btnPlay_Click(object sender, EventArgs e)
    {
      var game = getCurrentlySelectedGame();
      game?.Play();
    }

    private GameModel getCurrentlySelectedGame()
    {
      if (lvGames.SelectedItems.Count <= 0) return null;
      GameModel game = null;
      var tag = lvGames.SelectedItems[0].Tag;
      if (tag != null)
      {
        game = (GameModel) tag;
      }

      return game;
    }
    
    private void pnlDescription_Paint(object sender, PaintEventArgs e)
    {
      lblDescription.MaximumSize = new Size(pnlDescription.Width - 30,0);
      lblDescription.Refresh();
    }

    private void exitToolStripMenuItem_Click(object sender, EventArgs e)
    {
        Close();
    }

    private void addFileToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var fileChooser = new OpenFileDialog {Multiselect = true};

      if (fileChooser.ShowDialog() != DialogResult.OK) return;

      var safeFileNames = fileChooser.FileNames;
    
      if (!safeFileNames.Any()) return;

      var helper = new TreatyHelper();
      var repo = new GameRepo();

      foreach (var game in from fileName in safeFileNames where helper.IsTreatyFile(fileName) select new GameModel(fileName))
        repo.SaveGame(game);
    }

    private void scanFolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      FolderBrowserDialog dlg = new FolderBrowserDialog();

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        var path = dlg.SelectedPath;

        var files = Directory.GetFiles(path);

        var helper = new TreatyHelper();
        var repo = new GameRepo();

        foreach (var file in files)
        {
          if (helper.IsTreatyFile(file))
          {
            var game = new GameModel(file);
            repo.SaveGame(game);
          }
        }
      }


    }

    private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var frm = new Options();

      if (frm.ShowDialog() == DialogResult.OK)
      {
        
      }

    }
  }

  public enum Grouping
  {
    Genre,
    Author,
    Format
  }
}
