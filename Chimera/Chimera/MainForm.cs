using System;
using System.IO;
using System.Windows.Forms;
using MetroFramework.Forms;

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
  }
}
