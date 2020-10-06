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
            this.components = new System.ComponentModel.Container();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.titleBar1 = new NicksAutoClicker.TitleBar();
            this.pnlSideBar = new System.Windows.Forms.Panel();
            this.pnlClickerConfig = new System.Windows.Forms.Panel();
            this.splitContainer8 = new System.Windows.Forms.SplitContainer();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.button10 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.animation = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.pnlClickerConfig.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).BeginInit();
            this.splitContainer8.Panel1.SuspendLayout();
            this.splitContainer8.Panel2.SuspendLayout();
            this.splitContainer8.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.titleBar1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.pnlSideBar);
            this.splitContainer1.Panel2.Controls.Add(this.pnlClickerConfig);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(10);
            this.splitContainer1.Size = new System.Drawing.Size(800, 460);
            this.splitContainer1.SplitterDistance = 31;
            this.splitContainer1.TabIndex = 0;
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.Black;
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(800, 31);
            this.titleBar1.TabIndex = 0;
            // 
            // pnlSideBar
            // 
            this.pnlSideBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlSideBar.Location = new System.Drawing.Point(290, 10);
            this.pnlSideBar.MinimumSize = new System.Drawing.Size(500, 0);
            this.pnlSideBar.Name = "pnlSideBar";
            this.pnlSideBar.Padding = new System.Windows.Forms.Padding(5);
            this.pnlSideBar.Size = new System.Drawing.Size(500, 405);
            this.pnlSideBar.TabIndex = 2;
            // 
            // pnlClickerConfig
            // 
            this.pnlClickerConfig.Controls.Add(this.splitContainer8);
            this.pnlClickerConfig.Controls.Add(this.label4);
            this.pnlClickerConfig.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlClickerConfig.Location = new System.Drawing.Point(10, 10);
            this.pnlClickerConfig.Name = "pnlClickerConfig";
            this.pnlClickerConfig.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.pnlClickerConfig.Size = new System.Drawing.Size(280, 405);
            this.pnlClickerConfig.TabIndex = 3;
            // 
            // splitContainer8
            // 
            this.splitContainer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer8.Location = new System.Drawing.Point(0, 0);
            this.splitContainer8.Name = "splitContainer8";
            this.splitContainer8.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer8.Panel1
            // 
            this.splitContainer8.Panel1.Controls.Add(this.button6);
            this.splitContainer8.Panel1.Controls.Add(this.button8);
            this.splitContainer8.Panel1.Controls.Add(this.button9);
            // 
            // splitContainer8.Panel2
            // 
            this.splitContainer8.Panel2.Controls.Add(this.listBox2);
            this.splitContainer8.Panel2.Controls.Add(this.button10);
            this.splitContainer8.Size = new System.Drawing.Size(270, 263);
            this.splitContainer8.SplitterDistance = 25;
            this.splitContainer8.TabIndex = 14;
            // 
            // button6
            // 
            this.button6.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button6.BackColor = System.Drawing.Color.Crimson;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.Location = new System.Drawing.Point(199, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(71, 25);
            this.button6.TabIndex = 12;
            this.button6.Text = "CLEAR";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // button8
            // 
            this.button8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button8.BackColor = System.Drawing.Color.DarkCyan;
            this.button8.Dock = System.Windows.Forms.DockStyle.Left;
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button8.Location = new System.Drawing.Point(71, 0);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(67, 25);
            this.button8.TabIndex = 10;
            this.button8.Text = "EXPORT";
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button9.BackColor = System.Drawing.Color.DodgerBlue;
            this.button9.Dock = System.Windows.Forms.DockStyle.Left;
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button9.Location = new System.Drawing.Point(0, 0);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(71, 25);
            this.button9.TabIndex = 11;
            this.button9.Text = "LOAD";
            this.button9.UseVisualStyleBackColor = false;
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
            this.listBox2.Location = new System.Drawing.Point(0, 0);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(270, 200);
            this.listBox2.TabIndex = 10;
            // 
            // button10
            // 
            this.button10.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.button10.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.button10.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button10.FlatAppearance.BorderSize = 0;
            this.button10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button10.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button10.Location = new System.Drawing.Point(0, 200);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(270, 34);
            this.button10.TabIndex = 13;
            this.button10.Text = "ADD NEW";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // label4
            // 
            this.label4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label4.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.label4.Location = new System.Drawing.Point(0, 263);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(270, 142);
            this.label4.TabIndex = 15;
            this.label4.Text = "Active Clicker";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "clickerExport";
            this.openFileDialog1.Title = "Choose your clicker configurations file";
            // 
            // animation
            // 
            this.animation.Interval = 17;
            this.animation.Tick += new System.EventHandler(this.animation_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.splitContainer1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "Nicks Auto Clicker";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.pnlClickerConfig.ResumeLayout(false);
            this.splitContainer8.Panel1.ResumeLayout(false);
            this.splitContainer8.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer8)).EndInit();
            this.splitContainer8.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private TitleBar titleBar1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Timer animation;
        private System.Windows.Forms.Panel pnlSideBar;
        private System.Windows.Forms.Panel pnlClickerConfig;
        private System.Windows.Forms.SplitContainer splitContainer8;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Label label4;
    }
}

