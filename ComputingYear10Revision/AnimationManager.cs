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
    static class AnimationManager
    {
        public static void Shrink(Control obj, float time)
        {
            Size originalSize = obj.Size;
            Point originalPosition = obj.Location;
            int startMid = originalPosition.X + originalSize.Width / 2;
            for (int i = (int)(Math.Floor(time * 1000) / 2); i >= 0; i--)
            {
                Thread.Sleep(1);
                obj.Size = new Size((int)(Math.Floor(originalSize.Width * i / (float)(Math.Floor(time * 1000) / 2))), originalSize.Height);
                obj.Location = new Point(startMid - (int)Math.Floor(obj.Size.Width / 2f), originalPosition.Y);
            }
            obj.Visible = false;
            obj.Size = originalSize;
            obj.Location = originalPosition;
        }
        public static void Shrink(Control[] obj, float time)
        {
            List<Size> sizes = new List<Size>();
            foreach(Control c in obj)
            {
                sizes.Add(c.Size);
            }
            for (int i = (int)Math.Floor(time * 1000); i >= 0; i--)
            {
                Thread.Sleep(1);
                for (int j = 0; j < sizes.Count; j++)
                {
                    obj[j].Size = new Size((int)Math.Floor(sizes[j].Width * i / (float)Math.Floor(time * 1000)), sizes[j].Height);
                }
            }
            foreach(Control c in obj)
            {
                c.Visible = false;
            }
        }
    }
}
