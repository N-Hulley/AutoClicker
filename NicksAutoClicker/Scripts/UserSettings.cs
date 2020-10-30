using System;
using System.Collections.Generic;
using System.Drawing;
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

        public static int AnimationInterval
        {
            get { return NicksAutoClicker.Properties.Settings.Default.AnimationInterval; }
            set { NicksAutoClicker.Properties.Settings.Default.AnimationInterval = value; }
        }
        public static bool GlassBackground
        {
            get { return NicksAutoClicker.Properties.Settings.Default.GlassBackground; }
            set { NicksAutoClicker.Properties.Settings.Default.GlassBackground = value; }
        }
        private static Color defaultNonTransparentColor = Color.FromArgb(19, 19, 19); 
        public static Color NonTransparentColor
        {
            get { return defaultNonTransparentColor; }
            set { defaultNonTransparentColor = value; }
        }
    }
}
