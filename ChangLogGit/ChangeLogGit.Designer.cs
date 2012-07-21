namespace ChangLogGit
{
  partial class ChangLogGit
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
      this.txtRepos = new System.Windows.Forms.TextBox();
      this.lblRepo = new System.Windows.Forms.Label();
      this.dataGridView1 = new System.Windows.Forms.DataGridView();
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
      this.SuspendLayout();
      // 
      // txtRepos
      // 
      this.txtRepos.Location = new System.Drawing.Point(112, 25);
      this.txtRepos.Name = "txtRepos";
      this.txtRepos.Size = new System.Drawing.Size(140, 20);
      this.txtRepos.TabIndex = 0;
      // 
      // lblRepo
      // 
      this.lblRepo.AutoSize = true;
      this.lblRepo.Location = new System.Drawing.Point(41, 28);
      this.lblRepo.Name = "lblRepo";
      this.lblRepo.Size = new System.Drawing.Size(65, 13);
      this.lblRepo.TabIndex = 1;
      this.lblRepo.Text = "Repositories";
      // 
      // dataGridView1
      // 
      this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dataGridView1.Location = new System.Drawing.Point(23, 70);
      this.dataGridView1.Name = "dataGridView1";
      this.dataGridView1.Size = new System.Drawing.Size(619, 348);
      this.dataGridView1.TabIndex = 2;
      // 
      // ChangLogGit
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(710, 452);
      this.Controls.Add(this.dataGridView1);
      this.Controls.Add(this.lblRepo);
      this.Controls.Add(this.txtRepos);
      this.Name = "ChangLogGit";
      this.Text = "Change Log Git";
      ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox txtRepos;
    private System.Windows.Forms.Label lblRepo;
    private System.Windows.Forms.DataGridView dataGridView1;
  }
}

