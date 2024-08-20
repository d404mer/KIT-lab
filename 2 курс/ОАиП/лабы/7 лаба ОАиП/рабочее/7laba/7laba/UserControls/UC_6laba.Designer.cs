namespace _7laba.UserControls
{
    partial class UC_6laba
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.Panel sidebar;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_6laba));
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numerator1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.denominator1 = new System.Windows.Forms.TextBox();
            this.addition = new System.Windows.Forms.Button();
            this.difference = new System.Windows.Forms.Button();
            this.multiplication = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.denominator2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.numerator2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.num_res = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            sidebar = new System.Windows.Forms.Panel();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            sidebar.Controls.Add(this.pictureBox6);
            sidebar.Controls.Add(this.label2);
            sidebar.Controls.Add(this.label3);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            sidebar.Name = "sidebar";
            sidebar.Size = new System.Drawing.Size(321, 880);
            sidebar.TabIndex = 4;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(26, 88);
            this.pictureBox6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(200, 25);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(26, 117);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(273, 642);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(26, 51);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 32);
            this.label3.TabIndex = 2;
            this.label3.Text = "LABA 6:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(564, 305);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 32);
            this.label1.TabIndex = 10;
            this.label1.Text = "Введите дробь:";
            // 
            // numerator1
            // 
            this.numerator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numerator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.numerator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numerator1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.numerator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numerator1.Location = new System.Drawing.Point(627, 358);
            this.numerator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numerator1.MaxLength = 4;
            this.numerator1.Multiline = true;
            this.numerator1.Name = "numerator1";
            this.numerator1.Size = new System.Drawing.Size(74, 57);
            this.numerator1.TabIndex = 11;
            this.numerator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerator1_KeyPress);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(604, 426);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(128, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // denominator1
            // 
            this.denominator1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.denominator1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.denominator1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denominator1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.denominator1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.denominator1.Location = new System.Drawing.Point(627, 460);
            this.denominator1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.denominator1.MaxLength = 4;
            this.denominator1.Multiline = true;
            this.denominator1.Name = "denominator1";
            this.denominator1.Size = new System.Drawing.Size(74, 57);
            this.denominator1.TabIndex = 12;
            this.denominator1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.denominator1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.denominator1_KeyPress);
            // 
            // addition
            // 
            this.addition.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.addition.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.addition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addition.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.addition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addition.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addition.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.addition.ImageKey = "(none)";
            this.addition.Location = new System.Drawing.Point(802, 265);
            this.addition.Margin = new System.Windows.Forms.Padding(195, 5, 4, 5);
            this.addition.Name = "addition";
            this.addition.Size = new System.Drawing.Size(54, 49);
            this.addition.TabIndex = 13;
            this.addition.Text = "+";
            this.addition.UseVisualStyleBackColor = false;
            this.addition.Click += new System.EventHandler(this.addition_Click);
            // 
            // difference
            // 
            this.difference.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.difference.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.difference.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difference.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.difference.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difference.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.difference.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.difference.ImageKey = "(none)";
            this.difference.Location = new System.Drawing.Point(802, 323);
            this.difference.Margin = new System.Windows.Forms.Padding(195, 5, 4, 5);
            this.difference.Name = "difference";
            this.difference.Size = new System.Drawing.Size(54, 49);
            this.difference.TabIndex = 14;
            this.difference.Text = "-";
            this.difference.UseVisualStyleBackColor = false;
            this.difference.Click += new System.EventHandler(this.difference_Click);
            // 
            // multiplication
            // 
            this.multiplication.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiplication.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.multiplication.Cursor = System.Windows.Forms.Cursors.Hand;
            this.multiplication.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.multiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.multiplication.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiplication.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.multiplication.ImageKey = "(none)";
            this.multiplication.Location = new System.Drawing.Point(802, 383);
            this.multiplication.Margin = new System.Windows.Forms.Padding(195, 5, 4, 5);
            this.multiplication.Name = "multiplication";
            this.multiplication.Size = new System.Drawing.Size(54, 49);
            this.multiplication.TabIndex = 15;
            this.multiplication.Text = "x";
            this.multiplication.UseVisualStyleBackColor = false;
            this.multiplication.Click += new System.EventHandler(this.multiplication_Click);
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Cascadia Code", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.ImageKey = "(none)";
            this.button1.Location = new System.Drawing.Point(802, 442);
            this.button1.Margin = new System.Windows.Forms.Padding(195, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "÷";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Cascadia Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3.ImageKey = "(none)";
            this.button3.Location = new System.Drawing.Point(802, 500);
            this.button3.Margin = new System.Windows.Forms.Padding(195, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(54, 52);
            this.button3.TabIndex = 17;
            this.button3.Text = "≟";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // denominator2
            // 
            this.denominator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.denominator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.denominator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.denominator2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.denominator2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.denominator2.Location = new System.Drawing.Point(952, 460);
            this.denominator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.denominator2.MaxLength = 4;
            this.denominator2.Multiline = true;
            this.denominator2.Name = "denominator2";
            this.denominator2.Size = new System.Drawing.Size(74, 57);
            this.denominator2.TabIndex = 21;
            this.denominator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.denominator2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.denominator2_KeyPress);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(930, 426);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(128, 25);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // numerator2
            // 
            this.numerator2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.numerator2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.numerator2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numerator2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.numerator2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.numerator2.Location = new System.Drawing.Point(952, 358);
            this.numerator2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.numerator2.MaxLength = 4;
            this.numerator2.Multiline = true;
            this.numerator2.Name = "numerator2";
            this.numerator2.Size = new System.Drawing.Size(74, 57);
            this.numerator2.TabIndex = 20;
            this.numerator2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numerator2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.numerator2_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(890, 305);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(210, 32);
            this.label4.TabIndex = 19;
            this.label4.Text = "Введите дробь:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(1086, 403);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 47);
            this.label5.TabIndex = 22;
            this.label5.Text = "=";
            // 
            // num_res
            // 
            this.num_res.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.num_res.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.num_res.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.num_res.Font = new System.Drawing.Font("Cascadia Code", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.num_res.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.num_res.Location = new System.Drawing.Point(1160, 403);
            this.num_res.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.num_res.Multiline = true;
            this.num_res.Name = "num_res";
            this.num_res.Size = new System.Drawing.Size(206, 209);
            this.num_res.TabIndex = 25;
            this.num_res.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(1178, 358);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(154, 32);
            this.label6.TabIndex = 24;
            this.label6.Text = "Результат:";
            // 
            // UC_6laba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.num_res);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.denominator2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.numerator2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.multiplication);
            this.Controls.Add(this.difference);
            this.Controls.Add(this.addition);
            this.Controls.Add(this.denominator1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.numerator1);
            this.Controls.Add(this.label1);
            this.Controls.Add(sidebar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1600, 880);
            this.MinimumSize = new System.Drawing.Size(1600, 880);
            this.Name = "UC_6laba";
            this.Size = new System.Drawing.Size(1600, 880);
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox numerator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.TextBox denominator1;
        private System.Windows.Forms.Button addition;
        private System.Windows.Forms.Button difference;
        private System.Windows.Forms.Button multiplication;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox denominator2;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.TextBox numerator2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox num_res;
        private System.Windows.Forms.Label label6;
    }
}
