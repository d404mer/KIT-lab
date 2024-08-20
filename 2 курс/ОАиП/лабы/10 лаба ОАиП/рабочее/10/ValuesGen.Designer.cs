
namespace _10
{
    partial class ValuesGen
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
            this.gen_btn = new System.Windows.Forms.Button();
            this.inp_count = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.inp_count)).BeginInit();
            this.SuspendLayout();
            // 
            // gen_btn
            // 
            this.gen_btn.Location = new System.Drawing.Point(49, 76);
            this.gen_btn.Name = "gen_btn";
            this.gen_btn.Size = new System.Drawing.Size(75, 23);
            this.gen_btn.TabIndex = 1;
            this.gen_btn.Text = "Создать";
            this.gen_btn.UseVisualStyleBackColor = true;
            this.gen_btn.Click += new System.EventHandler(this.gen_btn_Click);
            // 
            // inp_count
            // 
            this.inp_count.Location = new System.Drawing.Point(49, 50);
            this.inp_count.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.inp_count.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.inp_count.Name = "inp_count";
            this.inp_count.Size = new System.Drawing.Size(75, 20);
            this.inp_count.TabIndex = 2;
            this.inp_count.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // ValuesGen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 140);
            this.Controls.Add(this.inp_count);
            this.Controls.Add(this.gen_btn);
            this.Name = "ValuesGen";
            this.Text = "ValuesGen";
            ((System.ComponentModel.ISupportInitialize)(this.inp_count)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button gen_btn;
        private System.Windows.Forms.NumericUpDown inp_count;
    }
}