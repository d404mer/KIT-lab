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
        public RECTANGLE_CLASS(int x, int y, int w, int h) // из методички
        {
            this.x = x;
            this.y = y;
            this.width = w;
            this.height = h;
        }

        public RECTANGLE_CLASS() // из методички
        {
            this.x = 0;
            this.y = 0;
            this.width = 0;
            this.height = 0;
        }

        public override void Draw() // из методички
        {
            Graphics g = Graphics.FromImage(INIT_CLASS.bitmap);
            g.DrawRectangle(INIT_CLASS.pen, this.x, this.y, this.width, this.height);
            INIT_CLASS.pictureBox.Image = INIT_CLASS.bitmap;

        }
        //public void DrawRectangle(System.Drawing.Pen pen, int x, int y, int width, int height)
        //{
        //    x = (x_coordinates.Text);
        //    Graphics g = Graphics.FromImage(INIT_CLASS.bitmap);
        //    g.DrawRectangle(INIT_CLASS.pen, this.x, this.y, this.width, this.height);
        //}


        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }
    }
}
