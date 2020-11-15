using present_t4z1qx.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace present_t4z1qx.Entities
{
    public class Ball : Toy
    {
        protected override void DrawImage (Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color.Blue), 0, 0, Width, Height);
        }

    }
}
