using System.Configuration;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace App
{
    public partial class Form1 : Form
    {




        public Form1()
        {
            InitializeComponent();



        }

        private FigureManager FM = new FigureManager(); // drawing object

        //Создание эллипса: name!h!w!x!y!E                      alt + arrows
        //Перемещение эллипса: dy!dx!name!M
        //Удаление эллипса: name!D

        // pop - in, push - out 




        private void CalculateRPN(string input)
        {

            try
            {
                Stack<string> op_stack = new(); // operands stack
                string help_string = "";
                foreach (var item in input)
                {
                    if (item != '!' && item != 'E' && item != 'M' && item != 'D' && item != 'd')
                    {
                        help_string += item;
                    }

                    else if (item == 'd')
                    {

                    }
                    else if (item == '!')
                    {
                        op_stack.Push(help_string);
                        help_string = "";
                    }
                    else if (item == 'E')
                    {
                        if (op_stack.Count != 5) { listBox1.Items.Add($"{input} - Неккор ввод"); }
                        create_E(op_stack);
                    }

                    else if (item == 'M')
                    {

                        move_M(op_stack);
                    }

                    else if (item == 'D')
                    {
                        if (op_stack.Count != 1) listBox1.Items.Add($"{input} - Ошибка");
                        delete_D(op_stack);
                    }

                    var x = op_stack;
                }

            }
            catch { listBox1.Items.Add($"{input} - Не работает"); }
        }

        private void create_E(Stack<string> stack)
        {
            //Создание эллипса: name!h!w!x!y!E      y,x,w,h,n
            int y = Convert.ToInt32(stack.Pop());
            int x = Convert.ToInt32(stack.Pop());
            int width = Convert.ToInt32(stack.Pop());
            int height = Convert.ToInt32(stack.Pop());
            string name = Convert.ToString(stack.Pop());

            if (x >= 0 && x + width <= 468 && y >= 0 && y + height <= 462)
            {
                Point position = new Point(x, y);
                Ellipse ellipse = new Ellipse(position, width, height);
                FM.AddFigure(ellipse);
                ellipse.Name = name;
                listBox1.Items.Add($"{input.Text} - Успешно");
                pictureBox1.Image = FM.DrawAllFigures();

            }

            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }
        }



        private void move_M(Stack<string> stack)
        {
            //Перемещение эллипса: dy!dx!name!M 

            try
            {
                if (stack.Count != 3) { listBox1.Items.Add($"{input.Text} - некор"); }

                //MessageBox.Show("всё норм");
                string name = Convert.ToString(stack.Pop());
                int x = Convert.ToInt32(stack.Pop());
                int y = Convert.ToInt32(stack.Pop());


                Figure selectedFigure = FM.figures.Find(f => f.Name == name);
                if ( selectedFigure == null)
                { listBox1.Items.Add($"{input.Text} - не выполнено");
                    return;
                }
                FM.MoveFigure(selectedFigure, x, y);
                pictureBox1.Image = FM.DrawAllFigures();
                listBox1.Items.Add($"{input.Text} - Успешно");
            }
            catch { listBox1.Items.Add($"{input.Text} - не выполнено"); }
        }

        private void delete_D(Stack<string> stack)
        {
            //Удаление эллипса: name!D

            string name = Convert.ToString(stack.Pop());


            Figure selectedFigure = FM.figures.Find(f => f.Name == name);
            if (selectedFigure == null)
            {
                listBox1.Items.Add($"{input.Text} - не выполнено");
                return;
            }
            FM.RemoveFigure(selectedFigure);
            pictureBox1.Image = FM.DrawAllFigures();
            listBox1.Items.Remove(name);
            listBox1.Items.Add($"{input.Text} - Успешно");
        }





        private void deletebtn_Click(object sender, EventArgs e)
        {
            input.Text = "";
        }

        private void Etest_Click(object sender, EventArgs e)
        {
            input.Text = "test!20!20!150!150!E";
        }

        private void Mtest_Click(object sender, EventArgs e)
        {
            input.Text = "d10!d10!test!M";
        }

        private void Dtest_Click(object sender, EventArgs e)
        {
            input.Text = "test!D";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            CalculateRPN(input.Text);
        }


        private void input_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter && input.Text != null)
                {
                    CalculateRPN(input.Text);
                    e.Handled = true;
                }
            }
            catch { listBox1.Items.Add($"{input.Text} - неизвестная команда"); }
        }
    }
}