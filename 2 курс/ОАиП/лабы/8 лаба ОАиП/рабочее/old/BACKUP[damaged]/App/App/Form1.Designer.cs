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
            pictureBox1.Location = new Point(8, 14);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(454, 460);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 19);
            label1.Name = "label1";
            label1.Size = new Size(82, 15);
            label1.TabIndex = 1;
            label1.Text = "Координата X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(32, 48);
            label2.Name = "label2";
            label2.Size = new Size(82, 15);
            label2.TabIndex = 2;
            label2.Text = "Координата Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(62, 77);
            label3.Name = "label3";
            label3.Size = new Size(52, 15);
            label3.TabIndex = 3;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 106);
            label4.Name = "label4";
            label4.Size = new Size(47, 15);
            label4.TabIndex = 4;
            label4.Text = "Высота";
            // 
            // CoordX
            // 
            CoordX.Location = new Point(120, 16);
            CoordX.Name = "CoordX";
            CoordX.Size = new Size(100, 23);
            CoordX.TabIndex = 5;
            CoordX.Text = "-0";
            CoordX.TextChanged += CoordX_TextChanged;
            // 
            // CoordY
            // 
            CoordY.Location = new Point(120, 45);
            CoordY.Name = "CoordY";
            CoordY.Size = new Size(100, 23);
            CoordY.TabIndex = 6;
            CoordY.Text = "-0";
            CoordY.TextChanged += CoordY_TextChanged_1;
            // 
            // Width
            // 
            Width.Location = new Point(120, 74);
            Width.Name = "Width";
            Width.Size = new Size(100, 23);
            Width.TabIndex = 7;
            Width.Text = "-0";
            Width.TextChanged += Width_TextChanged;
            // 
            // Height
            // 
            Height.Location = new Point(120, 103);
            Height.Name = "Height";
            Height.Size = new Size(100, 23);
            Height.TabIndex = 8;
            Height.Text = "-0";
            Height.TextChanged += Height_TextChanged;
            // 
            // EllipseDraw
            // 
            EllipseDraw.Location = new Point(114, 15);
            EllipseDraw.Name = "EllipseDraw";
            EllipseDraw.Size = new Size(93, 23);
            EllipseDraw.TabIndex = 9;
            EllipseDraw.Text = "Нарисовать";
            EllipseDraw.UseVisualStyleBackColor = true;
            EllipseDraw.Click += EllipseDraw_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(60, 19);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Эллипс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(76, 46);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "Круг";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(12, 75);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 12;
            label7.Text = "Прямоугольник";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(58, 104);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 13;
            label8.Text = "Квадрат";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(13, 133);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 14;
            label9.Text = "Многоугольник";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(8, 135);
            label10.Name = "label10";
            label10.Size = new Size(106, 15);
            label10.TabIndex = 15;
            label10.Text = "Количество точек";
            // 
            // PolygonAmount
            // 
            PolygonAmount.Location = new Point(120, 132);
            PolygonAmount.Name = "PolygonAmount";
            PolygonAmount.Size = new Size(100, 23);
            PolygonAmount.TabIndex = 16;
            PolygonAmount.Text = "3";
            PolygonAmount.TextChanged += PolygonAmount_TextChanged;
            // 
            // RoundDraw
            // 
            RoundDraw.Location = new Point(114, 42);
            RoundDraw.Name = "RoundDraw";
            RoundDraw.Size = new Size(93, 23);
            RoundDraw.TabIndex = 17;
            RoundDraw.Text = "Нарисовать";
            RoundDraw.UseVisualStyleBackColor = true;
            RoundDraw.Click += RoundDraw_Click;
            // 
            // RectangleDraw
            // 
            RectangleDraw.Location = new Point(114, 71);
            RectangleDraw.Name = "RectangleDraw";
            RectangleDraw.Size = new Size(93, 23);
            RectangleDraw.TabIndex = 18;
            RectangleDraw.Text = "Нарисовать";
            RectangleDraw.UseVisualStyleBackColor = true;
            RectangleDraw.Click += RectangleDraw_Click;
            // 
            // SquareDraw
            // 
            SquareDraw.Location = new Point(114, 100);
            SquareDraw.Name = "SquareDraw";
            SquareDraw.Size = new Size(93, 23);
            SquareDraw.TabIndex = 19;
            SquareDraw.Text = "Нарисовать";
            SquareDraw.UseVisualStyleBackColor = true;
            SquareDraw.Click += SquareDraw_Click;
            // 
            // PolygonDraw
            // 
            PolygonDraw.Location = new Point(114, 129);
            PolygonDraw.Name = "PolygonDraw";
            PolygonDraw.Size = new Size(93, 23);
            PolygonDraw.TabIndex = 20;
            PolygonDraw.Text = "Нарисовать";
            PolygonDraw.UseVisualStyleBackColor = true;
            PolygonDraw.Click += PolygonDraw_Click;
            // 
            // TriangleDraw
            // 
            TriangleDraw.Location = new Point(114, 158);
            TriangleDraw.Name = "TriangleDraw";
            TriangleDraw.Size = new Size(93, 23);
            TriangleDraw.TabIndex = 22;
            TriangleDraw.Text = "Нарисовать";
            TriangleDraw.UseVisualStyleBackColor = true;
            TriangleDraw.Click += TriangleDraw_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(31, 162);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 21;
            label11.Text = "Треугольник";
            // 
            // DeleteFigureButton
            // 
            DeleteFigureButton.Location = new Point(15, 260);
            DeleteFigureButton.Name = "DeleteFigureButton";
            DeleteFigureButton.Size = new Size(145, 45);
            DeleteFigureButton.TabIndex = 32;
            DeleteFigureButton.Text = "Удалить выбранную фигуру";
            DeleteFigureButton.UseVisualStyleBackColor = true;
            DeleteFigureButton.Click += DeleteFigureButton_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(15, 40);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 214);
            listBox1.TabIndex = 33;
            // 
            // MoveFigureButton
            // 
            MoveFigureButton.Location = new Point(15, 311);
            MoveFigureButton.Name = "MoveFigureButton";
            MoveFigureButton.Size = new Size(141, 52);
            MoveFigureButton.TabIndex = 34;
            MoveFigureButton.Text = "Передвинуть выбранную фигуру";
            MoveFigureButton.UseVisualStyleBackColor = true;
            MoveFigureButton.Click += MoveFigureButton_Click;
            // 
            // DrawSpecial
            // 
            DrawSpecial.Location = new Point(114, 187);
            DrawSpecial.Name = "DrawSpecial";
            DrawSpecial.Size = new Size(93, 23);
            DrawSpecial.TabIndex = 35;
            DrawSpecial.Text = "Нарисовать";
            DrawSpecial.UseVisualStyleBackColor = true;
            DrawSpecial.Click += DrawSpecial_Click;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(56, 190);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 24;
            label12.Text = "Кастом";
            label12.Click += label12_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(CoordX);
            groupBox1.Controls.Add(CoordY);
            groupBox1.Controls.Add(Width);
            groupBox1.Controls.Add(Height);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(PolygonAmount);
            groupBox1.Location = new Point(486, 46);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(231, 173);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Параметры фигуры";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label5);
            groupBox2.Controls.Add(EllipseDraw);
            groupBox2.Controls.Add(label6);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(DrawSpecial);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(RoundDraw);
            groupBox2.Controls.Add(RectangleDraw);
            groupBox2.Controls.Add(label12);
            groupBox2.Controls.Add(SquareDraw);
            groupBox2.Controls.Add(TriangleDraw);
            groupBox2.Controls.Add(PolygonDraw);
            groupBox2.Controls.Add(label11);
            groupBox2.Location = new Point(488, 225);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(229, 222);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Фигуры";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(DeleteFigureButton);
            groupBox3.Controls.Add(MoveFigureButton);
            groupBox3.Location = new Point(723, 54);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(173, 393);
            groupBox3.TabIndex = 40;
            groupBox3.TabStop = false;
            groupBox3.Text = "Действия";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(15, 21);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 35;
            label13.Text = "Список фигур";
            // 
            // groupBox4
            // 
            groupBox4.Controls.Add(pictureBox1);
            groupBox4.Location = new Point(2, 3);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(468, 480);
            groupBox4.TabIndex = 41;
            groupBox4.TabStop = false;
            groupBox4.Text = "Холст";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(915, 495);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Очень странный Paint";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            groupBox4.ResumeLayout(false);
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