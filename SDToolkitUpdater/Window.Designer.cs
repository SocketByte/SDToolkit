namespace SDToolkitUpdater
{
    partial class Window
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.installBar = new System.Windows.Forms.ProgressBar();
            this.downloadBar = new System.Windows.Forms.ProgressBar();
            this.updateLabel = new System.Windows.Forms.Label();
            this.downloadLabel = new System.Windows.Forms.Label();
            this.installLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // installBar
            // 
            this.installBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.installBar.Location = new System.Drawing.Point(12, 60);
            this.installBar.Name = "installBar";
            this.installBar.Size = new System.Drawing.Size(434, 23);
            this.installBar.TabIndex = 0;
            // 
            // downloadBar
            // 
            this.downloadBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadBar.Location = new System.Drawing.Point(12, 31);
            this.downloadBar.Name = "downloadBar";
            this.downloadBar.Size = new System.Drawing.Size(434, 23);
            this.downloadBar.TabIndex = 1;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.Location = new System.Drawing.Point(9, 9);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(59, 13);
            this.updateLabel.TabIndex = 2;
            this.updateLabel.Text = "Updating...";
            // 
            // downloadLabel
            // 
            this.downloadLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.downloadLabel.AutoSize = true;
            this.downloadLabel.Location = new System.Drawing.Point(453, 36);
            this.downloadLabel.Name = "downloadLabel";
            this.downloadLabel.Size = new System.Drawing.Size(21, 13);
            this.downloadLabel.TabIndex = 3;
            this.downloadLabel.Text = "0%";
            // 
            // installLabel
            // 
            this.installLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.installLabel.AutoSize = true;
            this.installLabel.Location = new System.Drawing.Point(453, 65);
            this.installLabel.Name = "installLabel";
            this.installLabel.Size = new System.Drawing.Size(21, 13);
            this.installLabel.TabIndex = 4;
            this.installLabel.Text = "0%";
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 95);
            this.Controls.Add(this.installLabel);
            this.Controls.Add(this.downloadLabel);
            this.Controls.Add(this.updateLabel);
            this.Controls.Add(this.downloadBar);
            this.Controls.Add(this.installBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(505, 134);
            this.MinimumSize = new System.Drawing.Size(505, 134);
            this.Name = "Window";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SDToolkit Updater";
            this.Load += new System.EventHandler(this.Window_Load);
            this.Shown += new System.EventHandler(this.Window_Shown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar installBar;
        private System.Windows.Forms.ProgressBar downloadBar;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Label downloadLabel;
        private System.Windows.Forms.Label installLabel;
    }
}

