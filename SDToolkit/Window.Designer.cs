
namespace SDToolkit
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Window));
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.GenerateButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.useGFPGAN = new System.Windows.Forms.CheckBox();
            this.debugBox = new System.Windows.Forms.TextBox();
            this.samplerCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.resWBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.resHBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.stepsBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.seedBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.promptBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.contextButton = new System.Windows.Forms.Button();
            this.contextImage = new System.Windows.Forms.PictureBox();
            this.contextRemoveButton = new System.Windows.Forms.Button();
            this.upscaleCombo = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.upscaleLabel = new System.Windows.Forms.Label();
            this.precisionCheck = new System.Windows.Forms.CheckBox();
            this.gpuInfoLabel = new System.Windows.Forms.Label();
            this.timerLabel = new System.Windows.Forms.Label();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextImage)).BeginInit();
            this.SuspendLayout();
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(12, 728);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(906, 23);
            this.progressBar.TabIndex = 0;
            // 
            // GenerateButton
            // 
            this.GenerateButton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GenerateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GenerateButton.Location = new System.Drawing.Point(12, 690);
            this.GenerateButton.Name = "GenerateButton";
            this.GenerateButton.Size = new System.Drawing.Size(906, 32);
            this.GenerateButton.TabIndex = 1;
            this.GenerateButton.Text = "Generate";
            this.GenerateButton.UseVisualStyleBackColor = true;
            this.GenerateButton.Click += new System.EventHandler(this.GenerateButton_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.pictureBox3);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.pictureBox0);
            this.panel1.Controls.Add(this.useGFPGAN);
            this.panel1.Controls.Add(this.debugBox);
            this.panel1.Controls.Add(this.samplerCombo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.resWBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.resHBox);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.stepsBox);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.seedBox);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.promptBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.contextButton);
            this.panel1.Controls.Add(this.contextImage);
            this.panel1.Controls.Add(this.contextRemoveButton);
            this.panel1.Controls.Add(this.upscaleCombo);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.upscaleLabel);
            this.panel1.Controls.Add(this.precisionCheck);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(906, 657);
            this.panel1.TabIndex = 2;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox7.Location = new System.Drawing.Point(683, 434);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(220, 220);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 28;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox6.Location = new System.Drawing.Point(457, 434);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(220, 220);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 27;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Click += new System.EventHandler(this.pictureBox6_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox5.Location = new System.Drawing.Point(231, 434);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(220, 220);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 26;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox4.Location = new System.Drawing.Point(3, 434);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(220, 220);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 25;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox3.Location = new System.Drawing.Point(683, 208);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(220, 220);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 24;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox2.Location = new System.Drawing.Point(457, 208);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(220, 220);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox1.Location = new System.Drawing.Point(231, 208);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(220, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 22;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pictureBox0.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox0.Location = new System.Drawing.Point(3, 208);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(220, 220);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox0.TabIndex = 19;
            this.pictureBox0.TabStop = false;
            this.pictureBox0.Click += new System.EventHandler(this.pictureBox0_Click);
            // 
            // useGFPGAN
            // 
            this.useGFPGAN.AutoSize = true;
            this.useGFPGAN.Location = new System.Drawing.Point(3, 137);
            this.useGFPGAN.Name = "useGFPGAN";
            this.useGFPGAN.Size = new System.Drawing.Size(252, 17);
            this.useGFPGAN.TabIndex = 29;
            this.useGFPGAN.Text = "Use GFPGAN for face restoration and upscaling";
            this.toolTip.SetToolTip(this.useGFPGAN, "Helpful for generating much better looking faces using GFPGAN 1.3 AI model.\r\n");
            this.useGFPGAN.UseVisualStyleBackColor = true;
            this.useGFPGAN.CheckedChanged += new System.EventHandler(this.useGFPGAN_CheckedChanged);
            // 
            // debugBox
            // 
            this.debugBox.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.debugBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.debugBox.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.debugBox.Enabled = false;
            this.debugBox.Location = new System.Drawing.Point(457, 46);
            this.debugBox.Multiline = true;
            this.debugBox.Name = "debugBox";
            this.debugBox.ReadOnly = true;
            this.debugBox.Size = new System.Drawing.Size(446, 151);
            this.debugBox.TabIndex = 21;
            // 
            // samplerCombo
            // 
            this.samplerCombo.FormattingEnabled = true;
            this.samplerCombo.Items.AddRange(new object[] {
            "DDIM",
            "PLMS",
            "HEUN",
            "EULER",
            "EULER_A",
            "DPM2",
            "DPM2_A",
            "LMS"});
            this.samplerCombo.Location = new System.Drawing.Point(215, 110);
            this.samplerCombo.Name = "samplerCombo";
            this.samplerCombo.Size = new System.Drawing.Size(236, 21);
            this.samplerCombo.TabIndex = 16;
            this.samplerCombo.Text = "PLMS";
            this.toolTip.SetToolTip(this.samplerCombo, "Sampler that the AI will use. PLMS is recommended.");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(215, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(45, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Sampler";
            this.toolTip.SetToolTip(this.label8, "Sampler that the AI will use. PLMS is recommended.");
            // 
            // resWBox
            // 
            this.resWBox.Location = new System.Drawing.Point(344, 70);
            this.resWBox.Name = "resWBox";
            this.resWBox.Size = new System.Drawing.Size(107, 20);
            this.resWBox.TabIndex = 14;
            this.resWBox.Text = "512";
            this.resWBox.TextChanged += new System.EventHandler(this.resWBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(328, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(12, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "x";
            // 
            // resHBox
            // 
            this.resHBox.Location = new System.Drawing.Point(215, 70);
            this.resHBox.Name = "resHBox";
            this.resHBox.Size = new System.Drawing.Size(107, 20);
            this.resHBox.TabIndex = 7;
            this.resHBox.Text = "512";
            this.resHBox.TextChanged += new System.EventHandler(this.resHBox_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(215, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Resolution";
            // 
            // stepsBox
            // 
            this.stepsBox.Location = new System.Drawing.Point(109, 70);
            this.stepsBox.Name = "stepsBox";
            this.stepsBox.Size = new System.Drawing.Size(100, 20);
            this.stepsBox.TabIndex = 5;
            this.stepsBox.Text = "50";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Steps";
            this.toolTip.SetToolTip(this.label3, "Generation steps. Higher number means better quality, \r\nbut also more processing " +
        "time.\r\n");
            // 
            // seedBox
            // 
            this.seedBox.Location = new System.Drawing.Point(3, 70);
            this.seedBox.Name = "seedBox";
            this.seedBox.Size = new System.Drawing.Size(100, 20);
            this.seedBox.TabIndex = 3;
            this.seedBox.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Seed";
            // 
            // promptBox
            // 
            this.promptBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.promptBox.Location = new System.Drawing.Point(3, 20);
            this.promptBox.Name = "promptBox";
            this.promptBox.Size = new System.Drawing.Size(681, 20);
            this.promptBox.TabIndex = 1;
            this.promptBox.Text = "a teddy bear with a yellow hat";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Prompt";
            // 
            // contextButton
            // 
            this.contextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextButton.Location = new System.Drawing.Point(690, 5);
            this.contextButton.Name = "contextButton";
            this.contextButton.Size = new System.Drawing.Size(129, 35);
            this.contextButton.TabIndex = 30;
            this.contextButton.Text = "Add context image";
            this.toolTip.SetToolTip(this.contextButton, "When you add a context image, then the AI will try to match it as closely as poss" +
        "ible \r\nwhen generating your prompt. Uses img2img algorithm.");
            this.contextButton.UseVisualStyleBackColor = true;
            this.contextButton.Click += new System.EventHandler(this.contextButton_Click);
            // 
            // contextImage
            // 
            this.contextImage.BackColor = System.Drawing.SystemColors.ControlLight;
            this.contextImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.contextImage.Location = new System.Drawing.Point(866, 5);
            this.contextImage.Name = "contextImage";
            this.contextImage.Size = new System.Drawing.Size(35, 35);
            this.contextImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.contextImage.TabIndex = 31;
            this.contextImage.TabStop = false;
            // 
            // contextRemoveButton
            // 
            this.contextRemoveButton.Enabled = false;
            this.contextRemoveButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.contextRemoveButton.Image = global::SDToolkit.Properties.Resources.cross;
            this.contextRemoveButton.Location = new System.Drawing.Point(825, 5);
            this.contextRemoveButton.Name = "contextRemoveButton";
            this.contextRemoveButton.Size = new System.Drawing.Size(35, 35);
            this.contextRemoveButton.TabIndex = 32;
            this.contextRemoveButton.UseVisualStyleBackColor = true;
            this.contextRemoveButton.Click += new System.EventHandler(this.contextRemoveButton_Click);
            // 
            // upscaleCombo
            // 
            this.upscaleCombo.FormattingEnabled = true;
            this.upscaleCombo.Items.AddRange(new object[] {
            "2x",
            "4x",
            "8x"});
            this.upscaleCombo.Location = new System.Drawing.Point(3, 110);
            this.upscaleCombo.Name = "upscaleCombo";
            this.upscaleCombo.Size = new System.Drawing.Size(206, 21);
            this.upscaleCombo.TabIndex = 34;
            this.upscaleCombo.Text = "4x";
            this.toolTip.SetToolTip(this.upscaleCombo, "Upscale the image by an order of magnitude. \r\nFor example: 2x means resolution ti" +
        "mes two.");
            this.upscaleCombo.SelectedIndexChanged += new System.EventHandler(this.upscaleCombo_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Upscale";
            this.toolTip.SetToolTip(this.label6, "Upscale the image by an order of magnitude. \r\nFor example: 2x means resolution ti" +
        "mes two.\r\n");
            // 
            // upscaleLabel
            // 
            this.upscaleLabel.AutoSize = true;
            this.upscaleLabel.Location = new System.Drawing.Point(0, 192);
            this.upscaleLabel.Name = "upscaleLabel";
            this.upscaleLabel.Size = new System.Drawing.Size(41, 13);
            this.upscaleLabel.TabIndex = 35;
            this.upscaleLabel.Text = "<Error>";
            // 
            // precisionCheck
            // 
            this.precisionCheck.AutoSize = true;
            this.precisionCheck.Location = new System.Drawing.Point(3, 160);
            this.precisionCheck.Name = "precisionCheck";
            this.precisionCheck.Size = new System.Drawing.Size(114, 17);
            this.precisionCheck.TabIndex = 36;
            this.precisionCheck.Text = "Force full precision";
            this.toolTip.SetToolTip(this.precisionCheck, "Helpful for generating much better looking faces using GFPGAN 1.3 AI model.\r\n");
            this.precisionCheck.UseVisualStyleBackColor = true;
            // 
            // gpuInfoLabel
            // 
            this.gpuInfoLabel.AutoSize = true;
            this.gpuInfoLabel.Location = new System.Drawing.Point(9, 674);
            this.gpuInfoLabel.Name = "gpuInfoLabel";
            this.gpuInfoLabel.Size = new System.Drawing.Size(92, 13);
            this.gpuInfoLabel.TabIndex = 20;
            this.gpuInfoLabel.Text = "No GPU detected";
            // 
            // timerLabel
            // 
            this.timerLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.timerLabel.Location = new System.Drawing.Point(818, 672);
            this.timerLabel.Name = "timerLabel";
            this.timerLabel.Size = new System.Drawing.Size(100, 15);
            this.timerLabel.TabIndex = 21;
            this.timerLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolTip
            // 
            this.toolTip.ShowAlways = true;
            this.toolTip.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.toolTip.ToolTipTitle = "Help";
            this.toolTip.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // Window
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(930, 761);
            this.Controls.Add(this.timerLabel);
            this.Controls.Add(this.gpuInfoLabel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GenerateButton);
            this.Controls.Add(this.progressBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(946, 800);
            this.MinimumSize = new System.Drawing.Size(946, 800);
            this.Name = "Window";
            this.Text = "SDToolkit";
            this.Load += new System.EventHandler(this.Window_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contextImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar;
        private System.Windows.Forms.Button GenerateButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox promptBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox seedBox;
        private System.Windows.Forms.TextBox stepsBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resHBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox resWBox;
        private System.Windows.Forms.ComboBox samplerCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label gpuInfoLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox debugBox;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.CheckBox useGFPGAN;
        private System.Windows.Forms.Label timerLabel;
        private System.Windows.Forms.Button contextButton;
        private System.Windows.Forms.PictureBox contextImage;
        private System.Windows.Forms.Button contextRemoveButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ComboBox upscaleCombo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label upscaleLabel;
        private System.Windows.Forms.CheckBox precisionCheck;
    }
}

