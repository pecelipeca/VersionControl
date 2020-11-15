using present_t4z1qx.Abstraction;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace present_t4z1qx.Entities
{
    public class PresentFactory : IToyFactory
    {
        public Color ribbon_color { get; set; }
        public Color box_color { get; set; }
        public Toy CreateNew()
        {
            return new Present(ribbon_color, box_color);
        }
    }
}
