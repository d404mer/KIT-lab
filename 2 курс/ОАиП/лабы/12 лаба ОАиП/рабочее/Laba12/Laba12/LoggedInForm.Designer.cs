namespace login_system
{
    partial class LoggedInForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoggedInForm));
            pictureBox1 = new PictureBox();
            Name = new Label();
            DateOfBirth = new Label();
            Surname = new Label();
            Phone_number = new Label();
            Departament = new Label();
            Title = new Label();
            Salary = new Label();
            Date = new Label();
            Email = new Label();
            label2 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(41, 46);
            pictureBox1.Margin = new Padding(4, 3, 4, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(231, 293);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Name
            // 
            Name.AutoSize = true;
            Name.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Name.Location = new Point(334, 46);
            Name.Margin = new Padding(4, 0, 4, 0);
            Name.Name = "Name";
            Name.Size = new Size(91, 42);
            Name.TabIndex = 1;
            Name.Text = "Имя";
            // 
            // DateOfBirth
            // 
            DateOfBirth.AutoSize = true;
            DateOfBirth.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            DateOfBirth.Location = new Point(343, 165);
            DateOfBirth.Margin = new Padding(4, 0, 4, 0);
            DateOfBirth.Name = "DateOfBirth";
            DateOfBirth.Size = new Size(43, 18);
            DateOfBirth.TabIndex = 2;
            DateOfBirth.Text = "Дата";
            // 
            // Surname
            // 
            Surname.AutoSize = true;
            Surname.Font = new Font("Microsoft Sans Serif", 27.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Surname.Location = new Point(331, 95);
            Surname.Margin = new Padding(4, 0, 4, 0);
            Surname.Name = "Surname";
            Surname.Size = new Size(179, 42);
            Surname.TabIndex = 3;
            Surname.Text = "Фамилия";
            // 
            // Phone_number
            // 
            Phone_number.AutoSize = true;
            Phone_number.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Phone_number.Location = new Point(49, 357);
            Phone_number.Margin = new Padding(4, 0, 4, 0);
            Phone_number.Name = "Phone_number";
            Phone_number.Size = new Size(72, 18);
            Phone_number.TabIndex = 4;
            Phone_number.Text = "Телефон";
            // 
            // Departament
            // 
            Departament.AutoSize = true;
            Departament.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Departament.Location = new Point(343, 207);
            Departament.Margin = new Padding(4, 0, 4, 0);
            Departament.Name = "Departament";
            Departament.Size = new Size(53, 18);
            Departament.TabIndex = 5;
            Departament.Text = "Отдел";
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Title.Location = new Point(344, 228);
            Title.Margin = new Padding(4, 0, 4, 0);
            Title.Name = "Title";
            Title.Size = new Size(89, 18);
            Title.TabIndex = 6;
            Title.Text = "Должность";
            // 
            // Salary
            // 
            Salary.AutoSize = true;
            Salary.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Salary.Location = new Point(344, 275);
            Salary.Margin = new Padding(4, 0, 4, 0);
            Salary.Name = "Salary";
            Salary.Size = new Size(74, 18);
            Salary.TabIndex = 8;
            Salary.Text = "Зарплата";
            // 
            // Date
            // 
            Date.AutoSize = true;
            Date.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Date.Location = new Point(343, 312);
            Date.Margin = new Padding(4, 0, 4, 0);
            Date.Name = "Date";
            Date.Size = new Size(98, 18);
            Date.TabIndex = 9;
            Date.Text = "Дата приёма";
            // 
            // Email
            // 
            Email.AutoSize = true;
            Email.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Email.Location = new Point(49, 391);
            Email.Margin = new Padding(4, 0, 4, 0);
            Email.Name = "Email";
            Email.Size = new Size(51, 18);
            Email.TabIndex = 10;
            Email.Text = "Почта";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 11.25F, FontStyle.Underline, GraphicsUnit.Point, 204);
            label2.ForeColor = SystemColors.HotTrack;
            label2.Location = new Point(37, 10);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(80, 18);
            label2.TabIndex = 16;
            label2.Text = "<--- Выйти";
            label2.Click += label2_Click;
            // 
            // button1
            // 
            button1.Location = new Point(603, 390);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 17;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoggedInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(779, 441);
            Controls.Add(button1);
            Controls.Add(label2);
            Controls.Add(Email);
            Controls.Add(Date);
            Controls.Add(Salary);
            Controls.Add(Title);
            Controls.Add(Departament);
            Controls.Add(Phone_number);
            Controls.Add(Surname);
            Controls.Add(DateOfBirth);
            Controls.Add(Name);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(4, 3, 4, 3);
            Name = "LoggedInForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Тронный зал";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.Label DateOfBirth;
        private System.Windows.Forms.Label Surname;
        private System.Windows.Forms.Label Phone_number;
        private System.Windows.Forms.Label Departament;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Label Salary;
        private System.Windows.Forms.Label Date;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label label2;
        private Button button1;
    }
}