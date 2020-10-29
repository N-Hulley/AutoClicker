using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker
{
    public static class UserSettings
    {
        public static bool InstantAnimation
        {
            get { return NicksAutoClicker.Properties.Settings.Default.InstantAnimations; }
            set { NicksAutoClicker.Properties.Settings.Default.InstantAnimations = value; }
        }
    }
}
