using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chimera
{
  public partial class Options : Form
  {
    public Options()
    {
      InitializeComponent();
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
      Session.Options.DatabaseFile = txtDataPath.Text;

      Session.SaveOptions();

      DialogResult = DialogResult.OK;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      DialogResult = DialogResult.Cancel;
    }

    private void Options_Load(object sender, EventArgs e)
    {
      txtDataPath.Text = Session.Options.DatabaseFile;
    }

    private void btnChooseDataPath_Click(object sender, EventArgs e)
    {
      OpenFileDialog dlg = new OpenFileDialog();

      if (dlg.ShowDialog() == DialogResult.OK)
      {
        txtDataPath.Text = dlg.FileName;
      }
    }
  }
}
