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
      this.btnGetGames = new System.Windows.Forms.Button();
      this.lvGames = new System.Windows.Forms.ListView();
      this.pict = new System.Windows.Forms.PictureBox();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scanFolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblHeadline = new System.Windows.Forms.Label();
      this.lblAuthor = new System.Windows.Forms.Label();
      this.pnlDescription = new System.Windows.Forms.Panel();
      this.lblDescription = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.rGenre = new System.Windows.Forms.RadioButton();
      this.rAuthor = new System.Windows.Forms.RadioButton();
      this.rFormat = new System.Windows.Forms.RadioButton();
      this.btnPlay = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
      this.menuStrip1.SuspendLayout();
      this.pnlDescription.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGetGames
      // 
      this.btnGetGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetGames.Location = new System.Drawing.Point(870, 581);
      this.btnGetGames.Name = "btnGetGames";
      this.btnGetGames.Size = new System.Drawing.Size(75, 23);
      this.btnGetGames.TabIndex = 1;
      this.btnGetGames.Text = "Go...";
      this.btnGetGames.UseVisualStyleBackColor = true;
      this.btnGetGames.Click += new System.EventHandler(this.btnGetGames_Click);
      // 
      // lvGames
      // 
      this.lvGames.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lvGames.FullRowSelect = true;
      this.lvGames.Location = new System.Drawing.Point(0, 52);
      this.lvGames.Name = "lvGames";
      this.lvGames.Size = new System.Drawing.Size(1026, 259);
      this.lvGames.TabIndex = 2;
      this.lvGames.UseCompatibleStateImageBehavior = false;
      this.lvGames.View = System.Windows.Forms.View.Details;
      this.lvGames.SelectedIndexChanged += new System.EventHandler(this.lvGames_SelectedIndexChanged);
      // 
      // pict
      // 
      this.pict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.pict.Location = new System.Drawing.Point(0, 317);
      this.pict.Name = "pict";
      this.pict.Size = new System.Drawing.Size(300, 300);
      this.pict.TabIndex = 3;
      this.pict.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.toolsToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addFileToolStripMenuItem,
            this.scanFolderToolStripMenuItem,
            this.toolStripSeparator1,
            this.exitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // addFileToolStripMenuItem
      // 
      this.addFileToolStripMenuItem.Name = "addFileToolStripMenuItem";
      this.addFileToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.addFileToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.addFileToolStripMenuItem.Text = "Add File";
      this.addFileToolStripMenuItem.Click += new System.EventHandler(this.addFileToolStripMenuItem_Click);
      // 
      // scanFolderToolStripMenuItem
      // 
      this.scanFolderToolStripMenuItem.Name = "scanFolderToolStripMenuItem";
      this.scanFolderToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
      this.scanFolderToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.scanFolderToolStripMenuItem.Text = "Scan Folder";
      this.scanFolderToolStripMenuItem.Click += new System.EventHandler(this.scanFolderToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(207, 6);
      // 
      // exitToolStripMenuItem
      // 
      this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
      this.exitToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
      this.exitToolStripMenuItem.Text = "E&xit";
      this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
      // 
      // toolsToolStripMenuItem
      // 
      this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
      this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
      this.toolsToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
      this.toolsToolStripMenuItem.Text = "Tools";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
      this.optionsToolStripMenuItem.Text = "Options...";
      this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.Location = new System.Drawing.Point(0, 607);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1038, 22);
      this.statusStrip1.TabIndex = 5;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblTitle
      // 
      this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblTitle.Location = new System.Drawing.Point(306, 317);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(720, 23);
      this.lblTitle.TabIndex = 6;
      // 
      // lblHeadline
      // 
      this.lblHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblHeadline.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblHeadline.Location = new System.Drawing.Point(306, 340);
      this.lblHeadline.Name = "lblHeadline";
      this.lblHeadline.Size = new System.Drawing.Size(720, 23);
      this.lblHeadline.TabIndex = 7;
      // 
      // lblAuthor
      // 
      this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblAuthor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAuthor.ForeColor = System.Drawing.Color.Black;
      this.lblAuthor.Location = new System.Drawing.Point(306, 363);
      this.lblAuthor.Name = "lblAuthor";
      this.lblAuthor.Size = new System.Drawing.Size(720, 23);
      this.lblAuthor.TabIndex = 8;
      // 
      // pnlDescription
      // 
      this.pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlDescription.AutoScroll = true;
      this.pnlDescription.Controls.Add(this.lblDescription);
      this.pnlDescription.Location = new System.Drawing.Point(310, 411);
      this.pnlDescription.Name = "pnlDescription";
      this.pnlDescription.Size = new System.Drawing.Size(716, 138);
      this.pnlDescription.TabIndex = 9;
      this.pnlDescription.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDescription_Paint);
      // 
      // lblDescription
      // 
      this.lblDescription.AutoSize = true;
      this.lblDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDescription.Location = new System.Drawing.Point(4, 4);
      this.lblDescription.MaximumSize = new System.Drawing.Size(1000, 0);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(41, 15);
      this.lblDescription.TabIndex = 0;
      this.lblDescription.Text = "label1";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 30);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(54, 13);
      this.label1.TabIndex = 10;
      this.label1.Text = "Group By:";
      // 
      // rGenre
      // 
      this.rGenre.AutoSize = true;
      this.rGenre.Location = new System.Drawing.Point(74, 29);
      this.rGenre.Name = "rGenre";
      this.rGenre.Size = new System.Drawing.Size(54, 17);
      this.rGenre.TabIndex = 11;
      this.rGenre.TabStop = true;
      this.rGenre.Text = "Genre";
      this.rGenre.UseVisualStyleBackColor = true;
      this.rGenre.CheckedChanged += new System.EventHandler(this.rGenre_CheckedChanged);
      // 
      // rAuthor
      // 
      this.rAuthor.AutoSize = true;
      this.rAuthor.Location = new System.Drawing.Point(146, 28);
      this.rAuthor.Name = "rAuthor";
      this.rAuthor.Size = new System.Drawing.Size(56, 17);
      this.rAuthor.TabIndex = 12;
      this.rAuthor.TabStop = true;
      this.rAuthor.Text = "Author";
      this.rAuthor.UseVisualStyleBackColor = true;
      this.rAuthor.CheckedChanged += new System.EventHandler(this.rAuthor_CheckedChanged);
      // 
      // rFormat
      // 
      this.rFormat.AutoSize = true;
      this.rFormat.Location = new System.Drawing.Point(208, 28);
      this.rFormat.Name = "rFormat";
      this.rFormat.Size = new System.Drawing.Size(57, 17);
      this.rFormat.TabIndex = 13;
      this.rFormat.TabStop = true;
      this.rFormat.Text = "Format";
      this.rFormat.UseVisualStyleBackColor = true;
      this.rFormat.CheckedChanged += new System.EventHandler(this.rFormat_CheckedChanged);
      // 
      // btnPlay
      // 
      this.btnPlay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnPlay.Location = new System.Drawing.Point(951, 581);
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(75, 23);
      this.btnPlay.TabIndex = 14;
      this.btnPlay.Text = "Play";
      this.btnPlay.UseVisualStyleBackColor = true;
      this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1038, 629);
      this.Controls.Add(this.btnPlay);
      this.Controls.Add(this.rFormat);
      this.Controls.Add(this.rAuthor);
      this.Controls.Add(this.rGenre);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.pnlDescription);
      this.Controls.Add(this.lblAuthor);
      this.Controls.Add(this.lblHeadline);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lvGames);
      this.Controls.Add(this.statusStrip1);
      this.Controls.Add(this.pict);
      this.Controls.Add(this.btnGetGames);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Name = "MainForm";
      this.Text = "Chimera";
      ((System.ComponentModel.ISupportInitialize)(this.pict)).EndInit();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.pnlDescription.ResumeLayout(false);
      this.pnlDescription.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button btnGetGames;
    private System.Windows.Forms.ListView lvGames;
    private System.Windows.Forms.PictureBox pict;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.StatusStrip statusStrip1;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblHeadline;
    private System.Windows.Forms.Label lblAuthor;
    private System.Windows.Forms.Panel pnlDescription;
    private System.Windows.Forms.Label lblDescription;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.RadioButton rGenre;
    private System.Windows.Forms.RadioButton rAuthor;
    private System.Windows.Forms.RadioButton rFormat;
    private System.Windows.Forms.Button btnPlay;
    private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem addFileToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem scanFolderToolStripMenuItem;
    private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
    private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
  }
}

