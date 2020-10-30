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
using static NicksAutoClicker.Utils;

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

        public static Popup Show(MainForm main, string title, string text)
        {
            Popup popup = new Popup(main);
            popup.titleBar1.Title = title;
            popup.label1.Text = text;
            return popup;
        }
        public void CancelPopup(object sender = null, EventArgs e = null)
        {
            PopupClosedEventArgs args = new PopupClosedEventArgs();
            args.method = PopupClosedMethod.Canceled;
            FinishEvent(args);
        }
        private void FinishEvent(PopupClosedEventArgs args)
        {
            if (PopupClosed != null)PopupClosed.Invoke(this, args);
            Close();

        }
        public Popup(MainForm main)
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            InitializeComponent();
            Main = main;
            titleBar1.btnClose.Click += CancelPopup;

        }


        private void Popup_Load(object sender, EventArgs e)
        {
            Utils.ApplyLayeredWindowHelp(this, DesignMode);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            PopupClosedEventArgs args = new PopupClosedEventArgs();
            args.method = PopupClosedMethod.Completed;
            FinishEvent(args);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelPopup();
        }
    }


}
