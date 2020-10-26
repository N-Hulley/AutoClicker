using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NicksAutoClicker
{
    public static class DrawingSuspensions
    {

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);

        private const int WM_SETREDRAW = 11;

        public static void SuspendDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, false, 0);
        }

        public static void ResumeDrawing(Control parent)
        {
            SendMessage(parent.Handle, WM_SETREDRAW, true, 0);
            parent.Refresh();
        }
    }
    public static class Utils
    {
        public static float Lerp(float v1, float v2, float t)
        {
            return v1 + ((v2 - v1) * t);
        }


    }
    namespace EventListArgs
    {
        public class ItemAdded<T> : EventArgs
        {
            public T Item { get; set; }

            public ItemAdded(T item)
            {
                Item = item;
            }
        }
    }
    public class EventList<T> : List<T> 
    {
        public event EventHandler onAdd; 
        public new void Add(T item)
        {
            base.Add(item);
            EventListArgs.ItemAdded<T> args = new EventListArgs.ItemAdded<T>(item);
            onAdd.Invoke(this, args);

        }
    }
}
