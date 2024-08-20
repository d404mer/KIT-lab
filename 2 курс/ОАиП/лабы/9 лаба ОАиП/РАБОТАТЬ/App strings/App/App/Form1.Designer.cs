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
            listBox1 = new ListBox();
            groupBox1 = new GroupBox();
            groupBox3 = new GroupBox();
            button1 = new Button();
            label4 = new Label();
            input = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            label13 = new Label();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox3.SuspendLayout();
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
            // listBox1
            // 
            listBox1.BackColor = SystemColors.InfoText;
            listBox1.ForeColor = SystemColors.Window;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(21, 41);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(249, 409);
            listBox1.TabIndex = 33;
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
            // groupBox3
            // 
            groupBox3.BackColor = SystemColors.ActiveCaptionText;
            groupBox3.Controls.Add(button2);
            groupBox3.Controls.Add(button1);
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(input);
            groupBox3.Controls.Add(label3);
            groupBox3.Controls.Add(label2);
            groupBox3.Controls.Add(label1);
            groupBox3.Controls.Add(label13);
            groupBox3.Controls.Add(listBox1);
            groupBox3.ForeColor = SystemColors.Control;
            groupBox3.Location = new Point(492, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(500, 491);
            groupBox3.TabIndex = 39;
            groupBox3.TabStop = false;
            groupBox3.Text = "Действия";
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(299, 372);
            button1.Name = "button1";
            button1.Size = new Size(177, 58);
            button1.TabIndex = 41;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(290, 301);
            label4.Name = "label4";
            label4.Size = new Size(82, 15);
            label4.TabIndex = 40;
            label4.Text = "Вводить сюда";
            // 
            // input
            // 
            input.BackColor = SystemColors.InfoText;
            input.ForeColor = SystemColors.Window;
            input.Location = new Point(290, 319);
            input.Name = "input";
            input.Size = new Size(186, 23);
            input.TabIndex = 39;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(318, 218);
            label3.Name = "label3";
            label3.Size = new Size(141, 42);
            label3.TabIndex = 38;
            label3.Text = "Удаление эллипса:\r\nname!D";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(301, 158);
            label2.Name = "label2";
            label2.Size = new Size(175, 42);
            label2.TabIndex = 37;
            label2.Text = "Перемещение эллипса:\r\ndy!dx!name!M";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(315, 104);
            label1.Name = "label1";
            label1.Size = new Size(146, 42);
            label1.TabIndex = 36;
            label1.Text = "Создание эллипса: \r\nname!h!w!x!y!E";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(21, 23);
            label13.Name = "label13";
            label13.Size = new Size(85, 15);
            label13.TabIndex = 35;
            label13.Text = "Список фигур";
            // 
            // button2
            // 
            button2.Location = new Point(280, 451);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 42;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveCaptionText;
            ClientSize = new Size(1004, 505);
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
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox pictureBox1;
        private ListBox listBox1;
        private GroupBox groupBox1;
        private GroupBox groupBox3;
        private Label label13;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label4;
        private TextBox input;
        private Button button1;
        private Button button2;
    }
}