using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker
{
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
