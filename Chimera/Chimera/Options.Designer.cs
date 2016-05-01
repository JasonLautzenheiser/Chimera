namespace Chimera
{
  partial class Options
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
      this.label1 = new System.Windows.Forms.Label();
      this.btnSave = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnChooseDataPath = new System.Windows.Forms.Button();
      this.txtDataPath = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(13, 13);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(87, 13);
      this.label1.TabIndex = 0;
      this.label1.Text = "Game Database:";
      // 
      // btnSave
      // 
      this.btnSave.Location = new System.Drawing.Point(142, 253);
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(75, 23);
      this.btnSave.TabIndex = 2;
      this.btnSave.Text = "Save";
      this.btnSave.UseVisualStyleBackColor = true;
      this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.Location = new System.Drawing.Point(223, 253);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(75, 23);
      this.btnCancel.TabIndex = 3;
      this.btnCancel.Text = "Cancel";
      this.btnCancel.UseVisualStyleBackColor = true;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnChooseDataPath
      // 
      this.btnChooseDataPath.Location = new System.Drawing.Point(261, 29);
      this.btnChooseDataPath.Name = "btnChooseDataPath";
      this.btnChooseDataPath.Size = new System.Drawing.Size(24, 22);
      this.btnChooseDataPath.TabIndex = 4;
      this.btnChooseDataPath.Text = "...";
      this.btnChooseDataPath.UseVisualStyleBackColor = true;
      this.btnChooseDataPath.Click += new System.EventHandler(this.btnChooseDataPath_Click);
      // 
      // txtDataPath
      // 
      this.txtDataPath.Location = new System.Drawing.Point(16, 30);
      this.txtDataPath.Name = "txtDataPath";
      this.txtDataPath.Size = new System.Drawing.Size(243, 20);
      this.txtDataPath.TabIndex = 1;
      // 
      // Options
      // 
      this.AcceptButton = this.btnSave;
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(310, 288);
      this.Controls.Add(this.btnChooseDataPath);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnSave);
      this.Controls.Add(this.txtDataPath);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Options";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Options";
      this.Load += new System.EventHandler(this.Options_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnCancel;
    private System.Windows.Forms.Button btnChooseDataPath;
    private System.Windows.Forms.TextBox txtDataPath;
  }
}