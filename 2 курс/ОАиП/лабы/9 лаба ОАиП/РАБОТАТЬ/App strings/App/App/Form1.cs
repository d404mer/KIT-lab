using System.Configuration;
using System.DirectoryServices;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.ConstrainedExecution;
using System.Windows.Forms;
using System.Xml.Linq;
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


        private int x, y, width, height;
        private string name;


        //Создание эллипса: name!h!w!x!y!E                      alt + arrows
        //Перемещение эллипса: dy!dx!name!M
        //Удаление эллипса: name!D

        // pop - in, push - out 


        private void CalculateRPN(string input)
        {

            Stack<string> op_stack = new(); // operands stack
            string[] help_string = input.Split('!');
            try {
                foreach (string c in help_string)
                {
                    switch (c)
                    {
                        case "E":
                            //Создание эллипса: name!h!w!x!y!E 
                            name = help_string[0];
                            height = int.Parse(help_string[1]);
                            width = int.Parse(help_string[2]);
                            x = int.Parse(help_string[3]);
                            y = int.Parse(help_string[4]);
                            create_E(x, y, height, width, name);
                            break;

                        //Перемещение эллипса: dy!dx!name!M
                        case "M":
                            help_string[0].Replace('d'.ToString(), "");
                            help_string[1].Replace('d'.ToString(), "");
                            y = int.Parse(help_string[0]);
                            x = int.Parse(help_string[1]);
                            name = help_string[2];
                            move_M(x, y, name);

                            break;

                        //Удаление эллипса: name!D
                        case "D":
                            name = help_string[1];

                            break;
                        default:
                            if ((input.Contains('E')) || (input.Contains('M')) || input.Contains('D'))
                            {
                                break;
                            }
                            else listBox1.Items.Add($"{input} - Не работает");
                            break;

                    }
                }
            }
            catch { listBox1.Items.Add($"{input} - Не работает"); }
            }

        private void create_E(int x, int y, int height, int width, string name)
        {
            if (x >= 0 && x + width <= 468 && y >= 0 && y + height <= 462)
            {
                Point position = new Point(x, y);
                Ellipse ellipse = new Ellipse(position,width, height);
                FM.AddFigure(ellipse);
                ellipse.Name = name;
                listBox1.Items.Add(ellipse.Name);
                pictureBox1.Image = FM.DrawAllFigures();

            }

            else
            {
                MessageBox.Show("Фигура за пределами поля. Исправьте значения");
            }
        }



        private void move_M(int x, int y, string name)
        {
            if (listBox1.SelectedItem != null)
            {
                Figure selectedFigure = FM.figures.Find(f => f.Name == name);
                FM.MoveFigure(selectedFigure, x, y);
                pictureBox1.Image = FM.DrawAllFigures();

            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CalculateRPN(input.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            input.Text = "test!20!20!150!150!E";
        }



        //private void button1_Click_old(object sender, EventArgs e)
        //{
        //    foreach (var c in input.Text)
        //    {
        //        if (c != separator && c != 'F' && c != 'M' && c != 'D') // забив чисел стенка на стенку, ну или имя
        //        {
        //            help_string += c;
        //        }
        //        else if (c == separator)
        //        {
        //            stack.Push(help_string);
        //            help_string = "";
        //        }
        //        else if (c == 'E')    //E
        //        {
        //            if (stack.Count != 5) listBox1.Items.Add($"{input.Text} - Ошибка");
        //            create_E(stack);

        //        }

        //        if (c == 'M')        //M
        //        {

        //            move_M(stack);

        //        }

        //        if (c == 'D')
        //        {
        //            if (stack.Count != 1) listBox1.Items.Add($"{input.Text} - Ошибка");
        //            delete_D(stack);

        //        }

        //        else listBox1.Items.Add($"{input.Text} - Не работает");
        //    }

        //}





        //Перемещение эллипса: dy!dx!name!M
        //private void move_M(Stack<string> stack)
        //{
        //    try
        //    {
        //        if (stack.Count != 3) listBox1.Items.Add($"{input.Text} - Ошибка");
        //        int y = Convert.ToInt32(stack.Pop());
        //        int x = Convert.ToInt32(stack.Pop());
        //        string name = stack.Pop();

        //        Figure selectedFigure = FM.figures.Find(f => f.Name == name);
        //        FM.MoveFigure(selectedFigure, x, y);
        //        pictureBox1.Image = FM.DrawAllFigures();
        //        listBox1.Items.Add($"{input.Text} - Готово");
        //    }
        //    catch
        //    {
        //        listBox1.Items.Add($"{input.Text} - Не работает");
        //    }

        //}


        ////Создание эллипса: name!h!w!x!y!E
        //private void create_E(Stack<string> stack)
        //{
        //    try
        //    {


        //        int x, y, height, width;
        //        int.TryParse(stack.Pop(), out height);
        //        int.TryParse(stack.Pop(), out width);
        //        int.TryParse(stack.Pop(), out y);
        //        int.TryParse(stack.Pop(), out x);
        //        Point position = new Point(x, y);
        //        Ellipse ellipse = new Ellipse(position, height, width);


        //        FM.AddFigure(ellipse);

        //        listBox1.Items.Add(ellipse.Name);
        //        pictureBox1.Image = FM.DrawAllFigures();
        //        listBox1.Items.Add($"{input.Text} - Готово");
        //        pictureBox1.Image = FM.DrawAllFigures();
        //    }
        //    catch
        //    {
        //        //listBox.Items.Add($"{textBoxInput.Text} - не выполнено");
        //    }

        //}

        ////Удаление эллипса: name!D
        //private void delete_D(Stack<string> stack)

        //{
        //    string name = Convert.ToString(stack.Pop());
        //    try
        //    {
        //        int selectedFigureName;

        //        Figure selectedFigure = FM.figures.Find(f => f.Name == name);
        //        FM.RemoveFigure(selectedFigure);
        //        pictureBox1.Image = FM.DrawAllFigures();
        //        listBox1.Items.Remove(name);

        //    }

        //    catch
        //    {
        //        listBox1.Items.Add($"{input.Text} - Не работает");
        //    }
        //}


    }
}