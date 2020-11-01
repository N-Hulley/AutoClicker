namespace NicksAutoClicker
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pnlSideBar = new NicksAutoClicker.TransparentPanel();
            this.transparentPanel3 = new NicksAutoClicker.TransparentPanel();
            this.transparentPanel2 = new NicksAutoClicker.TransparentPanel();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.transparentPanel1 = new NicksAutoClicker.TransparentPanel();
            this.button6 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.titleBar1 = new NicksAutoClicker.TitleBar();
            this.transparentPanel3.SuspendLayout();
            this.transparentPanel2.SuspendLayout();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "clickerExport";
            this.openFileDialog1.Title = "Choose your clicker configurations file";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(249, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.BackColor = System.Drawing.Color.Transparent;
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSideBar.Location = new System.Drawing.Point(270, 31);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(500, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Opacity = 100;
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(0, 5, 5, 0);
            this.pnlSideBar.Size = new System.Drawing.Size(530, 429);
            this.pnlSideBar.TabIndex = 9;
            // 
            // transparentPanel3
            // 
            this.transparentPanel3.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel3.Controls.Add(this.transparentPanel2);
            this.transparentPanel3.Controls.Add(this.transparentPanel1);
            this.transparentPanel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.transparentPanel3.Location = new System.Drawing.Point(0, 31);
            this.transparentPanel3.Name = "transparentPanel3";
            this.transparentPanel3.Opacity = 50;
            this.transparentPanel3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 5);
            this.transparentPanel3.Size = new System.Drawing.Size(270, 429);
            this.transparentPanel3.TabIndex = 8;
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel2.Controls.Add(this.listBox2);
            this.transparentPanel2.Controls.Add(this.button10);
            this.transparentPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel2.Location = new System.Drawing.Point(0, 48);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Opacity = 50;
            this.transparentPanel2.Padding = new System.Windows.Forms.Padding(5);
            this.transparentPanel2.Size = new System.Drawing.Size(270, 229);
            this.transparentPanel2.TabIndex = 7;
            // 
            // listBox2
            // 
            this.listBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBox2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox2.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.listBox2.FormattingEnabled = true;
            this.listBox2.ItemHeight = 16;
            this.listBox2.Location = new System.Drawing.Point(5, 5);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(260, 186);
            this.listBox2.TabIndex = 14;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(5, 191);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(260, 33);
            this.button10.TabIndex = 15;
            this.button10.Text = "ADD NEW";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel1.Controls.Add(this.button6);
            this.transparentPanel1.Controls.Add(this.button9);
            this.transparentPanel1.Controls.Add(this.button8);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 0);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 50;
            this.transparentPanel1.Padding = new System.Windows.Forms.Padding(5, 5, 5, 0);
            this.transparentPanel1.Size = new System.Drawing.Size(270, 48);
            this.transparentPanel1.TabIndex = 6;
            // 
            // button6
            // 
            this.button6.AutoSize = true;
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(210, 5);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(55, 43);
            this.button6.TabIndex = 15;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSize = true;
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(66, 5);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(48, 43);
            this.button9.TabIndex = 14;
            this.button9.Text = "LOAD";
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.AutoSize = true;
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(5, 5);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(61, 43);
            this.button8.TabIndex = 13;
            this.button8.Text = "EXPORT";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.titleBar1.CloseShown = true;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.MaximizeShown = true;
            this.titleBar1.MinimizeShown = true;
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.SettingsButtonShown = true;
            this.titleBar1.Size = new System.Drawing.Size(800, 31);
            this.titleBar1.TabIndex = 1;
            this.titleBar1.Title = "Nicks AutoClicker";
            this.titleBar1.Load += new System.EventHandler(this.titleBar1_Load);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.pnlSideBar);
            this.Controls.Add(this.transparentPanel3);
            this.Controls.Add(this.titleBar1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "Nicks Auto Clicker";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.transparentPanel3.ResumeLayout(false);
            this.transparentPanel2.ResumeLayout(false);
            this.transparentPanel1.ResumeLayout(false);
            this.transparentPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Panel panel1;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private TransparentPanel transparentPanel2;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button10;
        private TransparentPanel transparentPanel3;
        private TransparentPanel pnlSideBar;
        public TitleBar titleBar1;
    }
}

