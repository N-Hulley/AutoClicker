namespace NicksAutoClicker.Forms
{
    partial class Settings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Settings));
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBar1 = new NicksAutoClicker.TitleBar();
            this.transparentPanel1 = new NicksAutoClicker.TransparentPanel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.numAnimationFPS = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.transparentControl3 = new NicksAutoClicker.TransparentControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkEnableAnims = new System.Windows.Forms.CheckBox();
            this.transparentControl2 = new NicksAutoClicker.TransparentControl();
            this.transparentControl1 = new NicksAutoClicker.TransparentControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.transparentPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numAnimationFPS)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 30);
            this.panel1.TabIndex = 8;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.titleBar1.CloseShown = true;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.MaximizeShown = false;
            this.titleBar1.MinimizeShown = false;
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.SettingsButtonShown = false;
            this.titleBar1.Size = new System.Drawing.Size(249, 30);
            this.titleBar1.TabIndex = 6;
            this.titleBar1.Title = "Popup";
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.Black;
            this.transparentPanel1.Controls.Add(this.panel3);
            this.transparentPanel1.Controls.Add(this.transparentControl3);
            this.transparentPanel1.Controls.Add(this.panel2);
            this.transparentPanel1.Controls.Add(this.transparentControl2);
            this.transparentPanel1.Controls.Add(this.transparentControl1);
            this.transparentPanel1.Controls.Add(this.panel4);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 30);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 50;
            this.transparentPanel1.Padding = new System.Windows.Forms.Padding(5);
            this.transparentPanel1.Size = new System.Drawing.Size(249, 346);
            this.transparentPanel1.TabIndex = 7;
            this.transparentPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.transparentPanel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.Controls.Add(this.numAnimationFPS);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(5, 75);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(239, 30);
            this.panel3.TabIndex = 13;
            // 
            // numAnimationFPS
            // 
            this.numAnimationFPS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.numAnimationFPS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numAnimationFPS.Location = new System.Drawing.Point(165, 4);
            this.numAnimationFPS.Maximum = new decimal(new int[] {
            250,
            0,
            0,
            0});
            this.numAnimationFPS.Minimum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAnimationFPS.Name = "numAnimationFPS";
            this.numAnimationFPS.Size = new System.Drawing.Size(67, 20);
            this.numAnimationFPS.TabIndex = 1;
            this.numAnimationFPS.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numAnimationFPS.ValueChanged += new System.EventHandler(this.numAnimationFPS_ValueChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(131, 30);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animation Speed (FPS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transparentControl3
            // 
            this.transparentControl3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentControl3.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentControl3.Location = new System.Drawing.Point(5, 70);
            this.transparentControl3.Name = "transparentControl3";
            this.transparentControl3.Opacity = 50;
            this.transparentControl3.Size = new System.Drawing.Size(239, 5);
            this.transparentControl3.TabIndex = 16;
            this.transparentControl3.Text = "transparentControl3";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.chkEnableAnims);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(5, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(239, 30);
            this.panel2.TabIndex = 12;
            // 
            // chkEnableAnims
            // 
            this.chkEnableAnims.AutoSize = true;
            this.chkEnableAnims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEnableAnims.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkEnableAnims.Location = new System.Drawing.Point(0, 0);
            this.chkEnableAnims.Name = "chkEnableAnims";
            this.chkEnableAnims.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkEnableAnims.Size = new System.Drawing.Size(239, 30);
            this.chkEnableAnims.TabIndex = 0;
            this.chkEnableAnims.Text = "Enable Animations";
            this.chkEnableAnims.UseVisualStyleBackColor = true;
            this.chkEnableAnims.CheckedChanged += new System.EventHandler(this.chkEnableAnims_CheckedChanged_1);
            // 
            // transparentControl2
            // 
            this.transparentControl2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentControl2.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentControl2.Location = new System.Drawing.Point(5, 35);
            this.transparentControl2.Name = "transparentControl2";
            this.transparentControl2.Opacity = 50;
            this.transparentControl2.Size = new System.Drawing.Size(239, 5);
            this.transparentControl2.TabIndex = 15;
            this.transparentControl2.Text = "transparentControl2";
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentControl1.Location = new System.Drawing.Point(0, 0);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 50;
            this.transparentControl1.Size = new System.Drawing.Size(0, 0);
            this.transparentControl1.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(5, 5);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(239, 30);
            this.panel4.TabIndex = 14;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(239, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Glass Background";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(249, 376);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.transparentPanel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numAnimationFPS)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private System.Windows.Forms.Panel panel1;
        private TransparentPanel transparentPanel1;
        private TransparentControl transparentControl1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkEnableAnims;
        private System.Windows.Forms.NumericUpDown numAnimationFPS;
        private TransparentControl transparentControl2;
        private TransparentControl transparentControl3;
    }
}