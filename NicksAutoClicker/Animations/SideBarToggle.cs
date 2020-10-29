using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NicksAutoClicker.Animations
{
    class SideBarToggle : UniqueAnimation
    {
        MainForm Form;
        public SideBarToggle(bool instantCompletion, MainForm form) : base(instantCompletion)
        {
            this.Form = form;
        }

        public override void InstantComplete()
        {
            Form.currentWidth = Form.targetWidth;
        }

        protected override bool CheckCompleted()
        {
            return Math.Round(Form.currentWidth) == Math.Round(Form.targetWidth);
        }

        protected override void Update()
        {
            Form.PerformSafely(()=>Form.Width = 
                (int)Utils.Lerp(Form.currentWidth, Form.targetWidth,
                (1f / (float).17) * 3)
                );
        }
    }
}
