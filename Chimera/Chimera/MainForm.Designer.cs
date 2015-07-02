using MetroFramework.Controls;

namespace Chimera
{
  partial class MainForm
  {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
      System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
      this.metroGrid1 = new MetroFramework.Controls.MetroGrid();
      this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
      this.txtPath = new MetroFramework.Controls.MetroTextBox();
      this.txtPathBrowse = new MetroFramework.Controls.MetroButton();
      this.btnGo = new MetroFramework.Controls.MetroButton();
      ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).BeginInit();
      this.SuspendLayout();
      // 
      // metroGrid1
      // 
      this.metroGrid1.AllowUserToAddRows = false;
      this.metroGrid1.AllowUserToDeleteRows = false;
      this.metroGrid1.AllowUserToResizeRows = false;
      this.metroGrid1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.metroGrid1.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.metroGrid1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
      this.metroGrid1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.metroGrid1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
      this.metroGrid1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(136)))), ((int)(((byte)(136)))), ((int)(((byte)(136)))));
      dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
      this.metroGrid1.DefaultCellStyle = dataGridViewCellStyle2;
      this.metroGrid1.EnableHeadersVisualStyles = false;
      this.metroGrid1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      this.metroGrid1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      this.metroGrid1.Location = new System.Drawing.Point(23, 154);
      this.metroGrid1.Name = "metroGrid1";
      this.metroGrid1.ReadOnly = true;
      this.metroGrid1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
      dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
      dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
      dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
      dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
      dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
      dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
      this.metroGrid1.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
      this.metroGrid1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
      this.metroGrid1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
      this.metroGrid1.Size = new System.Drawing.Size(1044, 398);
      this.metroGrid1.TabIndex = 0;
      // 
      // metroLabel1
      // 
      this.metroLabel1.AutoSize = true;
      this.metroLabel1.Location = new System.Drawing.Point(23, 52);
      this.metroLabel1.Name = "metroLabel1";
      this.metroLabel1.Size = new System.Drawing.Size(131, 19);
      this.metroLabel1.TabIndex = 1;
      this.metroLabel1.Text = "Enter Path to Games:";
      this.metroLabel1.Click += new System.EventHandler(this.metroLabel1_Click);
      // 
      // txtPath
      // 
      this.txtPath.Lines = new string[0];
      this.txtPath.Location = new System.Drawing.Point(23, 75);
      this.txtPath.MaxLength = 32767;
      this.txtPath.Name = "txtPath";
      this.txtPath.PasswordChar = '\0';
      this.txtPath.ScrollBars = System.Windows.Forms.ScrollBars.None;
      this.txtPath.SelectedText = "";
      this.txtPath.Size = new System.Drawing.Size(275, 23);
      this.txtPath.TabIndex = 2;
      this.txtPath.UseSelectable = true;
      // 
      // txtPathBrowse
      // 
      this.txtPathBrowse.Location = new System.Drawing.Point(313, 75);
      this.txtPathBrowse.Name = "txtPathBrowse";
      this.txtPathBrowse.Size = new System.Drawing.Size(28, 23);
      this.txtPathBrowse.TabIndex = 3;
      this.txtPathBrowse.Text = "...";
      this.txtPathBrowse.UseSelectable = true;
      this.txtPathBrowse.Click += new System.EventHandler(this.txtPathBrowse_Click);
      // 
      // btnGo
      // 
      this.btnGo.Location = new System.Drawing.Point(23, 125);
      this.btnGo.Name = "btnGo";
      this.btnGo.Size = new System.Drawing.Size(75, 23);
      this.btnGo.TabIndex = 4;
      this.btnGo.Text = "Go";
      this.btnGo.UseSelectable = true;
      this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1090, 570);
      this.Controls.Add(this.btnGo);
      this.Controls.Add(this.txtPathBrowse);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.metroLabel1);
      this.Controls.Add(this.metroGrid1);
      this.Name = "MainForm";
      this.Text = "Form1";
      ((System.ComponentModel.ISupportInitialize)(this.metroGrid1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private MetroGrid metroGrid1;
    private MetroLabel metroLabel1;
    private MetroTextBox txtPath;
    private MetroButton txtPathBrowse;
    private MetroButton btnGo;
  }
}

