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
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblHeadline = new System.Windows.Forms.Label();
      this.lblAuthor = new System.Windows.Forms.Label();
      this.pnlDescription = new System.Windows.Forms.Panel();
      this.lblDescription = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.pict)).BeginInit();
      this.pnlDescription.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnGetGames
      // 
      this.btnGetGames.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnGetGames.Location = new System.Drawing.Point(715, 581);
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
      this.lvGames.Location = new System.Drawing.Point(0, 26);
      this.lvGames.Name = "lvGames";
      this.lvGames.Size = new System.Drawing.Size(709, 581);
      this.lvGames.TabIndex = 2;
      this.lvGames.UseCompatibleStateImageBehavior = false;
      this.lvGames.View = System.Windows.Forms.View.Details;
      this.lvGames.SelectedIndexChanged += new System.EventHandler(this.lvGames_SelectedIndexChanged);
      // 
      // pict
      // 
      this.pict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pict.Location = new System.Drawing.Point(726, 27);
      this.pict.Name = "pict";
      this.pict.Size = new System.Drawing.Size(300, 300);
      this.pict.TabIndex = 3;
      this.pict.TabStop = false;
      // 
      // menuStrip1
      // 
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(1038, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
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
      this.lblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblTitle.Font = new System.Drawing.Font("Arial", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblTitle.Location = new System.Drawing.Point(726, 334);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(300, 23);
      this.lblTitle.TabIndex = 6;
      // 
      // lblHeadline
      // 
      this.lblHeadline.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblHeadline.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblHeadline.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
      this.lblHeadline.Location = new System.Drawing.Point(726, 357);
      this.lblHeadline.Name = "lblHeadline";
      this.lblHeadline.Size = new System.Drawing.Size(300, 23);
      this.lblHeadline.TabIndex = 7;
      // 
      // lblAuthor
      // 
      this.lblAuthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lblAuthor.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblAuthor.ForeColor = System.Drawing.Color.Black;
      this.lblAuthor.Location = new System.Drawing.Point(726, 380);
      this.lblAuthor.Name = "lblAuthor";
      this.lblAuthor.Size = new System.Drawing.Size(300, 23);
      this.lblAuthor.TabIndex = 8;
      // 
      // pnlDescription
      // 
      this.pnlDescription.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlDescription.AutoScroll = true;
      this.pnlDescription.Controls.Add(this.lblDescription);
      this.pnlDescription.Location = new System.Drawing.Point(726, 407);
      this.pnlDescription.Name = "pnlDescription";
      this.pnlDescription.Size = new System.Drawing.Size(297, 138);
      this.pnlDescription.TabIndex = 9;
      // 
      // lblDescription
      // 
      this.lblDescription.AutoSize = true;
      this.lblDescription.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblDescription.Location = new System.Drawing.Point(4, 4);
      this.lblDescription.MaximumSize = new System.Drawing.Size(250, 1000);
      this.lblDescription.Name = "lblDescription";
      this.lblDescription.Size = new System.Drawing.Size(41, 15);
      this.lblDescription.TabIndex = 0;
      this.lblDescription.Text = "label1";
      // 
      // MainForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1038, 629);
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
  }
}

