using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stranniy_paint
{
    internal class FM_CLASS
    {
        public List<Figure> figures = new List<Figure>();
        public void AddFigure(Figure figure)
        {
            figures.Add(figure);
        }

        public void RemoveFigure(Figure figure)
        {
            figures.Remove(figure);
        }

        public void MoveFigure(Figure figure, int x, int y)
        {
            Point currentPosition = figure.GetPosition();
            int newX = currentPosition.X + x;
            int newY = currentPosition.Y + y;

            // Check if new position is within the boundaries of the Bitmap
            if (newX >= 0 && newX + figure.width <= 460 && newY >= 0 && newY + figure.height <= 460)
            {
                Point newPosition = new Point(newX, newY);
                figure.MoveTo(newPosition);
            }
        }

        public Bitmap DrawAllFigures()
        {
            Bitmap bitmap = new Bitmap(460, 460);
            Graphics graphics = Graphics.FromImage(bitmap);

            foreach (Figure figure in figures)
            {
                figure.Draw(graphics);
            }
            return bitmap;
        }
    }
}
