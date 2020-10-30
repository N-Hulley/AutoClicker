using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinUtils;

namespace NicksAutoClicker.Forms
{
    public partial class Settings : Form
    {
        MainForm Main;
        public Settings(MainForm main)
        {
            if (!DesignMode)
            { 
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
            InitializeComponent();
            Main = main;
            Utils.CenterForm(main, this);
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cParms = base.CreateParams;
                cParms.Style |= Constants.WS_SYSMENU;
                cParms.ExStyle |= Constants.WS_EX_LAYERED;
                return DesignMode ? null : cParms;
            }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            Utils.ApplyLayeredWindowHelp(this, DesignMode);
            chkEnableAnims.Checked = !UserSettings.InstantAnimation;
            numAnimationFPS.Value = (int)(1000f / UserSettings.AnimationInterval);
            checkBox1.Checked = UserSettings.GlassBackground;
        }

        private void chkEnableAnims_CheckedChanged(object sender, EventArgs e)
        {

        }


        private void numAnimationFPS_ValueChanged(object sender, EventArgs e)
        {
            UserSettings.AnimationInterval = 1000 / (int)numAnimationFPS.Value;
        }

        private void chkEnableAnims_CheckedChanged_1(object sender, EventArgs e)
        {
            UserSettings.InstantAnimation = !chkEnableAnims.Checked;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            UserSettings.GlassBackground = checkBox1.Checked;
        }

        private void transparentPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
