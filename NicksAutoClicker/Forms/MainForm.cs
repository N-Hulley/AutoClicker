using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtils;

namespace NicksAutoClicker
{
    public partial class MainForm : Form
    {


        const int thinWidth = 270;
        const int wideWidth = 775;



        public Control SideBarControl;

        public MainForm()
        {


            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            AnimationManager.setTimer(animation);

            currentWidth = Width;
            targetWidth = Width;

            ToggleSideBar(true, false);

            if (ClickerManager.Clickers.Count <= 0)
            {
            }

        }
        private void button7_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            openFileDialog1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
        }

        public bool SideBarVisible = false;
        public float currentWidth;
        public float targetWidth;
        Animation ToggleSideBar(bool instant = false, bool? visible = null)
        {

            if (visible != null)
            {
                SideBarVisible = (bool)visible;
            } else
            {
                SideBarVisible = !SideBarVisible;
            }

            if (SideBarVisible)
            {
                targetWidth = wideWidth;
            }
            else
            {
                targetWidth = thinWidth;
            }
            if (WindowState == FormWindowState.Maximized)
            {
                return null;
            }
            Animation slideAnimation = new Animations.SideBarToggle(instant, this);
            AnimationManager.ActiveAnimations.Add(slideAnimation);
            return slideAnimation;

        }

        void slidingAnimationComplete(object sender, EventArgs e)
        {

            if (SideBarIs(typeof(AddClicker)))
            {
                button10.Text = "CANCEL";
                button10.BackColor = Color.IndianRed;
            }
            else
            {
                SideBarControl = null;
                pnlSideBar.Controls.Clear();
                button10.Text = "ADD NEW";
                button10.BackColor = Color.MediumSeaGreen;

            }
            button10.Enabled = true;
            pnlSideBar.ResumeLayout();
            DrawingSuspensions.ResumeDrawing(pnlSideBar);


        }
        void SetSideBar(Control c)
        {
            pnlSideBar.Controls.Clear();
            pnlSideBar.Controls.Add(c);
            SideBarControl = c;
        }
        bool SideBarIs(Type t)
        {
            if (SideBarControl == null) return false;
            return SideBarControl.GetType().Equals(t);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.Style |= Constants.WS_SYSMENU;
                cParms.ExStyle |= Constants.WS_EX_LAYERED;
                return cParms;
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

            (new LayeredWindowHelper(this)).BackColor = Color.FromArgb(200, Color.Black);

            Win7Style.EnableBlurBehindWindow(this.Handle);
            Win10Style.EnableBlur(this.Handle);
        }

        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void pnlSideBar_Paint(object sender, PaintEventArgs e)
        {

        }
        public void OutsiderChangedWidth(object sender, EventArgs e)
        {

        }
        private void button10_Click_1(object sender, EventArgs e)
        {

            button10.Enabled = false;
            if (SideBarIs(typeof(AddClicker)))
            {
                SideBarControl = null;
            }
            else
            {
                AddClicker addclickerPanel = new AddClicker();
                addclickerPanel.Dock = DockStyle.Fill;
                SetSideBar(addclickerPanel);
            }
            Animation slidingAnimation = ToggleSideBar();
            slidingAnimation.AnimationComplete += slidingAnimationComplete;
        }

        private void titleBar1_Load(object sender, EventArgs e)
        {
            titleBar1.btnSettings.Click += OpenSettings;
        }
        public float GetCurrentWidth()
        {
            return currentWidth;
        }
        void OpenSettings(object sender, EventArgs e)
        {
            Forms.Settings settings = new Forms.Settings();
            AnimationManager.PauseAnimations();
            settings.ShowDialog();
            AnimationManager.PauseAnimations();
        }


    }
}
