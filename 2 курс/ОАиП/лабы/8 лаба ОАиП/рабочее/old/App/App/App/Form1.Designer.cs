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
            Clear_button = new Button();
            PolygonAmount = new NumericUpDown();
            groupBox3 = new GroupBox();
            newCoordX = new TextBox();
            new_CoordX = new TextBox();
            Clear_coords = new Button();
            DeleteAllFigures = new Button();
            Change_CoordY = new Label();
            new_CoordY = new TextBox();
            label14 = new Label();
            label13 = new Label();
            groupBox4 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PolygonAmount).BeginInit();
            groupBox3.SuspendLayout();
            groupBox4.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(6, 16);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(462, 468);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(45, 34);
            label1.Name = "label1";
            label1.Size = new Size(91, 15);
            label1.TabIndex = 1;
            label1.Text = "Координата X";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 63);
            label2.Name = "label2";
            label2.Size = new Size(91, 15);
            label2.TabIndex = 2;
            label2.Text = "Координата Y";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(75, 92);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 3;
            label3.Text = "Ширина";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(80, 121);
            label4.Name = "label4";
            label4.Size = new Size(49, 15);
            label4.TabIndex = 4;
            label4.Text = "Высота";
            // 
            // CoordX
            // 
            CoordX.BackColor = SystemColors.InfoText;
            CoordX.ForeColor = SystemColors.Menu;
            CoordX.Location = new Point(180, 31);
            CoordX.Name = "CoordX";
            CoordX.Size = new Size(100, 23);
            CoordX.TabIndex = 5;
            CoordX.Text = "0";
            CoordX.TextChanged += textBox1_TextChanged;
            CoordX.KeyPress += NumOnly;
            // 
            // CoordY
            // 
            CoordY.BackColor = SystemColors.InfoText;
            CoordY.ForeColor = SystemColors.Window;
            CoordY.Location = new Point(180, 60);
            CoordY.Name = "CoordY";
            CoordY.Size = new Size(100, 23);
            CoordY.TabIndex = 6;
            CoordY.Text = "0";
            CoordY.TextChanged += textBox1_TextChanged;
            CoordY.KeyPress += NumOnly;
            // 
            // Width
            // 
            Width.BackColor = SystemColors.MenuText;
            Width.ForeColor = SystemColors.Window;
            Width.Location = new Point(180, 89);
            Width.Name = "Width";
            Width.Size = new Size(100, 23);
            Width.TabIndex = 7;
            Width.Text = "0";
            Width.TextChanged += textBox1_TextChanged;
            Width.KeyPress += NumOnly;
            // 
            // Height
            // 
            Height.BackColor = SystemColors.MenuText;
            Height.ForeColor = SystemColors.Window;
            Height.Location = new Point(180, 118);
            Height.Name = "Height";
            Height.Size = new Size(100, 23);
            Height.TabIndex = 8;
            Height.Text = "0";
            Height.TextChanged += textBox1_TextChanged;
            Height.KeyPress += NumOnly;
            // 
            // EllipseDraw
            // 
            EllipseDraw.FlatStyle = FlatStyle.Flat;
            EllipseDraw.Location = new Point(124, 22);
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
            label5.Location = new Point(70, 26);
            label5.Name = "label5";
            label5.Size = new Size(48, 15);
            label5.TabIndex = 10;
            label5.Text = "Эллипс";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(86, 53);
            label6.Name = "label6";
            label6.Size = new Size(32, 15);
            label6.TabIndex = 11;
            label6.Text = "Круг";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(24, 82);
            label7.Name = "label7";
            label7.Size = new Size(96, 15);
            label7.TabIndex = 12;
            label7.Text = "Прямоугольник";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(68, 111);
            label8.Name = "label8";
            label8.Size = new Size(50, 15);
            label8.TabIndex = 13;
            label8.Text = "Квадрат";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(25, 144);
            label9.Name = "label9";
            label9.Size = new Size(95, 15);
            label9.TabIndex = 14;
            label9.Text = "Многоугольник";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 150);
            label10.Name = "label10";
            label10.Size = new Size(119, 15);
            label10.TabIndex = 15;
            label10.Text = "Количество углов";
            // 
            // RoundDraw
            // 
            RoundDraw.FlatStyle = FlatStyle.Flat;
            RoundDraw.Location = new Point(124, 49);
            RoundDraw.Name = "RoundDraw";
            RoundDraw.Size = new Size(93, 23);
            RoundDraw.TabIndex = 17;
            RoundDraw.Text = "Нарисовать";
            RoundDraw.UseVisualStyleBackColor = true;
            RoundDraw.Click += RoundDraw_Click;
            // 
            // RectangleDraw
            // 
            RectangleDraw.FlatStyle = FlatStyle.Flat;
            RectangleDraw.Location = new Point(124, 78);
            RectangleDraw.Name = "RectangleDraw";
            RectangleDraw.Size = new Size(93, 23);
            RectangleDraw.TabIndex = 18;
            RectangleDraw.Text = "Нарисовать";
            RectangleDraw.UseVisualStyleBackColor = true;
            RectangleDraw.Click += RectangleDraw_Click;
            // 
            // SquareDraw
            // 
            SquareDraw.FlatStyle = FlatStyle.Flat;
            SquareDraw.Location = new Point(124, 107);
            SquareDraw.Name = "SquareDraw";
            SquareDraw.Size = new Size(93, 23);
            SquareDraw.TabIndex = 19;
            SquareDraw.Text = "Нарисовать";
            SquareDraw.UseVisualStyleBackColor = true;
            SquareDraw.Click += SquareDraw_Click;
            // 
            // PolygonDraw
            // 
            PolygonDraw.FlatStyle = FlatStyle.Flat;
            PolygonDraw.Location = new Point(124, 139);
            PolygonDraw.Name = "PolygonDraw";
            PolygonDraw.Size = new Size(93, 23);
            PolygonDraw.TabIndex = 20;
            PolygonDraw.Text = "Нарисовать";
            PolygonDraw.UseVisualStyleBackColor = true;
            PolygonDraw.Click += PolygonDraw_Click;
            // 
            // TriangleDraw
            // 
            TriangleDraw.FlatStyle = FlatStyle.Flat;
            TriangleDraw.Location = new Point(124, 169);
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
            label11.Location = new Point(43, 173);
            label11.Name = "label11";
            label11.Size = new Size(77, 15);
            label11.TabIndex = 21;
            label11.Text = "Треугольник";
            // 
            // DeleteFigureButton
            // 
            DeleteFigureButton.FlatStyle = FlatStyle.Flat;
            DeleteFigureButton.Location = new Point(21, 261);
            DeleteFigureButton.Name = "DeleteFigureButton";
            DeleteFigureButton.Size = new Size(145, 41);
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
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(145, 214);
            listBox1.TabIndex = 33;
            // 
            // MoveFigureButton
            // 
            MoveFigureButton.FlatStyle = FlatStyle.Flat;
            MoveFigureButton.Location = new Point(20, 418);
            MoveFigureButton.Name = "MoveFigureButton";
            MoveFigureButton.Size = new Size(145, 30);
            MoveFigureButton.TabIndex = 34;
            MoveFigureButton.Text = "Передвинуть";
            MoveFigureButton.UseVisualStyleBackColor = true;
            MoveFigureButton.Click += MoveFigureButton_Click;
            // 
            // DrawSpecial
            // 
            DrawSpecial.FlatStyle = FlatStyle.Flat;
            DrawSpecial.Location = new Point(124, 197);
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
            label12.Location = new Point(68, 201);
            label12.Name = "label12";
            label12.Size = new Size(47, 15);
            label12.TabIndex = 24;
            label12.Text = "Кастом";
            // 
            // groupBox1
            // 
            groupBox1.BackColor = SystemColors.ActiveCaptionText;
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox1.ForeColor = Color.White;
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(474, 491);
            groupBox1.TabIndex = 38;
            groupBox1.TabStop = false;
            groupBox1.Text = "Холст";
            // 
            // groupBox2
            // 
            groupBox2.BackColor = SystemColors.ActiveCaptionText;
            groupBox2.Controls.Add(Clear_button);
            groupBox2.Controls.Add(PolygonAmount);
            groupBox2.Controls.Add(label1);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label4);
            groupBox2.Controls.Add(CoordX);
            groupBox2.Controls.Add(CoordY);
            groupBox2.Controls.Add(Width);
            groupBox2.Controls.Add(Height);
            groupBox2.Controls.Add(label10);
            groupBox2.Font = new Font("Consolas", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            groupBox2.ForeColor = SystemColors.ButtonFace;
            groupBox2.Location = new Point(496, 21);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(294, 222);
            groupBox2.TabIndex = 39;
            groupBox2.TabStop = false;
            groupBox2.Text = "Параметры фигуры";
            // 
            // Clear_button
            // 
            Clear_button.FlatStyle = FlatStyle.Flat;
            Clear_button.Location = new Point(108, 182);
            Clear_button.Name = "Clear_button";
            Clear_button.Size = new Size(93, 23);
            Clear_button.TabIndex = 36;
            Clear_button.Text = "Очистить";
            Clear_button.UseVisualStyleBackColor = true;
            Clear_button.Click += Clear_button_Click;
            // 
            // PolygonAmount
            // 
            PolygonAmount.BackColor = SystemColors.InfoText;
            PolygonAmount.BorderStyle = BorderStyle.FixedSingle;
            PolygonAmount.ForeColor = SystemColors.Info;
            PolygonAmount.Location = new Point(180, 150);
            PolygonAmount.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            PolygonAmount.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            PolygonAmount.Name = "PolygonAmount";
            PolygonAmount.ReadOnly = true;
            PolygonAmount.Size = new Size(98, 23);
            PolygonAmount.TabIndex = 17;
            PolygonAmount.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaptionText;
            groupBox3.Controls.Add(newCoordX);
            groupBox3.Controls.Add(new_CoordX);
            groupBox3.Controls.Add(Clear_coords);
            groupBox3.Controls.Add(DeleteAllFigures);
            groupBox3.Controls.Add(Change_CoordY);
            groupBox3.Controls.Add(new_CoordY);
            groupBox3.Controls.Add(label14);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(listBox1);
            groupBox3.Controls.Add(DeleteFigureButton);
            groupBox3.Controls.Add(MoveFigureButton);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(805, 21);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(187, 468);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Действия";
            // 
            // newCoordX
            // 
            newCoordX.BackColor = SystemColors.InfoText;
            newCoordX.ForeColor = SystemColors.Menu;
            newCoordX.Location = new Point(49, 361);
            newCoordX.Name = "newCoordX";
            newCoordX.Size = new Size(36, 23);
            newCoordX.TabIndex = 39;
            newCoordX.Text = "0";
            newCoordX.TextChanged += textBox1_TextChanged;
            // 
            // new_CoordX
            // 
            new_CoordX.BackColor = SystemColors.InfoText;
            new_CoordX.ForeColor = SystemColors.Menu;
            new_CoordX.Location = new Point(49, 361);
            new_CoordX.Name = "new_CoordX";
            new_CoordX.Size = new Size(36, 23);
            new_CoordX.TabIndex = 39;
            new_CoordX.Text = "0";
            // 
            // Clear_coords
            // 
            Clear_coords.FlatStyle = FlatStyle.Flat;
            Clear_coords.Location = new Point(73, 390);
            Clear_coords.Name = "Clear_coords";
            Clear_coords.Size = new Size(93, 23);
            Clear_coords.TabIndex = 37;
            Clear_coords.Text = "Очистить";
            Clear_coords.UseVisualStyleBackColor = true;
            Clear_coords.Click += Clear_coords_Click;
            // 
            // DeleteAllFigures
            // 
            DeleteAllFigures.FlatStyle = FlatStyle.Flat;
            DeleteAllFigures.Location = new Point(21, 308);
            DeleteAllFigures.Name = "DeleteAllFigures";
            DeleteAllFigures.Size = new Size(145, 41);
            DeleteAllFigures.TabIndex = 38;
            DeleteAllFigures.Text = "Удалить все фигуры";
            DeleteAllFigures.UseVisualStyleBackColor = true;
            DeleteAllFigures.Click += DeleteAllFigures_Click;
            // 
            // Change_CoordY
            // 
            Change_CoordY.AutoSize = true;
            Change_CoordY.Location = new Point(101, 364);
            Change_CoordY.Name = "Change_CoordY";
            Change_CoordY.Size = new Size(22, 15);
            Change_CoordY.TabIndex = 36;
            Change_CoordY.Text = "Y+";
            // 
            // new_CoordY
            // 
            new_CoordY.BackColor = SystemColors.InfoText;
            new_CoordY.ForeColor = SystemColors.Menu;
            new_CoordY.Location = new Point(129, 361);
            new_CoordY.Name = "new_CoordY";
            new_CoordY.Size = new Size(36, 23);
            new_CoordY.TabIndex = 37;
            new_CoordY.Text = "0";
            new_CoordY.TextChanged += textBox1_TextChanged;
            new_CoordY.KeyPress += NumOnlyMin;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(31, 364);
            label14.Name = "label14";
            label14.Size = new Size(22, 15);
            label14.TabIndex = 17;
            label14.Text = "X+";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 24);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
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
            groupBox4.Location = new Point(529, 253);
            groupBox4.Name = "groupBox4";
            groupBox4.Size = new Size(233, 236);
            groupBox4.TabIndex = 40;
            groupBox4.TabStop = false;
            groupBox4.Text = "Фигуры";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1004, 505);
            Controls.Add(groupBox2);
            Controls.Add(groupBox4);
            Controls.Add(groupBox3);
            Controls.Add(groupBox1);
            ForeColor = SystemColors.Control;
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Очень Странный Paint";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PolygonAmount).EndInit();
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
        private Label label14;
        private Label Change_CoordY;
        private TextBox new_CoordY;
        private NumericUpDown PolygonAmount;
        private Button Clear_button;
        private Button DeleteAllFigures;
        private Button Clear_coords;
        private TextBox newCoordX;
        private TextBox new_CoordX;
    }
}