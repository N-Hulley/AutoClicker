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

namespace NicksAutoClicker
{
    public partial class Popup : Form
    {
        public event EventHandler PopupClosed;
        Form Parent;

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

        public static Popup Show(Form parent, string title)
        {
            Popup popup = new Popup(parent,title);
            return popup;
        }
        public void CancelPopup()
        {
            PopupClosedEventArgs args = new PopupClosedEventArgs();
            args.method = PopupClosedMethod.Canceled;
            FinishEvent(args);
        }
        private void FinishEvent(PopupClosedEventArgs args)
        {
            PopupClosed.Invoke(this, args);
        }
        public Popup(Form parent, string title)
        {
            Parent = parent;
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            titleBar1.Title = title;
            Location = new Point(
                (parent.Location.X + parent.Width / 2) - Width / 2,
                (parent.Location.Y + parent.Height / 2) - Height / 2
            );

            InitializeComponent();

        }


        private void Popup_Load(object sender, EventArgs e)
        {
            (new LayeredWindowHelper(this)).BackColor = Color.FromArgb(200, Color.Black);
            Win7Style.EnableBlurBehindWindow(this.Handle);
            Win10Style.EnableBlur(this.Handle);

        }
    }


    public enum PopupClosedMethod
    {
        Canceled,
        Completed
    };
    public class PopupClosedEventArgs : EventArgs
    {
        public PopupClosedMethod method;
    }
}
