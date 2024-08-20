using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace stranniy_paint
{
    public partial class Очень_Странный_Пеинт : System.Windows.Forms.Form
    {
        Bitmap bitmap = new Bitmap(442, 470);
        Pen pen = new Pen(Color.White, 5);

        public Очень_Странный_Пеинт()
        {
            InitializeComponent();
            //this.bitmap = new Bitmap (442, 470);
            //this.pen = new Pen(Color.White, 5);
            //INIT_CLASS.bitmap = this.bitmap;
            //INIT_CLASS.pictureBox = Actual_Canvas;
            //INIT_CLASS.pen = this.pen;
            
        }
       

        private void функционалToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("функционал, допиши потом пжпжпжп");
        }

        private void Create_Shape_button_Click(object sender, EventArgs e)
        {
            Check_Radio_button();
        }

        private void Check_Radio_button()
        {
            if (Rectangle_RadioButton.Checked == true)
            {
                Point position = new Point(Convert.ToInt32(x_coordinates.Text), Convert.ToInt32(y_coordinates.Text));
                FM_CLASS fm = new FM_CLASS();
                RECTANGLE_CLASS rectangle = new RECTANGLE_CLASS(position, Convert.ToInt32(Width_input.Text), Convert.ToInt32(Height_input.Text));
                fm.AddFigure(rectangle);
                //rectangle.Name = "Rectangle " + Convert.ToString(FM_CLASS.figures.FindLastIndex(f => f is Rectangle));
                comboBox1.Items.Add(rectangle);
                Actual_Canvas.Image = fm.DrawAllFigures();
            }
            else if (Square_RadioButton.Checked == true) { }
            else if (Ellipse_RadioButton.Checked == true) { }
            else if (Circle_RadioButton.Checked == true) { }
            else if (Triangle_RadioButton.Checked == true) { }
            else if (Polygon_RadioButton.Checked == true) { }
            else if (CustomFigure_RadioButton.Checked == true) { }
        }
        // private void RectangleDraw_Click(object sender, EventArgs e)
        //{
        //    Point position = new Point(Convert.ToInt32(CoordX.Text), Convert.ToInt32(CoordY.Text));
        //    ClassLib.Rectangle rectangle = new ClassLib.Rectangle(position, Convert.ToInt32(Width.Text), Convert.ToInt32(Height.Text));
        //    FM.AddFigure(rectangle);
        //    rectangle.Name = "Rectangle " + Convert.ToString(FM.figures.FindLastIndex(f => f is ClassLib.Rectangle));
        //    listBox1.Items.Add(rectangle.Name);
        //    pictureBox1.Image = FM.DrawAllFigures();
        //}

    }
}
