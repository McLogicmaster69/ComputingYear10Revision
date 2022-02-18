using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ComputingYear10Revision
{
    class AnimationManager
    {
        public void Shrink(Control obj, float time)
        {
            Size originalSize = obj.Size;
            for (int i = (int)Math.Floor(time * 1000); i >= 0; i++)
            {
                Thread.Sleep(1);
                obj.Size = new Size((int)Math.Floor(originalSize.Width * i / (float)Math.Floor(time * 1000)), originalSize.Height);
            }
        }
    }
}
