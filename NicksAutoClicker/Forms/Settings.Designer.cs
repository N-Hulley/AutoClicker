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
            this.panel1 = new System.Windows.Forms.Panel();
            this.titleBar1 = new NicksAutoClicker.TitleBar();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chkEnableAnims = new System.Windows.Forms.CheckBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.transparentPanel1 = new NicksAutoClicker.TransparentPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.transparentControl1 = new NicksAutoClicker.TransparentControl();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.transparentPanel1.SuspendLayout();
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.Controls.Add(this.chkEnableAnims);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel2.Location = new System.Drawing.Point(8, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(233, 30);
            this.panel2.TabIndex = 8;
            // 
            // chkEnableAnims
            // 
            this.chkEnableAnims.AutoSize = true;
            this.chkEnableAnims.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chkEnableAnims.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.chkEnableAnims.Location = new System.Drawing.Point(0, 0);
            this.chkEnableAnims.Name = "chkEnableAnims";
            this.chkEnableAnims.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.chkEnableAnims.Size = new System.Drawing.Size(233, 30);
            this.chkEnableAnims.TabIndex = 0;
            this.chkEnableAnims.Text = "Enable Animations";
            this.chkEnableAnims.UseVisualStyleBackColor = true;
            this.chkEnableAnims.CheckedChanged += new System.EventHandler(this.chkEnableAnims_CheckedChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel3.Controls.Add(this.trackBar1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(8, 38);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(233, 44);
            this.panel3.TabIndex = 9;
            // 
            // trackBar1
            // 
            this.trackBar1.BackColor = System.Drawing.SystemColors.Control;
            this.trackBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trackBar1.LargeChange = 20;
            this.trackBar1.Location = new System.Drawing.Point(131, 0);
            this.trackBar1.Maximum = 240;
            this.trackBar1.Minimum = 10;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(102, 44);
            this.trackBar1.SmallChange = 2;
            this.trackBar1.TabIndex = 1;
            this.trackBar1.TickFrequency = 20;
            this.trackBar1.Value = 60;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.label1.Size = new System.Drawing.Size(131, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animation Speed (FPS)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentPanel1.Controls.Add(this.transparentControl1);
            this.transparentPanel1.Controls.Add(this.panel4);
            this.transparentPanel1.Controls.Add(this.panel3);
            this.transparentPanel1.Controls.Add(this.panel2);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 30);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 50;
            this.transparentPanel1.Padding = new System.Windows.Forms.Padding(8);
            this.transparentPanel1.Size = new System.Drawing.Size(249, 346);
            this.transparentPanel1.TabIndex = 7;
            this.transparentPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.transparentPanel1_Paint);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Control;
            this.panel4.Controls.Add(this.checkBox1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.panel4.Location = new System.Drawing.Point(8, 82);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(233, 30);
            this.panel4.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBox1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.checkBox1.Location = new System.Drawing.Point(0, 0);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.checkBox1.Size = new System.Drawing.Size(233, 30);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Text = "Glass Background";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentControl1.Location = new System.Drawing.Point(8, 112);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 50;
            this.transparentControl1.Size = new System.Drawing.Size(233, 5);
            this.transparentControl1.TabIndex = 11;
            this.transparentControl1.Text = "transparentControl1";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(249, 376);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.Load += new System.EventHandler(this.Settings_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.transparentPanel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox chkEnableAnims;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label label1;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.CheckBox checkBox1;
        private TransparentControl transparentControl1;
    }
}