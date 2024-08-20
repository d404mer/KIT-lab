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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Name = new System.Windows.Forms.Label();
            this.DateOfBirth = new System.Windows.Forms.Label();
            this.Surname = new System.Windows.Forms.Label();
            this.Phone_number = new System.Windows.Forms.Label();
            this.Departament = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.Salary = new System.Windows.Forms.Label();
            this.Date = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(35, 40);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 254);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name.Location = new System.Drawing.Point(286, 40);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(91, 42);
            this.Name.TabIndex = 1;
            this.Name.Text = "Имя";
            // 
            // DateOfBirth
            // 
            this.DateOfBirth.AutoSize = true;
            this.DateOfBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateOfBirth.Location = new System.Drawing.Point(294, 143);
            this.DateOfBirth.Name = "DateOfBirth";
            this.DateOfBirth.Size = new System.Drawing.Size(43, 18);
            this.DateOfBirth.TabIndex = 2;
            this.DateOfBirth.Text = "Дата";
            // 
            // Surname
            // 
            this.Surname.AutoSize = true;
            this.Surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Surname.Location = new System.Drawing.Point(284, 82);
            this.Surname.Name = "Surname";
            this.Surname.Size = new System.Drawing.Size(179, 42);
            this.Surname.TabIndex = 3;
            this.Surname.Text = "Фамилия";
            // 
            // Phone_number
            // 
            this.Phone_number.AutoSize = true;
            this.Phone_number.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phone_number.Location = new System.Drawing.Point(42, 309);
            this.Phone_number.Name = "Phone_number";
            this.Phone_number.Size = new System.Drawing.Size(72, 18);
            this.Phone_number.TabIndex = 4;
            this.Phone_number.Text = "Телефон";
            // 
            // Departament
            // 
            this.Departament.AutoSize = true;
            this.Departament.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Departament.Location = new System.Drawing.Point(294, 179);
            this.Departament.Name = "Departament";
            this.Departament.Size = new System.Drawing.Size(53, 18);
            this.Departament.TabIndex = 5;
            this.Departament.Text = "Отдел";
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Title.Location = new System.Drawing.Point(295, 198);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(89, 18);
            this.Title.TabIndex = 6;
            this.Title.Text = "Должность";
            // 
            // Salary
            // 
            this.Salary.AutoSize = true;
            this.Salary.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Salary.Location = new System.Drawing.Point(295, 238);
            this.Salary.Name = "Salary";
            this.Salary.Size = new System.Drawing.Size(74, 18);
            this.Salary.TabIndex = 8;
            this.Salary.Text = "Зарплата";
            // 
            // Date
            // 
            this.Date.AutoSize = true;
            this.Date.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Date.Location = new System.Drawing.Point(294, 270);
            this.Date.Name = "Date";
            this.Date.Size = new System.Drawing.Size(98, 18);
            this.Date.TabIndex = 9;
            this.Date.Text = "Дата приёма";
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Email.Location = new System.Drawing.Point(42, 339);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(51, 18);
            this.Email.TabIndex = 10;
            this.Email.Text = "Почта";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(32, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 16;
            this.label2.Text = "<--- Выйти";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // LoggedInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(668, 382);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.Date);
            this.Controls.Add(this.Salary);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Departament);
            this.Controls.Add(this.Phone_number);
            this.Controls.Add(this.Surname);
            this.Controls.Add(this.DateOfBirth);
            this.Controls.Add(this.Name);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            //this.Name = "LoggedInForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тронный зал";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

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
    }
}