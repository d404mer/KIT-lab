namespace _7laba.UserControls
{
    partial class UC_5laba
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_5laba));
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.matrix_output = new System.Windows.Forms.Label();
            this.mult = new System.Windows.Forms.Label();
            this.determ = new System.Windows.Forms.Label();
            sidebar = new System.Windows.Forms.Panel();
            sidebar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebar
            // 
            sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            sidebar.Controls.Add(this.button2);
            sidebar.Controls.Add(this.pictureBox6);
            sidebar.Controls.Add(this.label2);
            sidebar.Controls.Add(this.label3);
            sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            sidebar.Location = new System.Drawing.Point(0, 0);
            sidebar.Name = "sidebar";
            sidebar.Size = new System.Drawing.Size(214, 572);
            sidebar.TabIndex = 4;
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.ImageKey = "(none)";
            this.button2.Location = new System.Drawing.Point(21, 496);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(166, 50);
            this.button2.TabIndex = 7;
            this.button2.Text = "Запустить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(17, 57);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(133, 16);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 4;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(13, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 410);
            this.label2.TabIndex = 3;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(17, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "LABA 5:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(538, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 21);
            this.label1.TabIndex = 9;
            this.label1.Text = "Исходная матрица:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(725, 311);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(199, 21);
            this.label4.TabIndex = 10;
            this.label4.Text = "Определитель матрицы:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(316, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(298, 21);
            this.label5.TabIndex = 11;
            this.label5.Text = "Произведение диагональных эл-ов:";
            // 
            // matrix_output
            // 
            this.matrix_output.AutoSize = true;
            this.matrix_output.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.matrix_output.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.matrix_output.Location = new System.Drawing.Point(591, 150);
            this.matrix_output.Name = "matrix_output";
            this.matrix_output.Size = new System.Drawing.Size(0, 21);
            this.matrix_output.TabIndex = 12;
            // 
            // mult
            // 
            this.mult.AutoSize = true;
            this.mult.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.mult.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.mult.Location = new System.Drawing.Point(409, 341);
            this.mult.Name = "mult";
            this.mult.Size = new System.Drawing.Size(0, 21);
            this.mult.TabIndex = 13;
            // 
            // determ
            // 
            this.determ.AutoSize = true;
            this.determ.Font = new System.Drawing.Font("Cascadia Code", 12F);
            this.determ.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.determ.Location = new System.Drawing.Point(809, 341);
            this.determ.Name = "determ";
            this.determ.Size = new System.Drawing.Size(0, 21);
            this.determ.TabIndex = 14;
            // 
            // UC_5laba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(36)))));
            this.Controls.Add(this.determ);
            this.Controls.Add(this.mult);
            this.Controls.Add(this.matrix_output);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(sidebar);
            this.MaximumSize = new System.Drawing.Size(1067, 572);
            this.MinimumSize = new System.Drawing.Size(1067, 572);
            this.Name = "UC_5laba";
            this.Size = new System.Drawing.Size(1067, 572);
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label matrix_output;
        private System.Windows.Forms.Label mult;
        private System.Windows.Forms.Label determ;
    }
}
