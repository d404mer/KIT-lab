using ClassLib;
// --------
using System.Configuration;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void ErrorLog_TextChanged(object sender, EventArgs e)
        {

        }

        private FigureManager FM = new FigureManager();

        private void EllipseDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Ellipse ellipse = new Ellipse(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
            FM.AddFigure(ellipse);
            ellipse.Name = "Элипс " + Convert.ToString(FM.figures.FindLastIndex(f => f is Ellipse));
            listBox1.Items.Add(ellipse.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void RoundDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Circle round = new Circle(position, Convert.ToInt32(Width.Text));
            FM.AddFigure(round);
            round.Name = "Круг " + Convert.ToString(FM.figures.FindLastIndex(f => f is Circle));
            listBox1.Items.Add(round.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void RectangleDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            ClassLib.Rectangle rectangle = new ClassLib.Rectangle(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
            FM.AddFigure(rectangle);
            rectangle.Name = "Прямоугольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is ClassLib.Rectangle));
            listBox1.Items.Add(rectangle.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void SquareDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Square square = new Square(position, Convert.ToInt32(Width.Text));
            FM.AddFigure(square);
            square.Name = "Квадрат " + Convert.ToString(FM.figures.FindLastIndex(f => f is Square));
            listBox1.Items.Add(square.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void PolygonDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Polygon polygon = new Polygon(position, Convert.ToInt32(PolygonAmount.Text), Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
            FM.AddFigure(polygon);
            polygon.Name = "Многоугольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is Polygon));
            listBox1.Items.Add(polygon.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void TriangleDraw_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Triangle triangle = new Triangle(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
            FM.AddFigure(triangle);
            triangle.Name = "Тр(е/и)угольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is Triangle)); //чек написание плз
            listBox1.Items.Add(triangle.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void DeleteFigureButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFigureName = listBox1.SelectedItem.ToString();
                listBox1.Items.Remove(selectedFigureName);
                Figure selectedFigure = FM.figures.Find(f => f.Name == selectedFigureName);
                FM.RemoveFigure(selectedFigure);
                pictureBox1.Image = FM.DrawAllFigures();
            }
        }

        private void MoveFigureButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                string selectedFigureName = listBox1.SelectedItem.ToString();
                Figure selectedFigure = FM.figures.Find(f => f.Name == selectedFigureName);
                FM.MoveFigure(selectedFigure, Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                pictureBox1.Image = FM.DrawAllFigures();
            }
        }

        private void DrawSpecial_Click(object sender, EventArgs e)
        {
            Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
            Special special = new Special(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
            FM.AddFigure(special);
            special.Name = "Кастом " + Convert.ToString(FM.figures.FindLastIndex(f => f is Special));
            listBox1.Items.Add(special.Name);
            pictureBox1.Image = FM.DrawAllFigures();
        }

        private void CoordX_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(CoordX.Text, out result) && !(CoordX.Text.StartsWith("-") && int.TryParse(CoordX.Text.Substring(1), out result)) )
            {
                CoordX.Text = "0";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 0");
            }
        }

        private void CoordY_TextChanged_1(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(CoordY.Text, out result) && !(CoordY.Text.StartsWith("-") && int.TryParse(CoordY.Text.Substring(1), out result)))
            {
                CoordY.Text = "0";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 0");
            }
        }

        private void Width_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(Width.Text, out result) && !(Width.Text.StartsWith("-") && int.TryParse(Width.Text.Substring(1), out result)))
            {
                Width.Text = "0";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 0");
            }
        }

        private void Height_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(Height.Text, out result) && !(Height.Text.StartsWith("-") && int.TryParse(Height.Text.Substring(1), out result)))
            {
                Height.Text = "0";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 0");
            }
        }

        private void PolygonAmount_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(PolygonAmount.Text, out result))
            {
                PolygonAmount.Text = "0";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 0");
            }
        }


        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().StartsWith("Круг") && listBox1.SelectedItem != null)
            {
                string selectedFigureName = listBox1.SelectedItem.ToString();
                Figure selectedFigure = FM.figures.Find(f => f.Name == selectedFigureName);
                Circle selectedCircle = selectedFigure as Circle;

                int newRadius = Convert.ToInt32(Width.Text);
                selectedCircle.SetRadius(newRadius);

                pictureBox1.Image = FM.DrawAllFigures();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().StartsWith("Прямоугольник") && listBox1.SelectedItem != null)
            {
                string selectedFigureName = listBox1.SelectedItem.ToString();
                Figure selectedFigure = FM.figures.Find(f => f.Name == selectedFigureName);
                ClassLib.Rectangle selectedRectangle = selectedFigure as ClassLib.Rectangle;

                selectedRectangle.SetSize(Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));

                pictureBox1.Image = FM.DrawAllFigures();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}