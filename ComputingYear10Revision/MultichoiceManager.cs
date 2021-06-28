using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputingYear10Revision
{
    class MultichoiceManager
    {
        public MultichoiceManager(Button c1, Button c2, Button c3, Button c4)
        {
            C1 = c1;
            C2 = c2;
            C3 = c3;
            C4 = c4;
        }

        public void SwitchVisible(bool shown)
        {
            C1.Visible = shown;
            C2.Visible = shown;
            C3.Visible = shown;
            C4.Visible = shown;
        }

        public Button C1 { get; }
        public Button C2 { get; }
        public Button C3 { get; }
        public Button C4 { get; }
    }
}
