using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stranniy_paint
{
    internal class SHAPECONTAINER_CLASS
    {
        public static List<Figure> figureList;
        public SHAPECONTAINER_CLASS()
        {
            figureList = new List<Figure>();
        }
        public static void AddFigure(Figure figure)
        {
           figureList.Add(figure);
        }


}
}
