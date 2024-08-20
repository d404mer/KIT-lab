using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stranniy_paint
{
    abstract public class Figures()
    {
        public int x;
        public int y;
        public int width;
        public int height;
        abstract public void Draw();
        abstract public void MoveTo(int x, int y);

    }
}
