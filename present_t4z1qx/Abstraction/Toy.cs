using System.Drawing;
using System.Windows.Forms;

namespace present_t4z1qx.Abstraction
{
    public abstract class Toy : Label
    {
        public Toy()
        {
            AutoSize = false;
            Width = 50;
            Height = 50;
            Paint += Toy_Paint;
        }

        private void Toy_Paint(object sender, PaintEventArgs e)
        {
            DrawImage(e.Graphics);
        }

        protected abstract void DrawImage(Graphics g);


        public virtual void MoveToy()
        {
            Left += 1;
        }
    }
}
