using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace stranniy_paint
{
    internal class RECTANGLE_CLASS : Figure
    {
        public RECTANGLE_CLASS(Point position, int width, int height) : base(position)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.Black, position.X, position.Y, width, height);
        }

        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
