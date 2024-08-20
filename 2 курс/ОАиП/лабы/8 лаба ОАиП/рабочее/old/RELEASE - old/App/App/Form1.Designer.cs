namespace App
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            CoordX = new TextBox();
            CoordY = new TextBox();
            Width = new TextBox();
            Height = new TextBox();
            EllipseDraw = new Button();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            PolygonAmount = new TextBox();
            RoundDraw = new Button();
            RectangleDraw = new Button();
            SquareDraw = new Button();
            PolygonDraw = new Button();
            TriangleDraw = new Button();
            label11 = new Label();
            DeleteFigureButton = new Button();
            listBox1 = new ListBox();
            MoveFigureButton = new Button();
            DrawSpecial = new Button();
            label12 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            groupBox3 = new GroupBox();
            label13 = new Label();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(9, 27);
            pictureBox1.Margin = new Padding(4, 5, 4, 5);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(660, 780);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 57);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(142, 23);
            label1.TabIndex = 1;
            label1.Text = "Координата X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 105);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(142, 23);
            label2.TabIndex = 2;
            label2.Text = "Координата Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(107, 153);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(76, 23);
            label3.TabIndex = 3;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(114, 202);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(76, 23);
            label4.TabIndex = 4;
            label4.Text = "Высота";
            // 
            // CoordX
            // 
            CoordX.BackColor = SystemColors.InfoText;
            CoordX.ForeColor = SystemColors.Menu;
            CoordX.Location = new Point(257, 52);
            CoordX.Margin = new Padding(4, 5, 4, 5);
            CoordX.Name = "CoordX";
            CoordX.Size = new Size(141, 30);
            CoordX.TabIndex = 5;
            CoordX.TextChanged += CoordX_TextChanged;
            // 
            // CoordY
            // 
            CoordY.BackColor = SystemColors.InfoText;
            CoordY.ForeColor = SystemColors.Window;
            CoordY.Location = new Point(257, 100);
            CoordY.Margin = new Padding(4, 5, 4, 5);
            CoordY.Name = "CoordY";
            CoordY.Size = new Size(141, 30);
            CoordY.TabIndex = 6;
            CoordY.TextChanged += CoordY_TextChanged_1;
            // 
            // Width
            // 
            Width.BackColor = SystemColors.MenuText;
            Width.ForeColor = SystemColors.Window;
            Width.Location = new Point(257, 148);
            Width.Margin = new Padding(4, 5, 4, 5);
            Width.Name = "Width";
            Width.Size = new Size(141, 30);
            Width.TabIndex = 7;
            Width.TextChanged += Width_TextChanged;
            // 
            // Height
            // 
            Height.BackColor = SystemColors.MenuText;
            Height.ForeColor = SystemColors.Window;
            Height.Location = new Point(257, 197);
            Height.Margin = new Padding(4, 5, 4, 5);
            Height.Name = "Height";
            Height.Size = new Size(141, 30);
            Height.TabIndex = 8;
            Height.TextChanged += Height_TextChanged;
            // 
            // EllipseDraw
            // 
            EllipseDraw.FlatStyle = FlatStyle.Flat;
            EllipseDraw.Location = new Point(177, 37);
            EllipseDraw.Margin = new Padding(4, 5, 4, 5);
            EllipseDraw.Name = "EllipseDraw";
            EllipseDraw.Size = new Size(133, 38);
            EllipseDraw.TabIndex = 9;
            EllipseDraw.Text = "Нарисовать";
            EllipseDraw.UseVisualStyleBackColor = true;
            EllipseDraw.Click += EllipseDraw_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(100, 43);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(69, 25);
            label5.TabIndex = 10;
            label5.Text = "Эллипс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(123, 88);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(49, 25);
            label6.TabIndex = 11;
            label6.Text = "Круг";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(34, 143);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(143, 25);
            label7.TabIndex = 12;
            label7.Text = "Прямоугольник";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(100, 192);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(78, 25);
            label8.TabIndex = 13;
            label8.Text = "Квадрат";
            label8.Click += label8_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(36, 240);
            label9.Margin = new Padding(4, 0, 4, 0);
            label9.Name = "label9";
            label9.Size = new Size(141, 25);
            label9.TabIndex = 14;
            label9.Text = "Многоугольник";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(30, 250);
            label10.Margin = new Padding(4, 0, 4, 0);
            label10.Name = "label10";
            label10.Size = new Size(186, 23);
            label10.TabIndex = 15;
            label10.Text = "Количество углов";
            // 
            // PolygonAmount
            // 
            PolygonAmount.BackColor = SystemColors.MenuText;
            PolygonAmount.ForeColor = SystemColors.Window;
            PolygonAmount.Location = new Point(257, 245);
            PolygonAmount.Margin = new Padding(4, 5, 4, 5);
            PolygonAmount.Name = "PolygonAmount";
            PolygonAmount.Size = new Size(141, 30);
            PolygonAmount.TabIndex = 16;
            PolygonAmount.TextChanged += PolygonAmount_TextChanged;
            // 
            // RoundDraw
            // 
            RoundDraw.FlatStyle = FlatStyle.Flat;
            RoundDraw.Location = new Point(177, 82);
            RoundDraw.Margin = new Padding(4, 5, 4, 5);
            RoundDraw.Name = "RoundDraw";
            RoundDraw.Size = new Size(133, 38);
            RoundDraw.TabIndex = 17;
            RoundDraw.Text = "Нарисовать";
            RoundDraw.UseVisualStyleBackColor = true;
            RoundDraw.Click += RoundDraw_Click;
            // 
            // RectangleDraw
            // 
            RectangleDraw.FlatStyle = FlatStyle.Flat;
            RectangleDraw.Location = new Point(180, 137);
            RectangleDraw.Margin = new Padding(4, 5, 4, 5);
            RectangleDraw.Name = "RectangleDraw";
            RectangleDraw.Size = new Size(133, 38);
            RectangleDraw.TabIndex = 18;
            RectangleDraw.Text = "Нарисовать";
            RectangleDraw.UseVisualStyleBackColor = true;
            RectangleDraw.Click += RectangleDraw_Click;
            // 
            // SquareDraw
            // 
            SquareDraw.FlatStyle = FlatStyle.Flat;
            SquareDraw.Location = new Point(180, 185);
            SquareDraw.Margin = new Padding(4, 5, 4, 5);
            SquareDraw.Name = "SquareDraw";
            SquareDraw.Size = new Size(133, 38);
            SquareDraw.TabIndex = 19;
            SquareDraw.Text = "Нарисовать";
            SquareDraw.UseVisualStyleBackColor = true;
            SquareDraw.Click += SquareDraw_Click;
            // 
            // PolygonDraw
            // 
            PolygonDraw.FlatStyle = FlatStyle.Flat;
            PolygonDraw.Location = new Point(180, 233);
            PolygonDraw.Margin = new Padding(4, 5, 4, 5);
            PolygonDraw.Name = "PolygonDraw";
            PolygonDraw.Size = new Size(133, 38);
            PolygonDraw.TabIndex = 20;
            PolygonDraw.Text = "Нарисовать";
            PolygonDraw.UseVisualStyleBackColor = true;
            PolygonDraw.Click += PolygonDraw_Click;
            // 
            // TriangleDraw
            // 
            TriangleDraw.FlatStyle = FlatStyle.Flat;
            TriangleDraw.Location = new Point(180, 282);
            TriangleDraw.Margin = new Padding(4, 5, 4, 5);
            TriangleDraw.Name = "TriangleDraw";
            TriangleDraw.Size = new Size(133, 38);
            TriangleDraw.TabIndex = 22;
            TriangleDraw.Text = "Нарисовать";
            TriangleDraw.UseVisualStyleBackColor = true;
            TriangleDraw.Click += TriangleDraw_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(61, 288);
            label11.Margin = new Padding(4, 0, 4, 0);
            label11.Name = "label11";
            label11.Size = new Size(115, 25);
            label11.TabIndex = 21;
            label11.Text = "Треугольник";
            // 
            // DeleteFigureButton
            // 
            DeleteFigureButton.FlatStyle = FlatStyle.Flat;
            DeleteFigureButton.Location = new Point(29, 525);
            DeleteFigureButton.Margin = new Padding(4, 5, 4, 5);
            DeleteFigureButton.Name = "DeleteFigureButton";
            DeleteFigureButton.Size = new Size(207, 68);
            DeleteFigureButton.TabIndex = 32;
            DeleteFigureButton.Text = "Удалить выбранную фигуру";
            DeleteFigureButton.UseVisualStyleBackColor = true;
            DeleteFigureButton.Click += DeleteFigureButton_Click;
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InfoText;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 25;
            listBox1.Location = new Point(29, 83);
            listBox1.Margin = new Padding(4, 5, 4, 5);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(205, 429);
            listBox1.TabIndex = 33;
            // 
            // MoveFigureButton
            // 
            MoveFigureButton.FlatStyle = FlatStyle.Flat;
            MoveFigureButton.Location = new Point(29, 603);
            MoveFigureButton.Margin = new Padding(4, 5, 4, 5);
            MoveFigureButton.Name = "MoveFigureButton";
            MoveFigureButton.Size = new Size(207, 83);
            MoveFigureButton.TabIndex = 34;
            MoveFigureButton.Text = "Передвинуть выбранную фигуру";
            MoveFigureButton.UseVisualStyleBackColor = true;
            MoveFigureButton.Click += MoveFigureButton_Click;
            // 
            // DrawSpecial
            // 
            DrawSpecial.FlatStyle = FlatStyle.Flat;
            DrawSpecial.Location = new Point(180, 330);
            DrawSpecial.Margin = new Padding(4, 5, 4, 5);
            DrawSpecial.Name = "DrawSpecial";
            DrawSpecial.Size = new Size(133, 38);
            DrawSpecial.TabIndex = 35;
            DrawSpecial.Text = "Нарисовать";
            DrawSpecial.UseVisualStyleBackColor = true;
            DrawSpecial.Click += DrawSpecial_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(97, 335);
            label12.Margin = new Padding(4, 0, 4, 0);
            label12.Name = "label12";
            label12.Size = new Size(70, 25);
            label12.TabIndex = 24;
            label12.Text = "Кастом";
            label12.Click += label12_Click;
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = SystemColors.Control;
            groupBox1.Location = new Point(17, 20);
            groupBox1.Margin = new Padding(4, 5, 4, 5);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(4, 5, 4, 5);
            groupBox1.Size = new Size(677, 818);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Холст";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(CoordX);
            groupBox2.Controls.Add(CoordY);
            groupBox2.Controls.Add(Width);
            groupBox2.Controls.Add(Height);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(PolygonAmount);
            groupBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(703, 57);
            groupBox2.Margin = new Padding(4, 5, 4, 5);
            groupBox2.Name = "groupBox2";
            groupBox2.Padding = new Padding(4, 5, 4, 5);
            groupBox2.Size = new Size(437, 343);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры фигуры";
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaptionText;
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(DeleteFigureButton);
            groupBox3.Controls.Add(MoveFigureButton);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(1148, 47);
            groupBox3.Margin = new Padding(4, 5, 4, 5);
            groupBox3.Name = "groupBox3";
            groupBox3.Padding = new Padding(4, 5, 4, 5);
            groupBox3.Size = new Size(274, 705);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Действия";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(23, 43);
            label13.Margin = new Padding(4, 0, 4, 0);
            label13.Name = "label13";
            label13.Size = new Size(125, 25);
            label13.TabIndex = 35;
            label13.Text = "Список фигур";
            // 
            // groupBox4
            // 
            groupBox4.BackColor = SystemColors.ActiveCaptionText;
            groupBox4.Controls.Add(EllipseDraw);
            groupBox4.Controls.Add(label5);
            groupBox4.Controls.Add(label6);
            groupBox4.Controls.Add(DrawSpecial);
            groupBox4.Controls.Add(label7);
            groupBox4.Controls.Add(label12);
            groupBox4.Controls.Add(label8);
            groupBox4.Controls.Add(TriangleDraw);
            groupBox4.Controls.Add(label9);
            groupBox4.Controls.Add(label11);
            groupBox4.Controls.Add(RoundDraw);
            groupBox4.Controls.Add(PolygonDraw);
            groupBox4.Controls.Add(RectangleDraw);
            groupBox4.Controls.Add(SquareDraw);
            groupBox4.FlatStyle = FlatStyle.Flat;
            groupBox4.ForeColor = SystemColors.ControlLightLight;
            groupBox4.Location = new Point(767, 421);
            groupBox4.Margin = new Padding(4, 5, 4, 5);
            groupBox4.Name = "groupBox4";
            groupBox4.Padding = new Padding(4, 5, 4, 5);
            groupBox4.Size = new Size(333, 393);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            groupBox4.Text = "Фигуры";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1435, 841);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4, 5, 4, 5);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Очень Странный Paint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
            groupBox4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox CoordX;
        private TextBox CoordY;
        private TextBox Width;
        private TextBox Height;
        private Button EllipseDraw;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox PolygonAmount;
        private Button RoundDraw;
        private Button RectangleDraw;
        private Button SquareDraw;
        private Button PolygonDraw;
        private Button TriangleDraw;
        private Label label11;
        private Button DeleteFigureButton;
        private ListBox listBox1;
        private Button MoveFigureButton;
        private Button DrawSpecial;
        private Label label12;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private Label label13;
        private GroupBox groupBox4;
    }
}