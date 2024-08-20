public class FigureManager
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
