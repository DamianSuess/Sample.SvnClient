namespace SimpleSvnClient
{
  partial class Form1
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
      this.BtnLogHistory = new System.Windows.Forms.Button();
      this.txtRepo = new System.Windows.Forms.TextBox();
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.txtPass = new System.Windows.Forms.TextBox();
      this.label3 = new System.Windows.Forms.Label();
      this.txtUser = new System.Windows.Forms.TextBox();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.BtnCheckout = new System.Windows.Forms.Button();
      this.lblProgress = new System.Windows.Forms.Label();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // BtnLogHistory
      // 
      this.BtnLogHistory.Location = new System.Drawing.Point(278, 28);
      this.BtnLogHistory.Name = "BtnLogHistory";
      this.BtnLogHistory.Size = new System.Drawing.Size(75, 23);
      this.BtnLogHistory.TabIndex = 0;
      this.BtnLogHistory.Text = "Log History";
      this.BtnLogHistory.UseVisualStyleBackColor = true;
      this.BtnLogHistory.Click += new System.EventHandler(this.BtnLogHistory_Click);
      // 
      // txtRepo
      // 
      this.txtRepo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtRepo.Location = new System.Drawing.Point(48, 19);
      this.txtRepo.Name = "txtRepo";
      this.txtRepo.Size = new System.Drawing.Size(205, 20);
      this.txtRepo.TabIndex = 1;
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.txtPass);
      this.groupBox1.Controls.Add(this.label3);
      this.groupBox1.Controls.Add(this.txtUser);
      this.groupBox1.Controls.Add(this.label2);
      this.groupBox1.Controls.Add(this.label1);
      this.groupBox1.Controls.Add(this.txtPath);
      this.groupBox1.Controls.Add(this.txtRepo);
      this.groupBox1.Location = new System.Drawing.Point(13, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(259, 103);
      this.groupBox1.TabIndex = 2;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Login";
      // 
      // txtPass
      // 
      this.txtPass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPass.Location = new System.Drawing.Point(144, 71);
      this.txtPass.Name = "txtPass";
      this.txtPass.Size = new System.Drawing.Size(109, 20);
      this.txtPass.TabIndex = 6;
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(6, 74);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(32, 13);
      this.label3.TabIndex = 5;
      this.label3.Text = "URL:";
      // 
      // txtUser
      // 
      this.txtUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtUser.Location = new System.Drawing.Point(48, 71);
      this.txtUser.Name = "txtUser";
      this.txtUser.Size = new System.Drawing.Size(90, 20);
      this.txtUser.TabIndex = 3;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(6, 48);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(32, 13);
      this.label2.TabIndex = 4;
      this.label2.Text = "Path:";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(6, 22);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(36, 13);
      this.label1.TabIndex = 3;
      this.label1.Text = "Repo:";
      // 
      // txtPath
      // 
      this.txtPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtPath.Location = new System.Drawing.Point(48, 45);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(205, 20);
      this.txtPath.TabIndex = 2;
      // 
      // BtnCheckout
      // 
      this.BtnCheckout.Location = new System.Drawing.Point(278, 60);
      this.BtnCheckout.Name = "BtnCheckout";
      this.BtnCheckout.Size = new System.Drawing.Size(75, 23);
      this.BtnCheckout.TabIndex = 3;
      this.BtnCheckout.Text = "Checkout";
      this.BtnCheckout.UseVisualStyleBackColor = true;
      this.BtnCheckout.Click += new System.EventHandler(this.BtnCheckout_Click);
      // 
      // lblProgress
      // 
      this.lblProgress.AutoSize = true;
      this.lblProgress.Location = new System.Drawing.Point(13, 122);
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new System.Drawing.Size(71, 13);
      this.lblProgress.TabIndex = 4;
      this.lblProgress.Text = "Progress: Idle";
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(362, 155);
      this.Controls.Add(this.lblProgress);
      this.Controls.Add(this.BtnCheckout);
      this.Controls.Add(this.groupBox1);
      this.Controls.Add(this.BtnLogHistory);
      this.Name = "Form1";
      this.Text = "SVNSharp Client";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

        #endregion

        private System.Windows.Forms.Button BtnLogHistory;
        private System.Windows.Forms.TextBox txtRepo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPath;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.Button BtnCheckout;
        private System.Windows.Forms.Label lblProgress;
    }
}

