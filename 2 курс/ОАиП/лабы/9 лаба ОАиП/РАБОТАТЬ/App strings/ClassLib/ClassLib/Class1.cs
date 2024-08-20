using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.CompilerServices;

namespace ClassLib
{
    public class FigureManager
    {
        public List<Figure> figures = new List<Figure>();



        public void RemoveAll()
        {
            figures.Clear();
        }
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

    public abstract class Figure
    {
        public FigureManager FM = new FigureManager();
        public int width, height;
        protected Point position;
        public string Name;

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

        public virtual void Draw(Graphics g)
        {

        }

        public virtual void MoveTo(Point position)
        {
            this.position = position;
        }
    }

    public class Ellipse : Figure
    {

        public Ellipse(Point position, int width, int height) : base(position)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.White, position.X, position.Y, width, height);
        }
    }

    public class Rectangle : Figure
    {

        public Rectangle(Point position, int width, int height) : base(position)
        {
            this.width = width;
            this.height = height;
        }

        public override void Draw(Graphics g)
        {
            g.DrawRectangle(Pens.White, position.X, position.Y, width, height);
        }

        public void SetSize(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

    }

    public class Circle : Ellipse
    {
        public Circle(Point position, int radius) : base(position, radius, radius)
        {
        }

        public int GetRadius()
        {
            return width / 2;
        }

        public void SetRadius(int radius)
        {
            width = height = radius;
        }

        public override void Draw(Graphics g)
        {
            g.DrawEllipse(Pens.White, position.X, position.Y, width, height);
        }
    }

    public class Square : Rectangle
    {
        public Square(Point position, int size) : base(position, size, size)
        {
        }

        public int GetSize()
        {
            return width;
        }

        public void SetSize(int size)
        {
            width = height = size;
        }

    }

    public class Polygon : Figure
    {
        private int numOfVertices;
        private Point[] vertices;

        public Polygon(Point position, int numOfVertices, int width, int height) : base(position)
        {
            this.numOfVertices = numOfVertices;
            this.width = width;
            this.height = height;
            GenerateVertices();
        }

        private void GenerateVertices()
        {
            vertices = new Point[numOfVertices];
            for (int i = 0; i < numOfVertices; i++)
            {
                int x = position.X + (int)(width * Math.Cos(2 * Math.PI * i / numOfVertices));
                int y = position.Y + (int)(height * Math.Sin(2 * Math.PI * i / numOfVertices));
                vertices[i] = new Point(x, y);
            }
        }

        public override void Draw(Graphics g)
        {
            
            g.DrawPolygon(Pens.White, vertices);
        }
        
        public override void MoveTo(Point position)
        {
            if ((position.X - width > 0 && (position.Y - height) > 0) && (position.X < 462) && (position.Y < 468))
            {
                this.position = position;
                GenerateVertices();
            }
        }
    }

    public class Triangle : Polygon
    {
        public Triangle(Point position, int width, int height) : base(position, 3, width, height)
        {
        }
    }

    public class Special : Figure
    {
        public Special(Point position, int width, int height) : base(position)
        {

            this.width = width;
            this.height = height;
        }

        public int X
        {
            get { return position.X; }
            set { position.X = value; }
        }

        public int Y
        {
            get { return position.Y; }
            set { position.Y = value; }
        }

        public override void Draw(Graphics g)
        {
            int width = this.width;
            int height = Convert.ToInt32(this.height);

            // Большой круг (круг)
            g.DrawEllipse(Pens.White, position.X, position.Y, width, height);


            // Чёлочка (треугольник)
            Point[] bangs =

            {
                new Point(position.X + (width / 6), position.Y + (height / 7) ), // left top  // ALT+ARROWS <-- крутой шорткат // Y НОРМ НЕ МЕНЯЙ 
                new Point(Convert.ToInt32(position.X + (width * 0.85)),  position.Y + (height / 7) ), // right top  Y НОРМ НЕ МЕНЯЙ 
                new Point(position.X + (width / 6), Convert.ToInt32( (position.Y +(height) * 0.92))) // left bottom  ЧЕЛ ХАРОШ
            };
            g.DrawPolygon(Pens.White, bangs);

            // Глаз (круг)
            g.DrawEllipse(Pens.White, Convert.ToInt32( (position.X + (width * 0.67)) ), Convert.ToInt32 ( (position.Y + ( height / 2) * 0.98) ), width/5, height/5);

            // Рот (прямоугольник)
            g.DrawRectangle(Pens.White, Convert.ToInt32( position.X + (width / 2.9) ) , Convert.ToInt32( position.Y + (height * 0.78) ), Convert.ToInt32 ( (width / 2) * 0.8), height / 11);

        }
    }
}
