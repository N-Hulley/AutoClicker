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
        public Settings()
        {
            if (!DesignMode)
            { 
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }
            InitializeComponent();

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
        private void Settings_Load(object sender, EventArgs e)
        {
            if (!DesignMode)
            {
                (new LayeredWindowHelper(this)).BackColor = Color.FromArgb(200, Color.Black);
                Win7Style.EnableBlurBehindWindow(this.Handle);
                Win10Style.EnableBlur(this.Handle);
            }

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //UserSettings.InstantAnimation = checkBox1.Checked;
        }
    }
}
