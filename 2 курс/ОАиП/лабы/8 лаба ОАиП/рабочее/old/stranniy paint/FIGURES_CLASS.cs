using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace stranniy_paint
{
    abstract public class Figure //() check ??????????????????? primary constructors 12.0 
    {
        public FM_CLASS FM = new FM_CLASS();
        protected Point position;
        public int width, height;
        public string name;

        public Figure(Point position)
        {
            if (position.X < 0 || position.X + width > 460 || position.Y < 0 || position.Y + height > 460)
            {
                position.X = 230;
                position.Y = 230;
            }
            this.position = position;
        }

        public void SetPosition(Point position)
        {
            this.position = position;
        }

        public Point GetPosition()
        {
            return position;
        }
        abstract public void Draw(Graphics g);
        public virtual void MoveTo(Point position)
        {
            this.position = position;
        }

    }
}
