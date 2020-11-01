namespace NicksAutoClicker
{
    partial class Popup
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Popup));
            this.transparentPanel2 = new NicksAutoClicker.TransparentPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.transparentPanel1 = new NicksAutoClicker.TransparentPanel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.transparentControl1 = new NicksAutoClicker.TransparentControl();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.titleBar1 = new NicksAutoClicker.TitleBar();
            this.transparentPanel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.transparentPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // transparentPanel2
            // 
            this.transparentPanel2.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel2.Controls.Add(this.panel1);
            this.transparentPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.transparentPanel2.Location = new System.Drawing.Point(0, 30);
            this.transparentPanel2.Name = "transparentPanel2";
            this.transparentPanel2.Opacity = 50;
            this.transparentPanel2.Padding = new System.Windows.Forms.Padding(10, 10, 10, 5);
            this.transparentPanel2.Size = new System.Drawing.Size(300, 86);
            this.transparentPanel2.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(39)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(10, 10);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 71);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.MaximumSize = new System.Drawing.Size(270, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(269, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1label1label1label1label1label1label1label1label1label1label1label1label1lab" +
    "el1label1label1label1label1label1label1label1label1label1";
            // 
            // transparentPanel1
            // 
            this.transparentPanel1.BackColor = System.Drawing.Color.Transparent;
            this.transparentPanel1.Controls.Add(this.btnCancel);
            this.transparentPanel1.Controls.Add(this.transparentControl1);
            this.transparentPanel1.Controls.Add(this.btnConfirm);
            this.transparentPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.transparentPanel1.Location = new System.Drawing.Point(0, 116);
            this.transparentPanel1.Name = "transparentPanel1";
            this.transparentPanel1.Opacity = 50;
            this.transparentPanel1.Padding = new System.Windows.Forms.Padding(10, 5, 10, 10);
            this.transparentPanel1.Size = new System.Drawing.Size(300, 42);
            this.transparentPanel1.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnCancel.BackColor = System.Drawing.Color.IndianRed;
            this.btnCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancel.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCancel.Location = new System.Drawing.Point(75, 5);
            this.btnCancel.MinimumSize = new System.Drawing.Size(105, 0);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnCancel.Size = new System.Drawing.Size(105, 27);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // transparentControl1
            // 
            this.transparentControl1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(19)))), ((int)(((byte)(19)))));
            this.transparentControl1.Dock = System.Windows.Forms.DockStyle.Right;
            this.transparentControl1.Location = new System.Drawing.Point(180, 5);
            this.transparentControl1.Name = "transparentControl1";
            this.transparentControl1.Opacity = 50;
            this.transparentControl1.Size = new System.Drawing.Size(5, 27);
            this.transparentControl1.TabIndex = 24;
            this.transparentControl1.Text = "transparentControl1";
            // 
            // btnConfirm
            // 
            this.btnConfirm.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnConfirm.BackColor = System.Drawing.Color.Green;
            this.btnConfirm.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirm.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConfirm.FlatAppearance.BorderSize = 0;
            this.btnConfirm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfirm.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.SystemColors.Control;
            this.btnConfirm.Location = new System.Drawing.Point(185, 5);
            this.btnConfirm.MinimumSize = new System.Drawing.Size(105, 0);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.btnConfirm.Size = new System.Drawing.Size(105, 27);
            this.btnConfirm.TabIndex = 23;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
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
            this.titleBar1.Size = new System.Drawing.Size(300, 30);
            this.titleBar1.TabIndex = 5;
            this.titleBar1.Title = "Popup";
            // 
            // Popup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(300, 158);
            this.Controls.Add(this.transparentPanel2);
            this.Controls.Add(this.transparentPanel1);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Popup";
            this.Text = "Popup";
            this.Load += new System.EventHandler(this.Popup_Load);
            this.transparentPanel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.transparentPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TitleBar titleBar1;
        private TransparentPanel transparentPanel1;
        private System.Windows.Forms.Button btnCancel;
        private TransparentControl transparentControl1;
        private System.Windows.Forms.Button btnConfirm;
        private TransparentPanel transparentPanel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}