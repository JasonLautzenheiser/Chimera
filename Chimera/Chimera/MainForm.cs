using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using TreatyOfBabel;

namespace Chimera
{
  public partial class MainForm : MetroForm
  {
    FolderBrowserDialog dialog;

    public MainForm()
    {
      InitializeComponent();
    }

    private void buttonItem1_Click(object sender, EventArgs e)
    {
      string folder = @"C:\Users\Lautz\Dropbox\Interactive Fiction\games";
      var files = Directory.GetFiles(folder, "*.*");

      populateGrid(files);

    }

    private void populateGrid(string[] files)
    {
      foreach (var file in files)
      {
        string fileName = Path.GetFileName(file);
      }
    }

    private void metroLabel1_Click(object sender, EventArgs e)
    {

    }

    private void txtPathBrowse_Click(object sender, EventArgs e)
    {
      txtPath.Text = @"C:\Users\Lautz\Dropbox\Interactive Fiction\games";
    }

    public List<GameModel> GetGames(string rootPath)
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

    private void btnGo_Click(object sender, EventArgs e)
    {
      var list = GetGames(txtPath.Text);
      metroGrid1.DataSource = list;
    }
  }
}
