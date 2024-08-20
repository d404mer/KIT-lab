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

        private FigureManager FM = new FigureManager();

        private void EllipseDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                Ellipse ellipse = new Ellipse(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
                FM.AddFigure(ellipse);
                ellipse.Name = "Элипс " + Convert.ToString(FM.figures.FindLastIndex(f => f is Ellipse) + 1);
                listBox1.Items.Add(ellipse.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }

        }

        private void RoundDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                Circle round = new Circle(position, Convert.ToInt32(Width.Text));
                FM.AddFigure(round);
                round.Name = "Круг " + Convert.ToString(FM.figures.FindLastIndex(f => f is Circle) + 1);
                listBox1.Items.Add(round.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }
        }

        private void RectangleDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                ClassLib.Rectangle rectangle = new ClassLib.Rectangle(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
                FM.AddFigure(rectangle);
                rectangle.Name = "Прямоугольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is ClassLib.Rectangle) + 1);
                listBox1.Items.Add(rectangle.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }

        }

        private void SquareDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                Square square = new Square(position, Convert.ToInt32(Width.Text));
                FM.AddFigure(square);
                square.Name = "Квадрат " + Convert.ToString(FM.figures.FindLastIndex(f => f is Square) + 1);
                listBox1.Items.Add(square.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }

        }

        private void PolygonDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);
            if (Convert.ToInt32(PolygonAmount.Text) != 0 && (PolygonAmount.Text) != "")
            {
                if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
                {
                    if ((x - w) > 0 && (y - w) > 0)
                    {
                        Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                        Polygon polygon = new Polygon(position, Convert.ToInt32(PolygonAmount.Text), Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
                        FM.AddFigure(polygon);
                        polygon.Name = "Многоугольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is Polygon) + 1);
                        listBox1.Items.Add(polygon.Name);
                        pictureBox1.Image = FM.DrawAllFigures();
                    }
                    else MessageBox.Show("Фигура за пределами поля. Исправьте значения");
                }
                else
                {
                    MessageBox.Show("Фигура за пределами поля. Исправьте значения");
                }
            }

            else { MessageBox.Show("нет. :)"); }

        }

        private void TriangleDraw_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                Triangle triangle = new Triangle(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
                FM.AddFigure(triangle);
                triangle.Name = "Треугольник " + Convert.ToString(FM.figures.FindLastIndex(f => f is Triangle) + 1);
                listBox1.Items.Add(triangle.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }

        }


        private void DrawSpecial_Click(object sender, EventArgs e)
        {
            int x = Convert.ToInt32(CoordX.Text);
            int y = Convert.ToInt32(CoordY.Text);
            int w = Convert.ToInt32(Width.Text);
            int h = Convert.ToInt32(Height.Text);

            if (x >= 0 && x + w <= 468 && y >= 0 && y + w <= 462)
            {
                Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
                Special special = new Special(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
                FM.AddFigure(special);
                special.Name = "Кастом " + Convert.ToString(FM.figures.FindLastIndex(f => f is Special) + 1);
                listBox1.Items.Add(special.Name);
                pictureBox1.Image = FM.DrawAllFigures();
            }
            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }

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
                FM.MoveFigure(selectedFigure, Convert.ToInt32(newCoordX.Text), Convert.ToInt32(new_CoordY.Text));
                pictureBox1.Image = FM.DrawAllFigures();
            }
        }


        private void PolygonAmount_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(PolygonAmount.Text, out result))
            {
                PolygonAmount.Text = "2";
                MessageBox.Show("Неправильный ввод((( Значение сброшено до 2");
            }
        }

        private void NumOnly(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8) // цифры, клавиша BackSpace
            {
                e.Handled = true;
            }
        }

        private void NumOnlyMin(object sender, KeyPressEventArgs e)
        {

            char number = e.KeyChar;
            if (!Char.IsDigit(number) && number != 8 && number != 45) // цифры, клавиша BackSpace и -
            {
                e.Handled = true;
            }
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            CoordX.Text = "0";
            CoordY.Text = "0";
            Width.Text = "0";
            Height.Text = "0";
        }

        private void DeleteAllFigures_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            listBox1.Items.Clear();
            FM.RemoveAll();
        }

        private void Clear_coords_Click(object sender, EventArgs e)
        {
            newCoordX.Text = "0";
            new_CoordY.Text = "0";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            int result;
            if (!int.TryParse(newCoordX.Text, out result) && !(newCoordX.Text.StartsWith("-") && int.TryParse(newCoordX.Text.Substring(1), out result)))
            {
                newCoordX.Text = "0";
            }

            if (!int.TryParse(new_CoordY.Text, out result) && !(new_CoordY.Text.StartsWith("-") && int.TryParse(new_CoordY.Text.Substring(1), out result)))
            {
                new_CoordY.Text = "0";
            }

            if (!int.TryParse(CoordX.Text, out result) && !(CoordX.Text.StartsWith("-") && int.TryParse(CoordX.Text.Substring(1), out result)))
            {
                CoordX.Text = "0";
            }
            
                if (!int.TryParse(CoordY.Text, out result) && !(CoordY.Text.StartsWith("-") && int.TryParse(CoordY.Text.Substring(1), out result)))
            {
                CoordY.Text = "0";
            }
            if (!int.TryParse(Width.Text, out result) && !(Width.Text.StartsWith("-") && int.TryParse(Width.Text.Substring(1), out result)))
            {
                Width.Text = "0";
            }
            if (!int.TryParse(Height.Text, out result) && !(Height.Text.StartsWith("-") && int.TryParse(Height.Text.Substring(1), out result)))
            {
                Height.Text = "0";
            }
        }
    }
}