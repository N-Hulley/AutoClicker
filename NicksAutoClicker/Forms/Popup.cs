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
        MainForm Main;
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

        public static Popup Show(MainForm main, string title)
        {
            Popup popup = new Popup(main);
            popup.titleBar1.Title = title;
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
        public Popup(MainForm main)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);

            InitializeComponent();
            Main = main;
            Utils.CenterForm(main, this);

        }


        private void Popup_Load(object sender, EventArgs e)
        {
            Utils.ApplyLayeredWindowHelp(this, DesignMode);

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
