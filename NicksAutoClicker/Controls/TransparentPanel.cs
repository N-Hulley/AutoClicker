using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutoClicker
{
    public partial class TransparentPanel : Panel
    {
        public TransparentPanel()
        {
            if (DesignMode)
            {
                this.BackColor = UserSettings.NonTransparentColor;
            }
            else if (UserSettings.GlassBackground)
            {
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                SetStyle(ControlStyles.Opaque, true);
                this.BackColor = Color.Transparent;
            }
            else
            {
                this.BackColor = UserSettings.NonTransparentColor;
            }
            InitializeComponent();
        }

        public bool drag = false;
        public bool enab = false;
        private int m_opacity = 50;

        private int alpha;

        public int Opacity
        {
            get
            {
                if (m_opacity > 100)
                {
                    m_opacity = 100;
                }
                else if (m_opacity < 1)
                {
                    m_opacity = 1;
                }
                return this.m_opacity;
            }
            set
            {
                this.m_opacity = value;
                if (this.Parent != null)
                {
                    Parent.Invalidate(this.Bounds, true);
                }
            }
        }

    }
}
