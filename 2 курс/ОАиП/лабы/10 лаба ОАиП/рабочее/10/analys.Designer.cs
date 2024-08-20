namespace _10
{
    partial class analys
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
            this.bubble_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_col = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGrid_bub = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView_q = new System.Windows.Forms.DataGridView();
            this.an_start = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_bub)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_q)).BeginInit();
            this.SuspendLayout();
            // 
            // bubble_col
            // 
            this.bubble_col.HeaderText = "Обмен";
            this.bubble_col.MinimumWidth = 6;
            this.bubble_col.Name = "bubble_col";
            this.bubble_col.ReadOnly = true;
            this.bubble_col.Width = 300;
            // 
            // v_col
            // 
            this.v_col.HeaderText = "Объем выборки";
            this.v_col.MinimumWidth = 6;
            this.v_col.Name = "v_col";
            this.v_col.ReadOnly = true;
            this.v_col.Width = 300;
            // 
            // dataGrid_bub
            // 
            this.dataGrid_bub.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGrid_bub.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.v_col,
            this.bubble_col});
            this.dataGrid_bub.Location = new System.Drawing.Point(53, 34);
            this.dataGrid_bub.Margin = new System.Windows.Forms.Padding(4);
            this.dataGrid_bub.Name = "dataGrid_bub";
            this.dataGrid_bub.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGrid_bub.Size = new System.Drawing.Size(669, 153);
            this.dataGrid_bub.TabIndex = 1;
            this.dataGrid_bub.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGrid_bub_CellContentClick);
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Быстрая";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 300;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Объем выборки";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 300;
            // 
            // dataGridView_q
            // 
            this.dataGridView_q.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_q.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.dataGridView_q.Location = new System.Drawing.Point(53, 207);
            this.dataGridView_q.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView_q.Name = "dataGridView_q";
            this.dataGridView_q.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.dataGridView_q.Size = new System.Drawing.Size(669, 168);
            this.dataGridView_q.TabIndex = 4;
            // 
            // an_start
            // 
            this.an_start.Location = new System.Drawing.Point(53, 394);
            this.an_start.Margin = new System.Windows.Forms.Padding(4);
            this.an_start.Name = "an_start";
            this.an_start.Size = new System.Drawing.Size(248, 28);
            this.an_start.TabIndex = 5;
            this.an_start.Text = "Сравнить";
            this.an_start.UseVisualStyleBackColor = true;
            this.an_start.Click += new System.EventHandler(this.an_start_Click_1);
            // 
            // analys
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 458);
            this.Controls.Add(this.an_start);
            this.Controls.Add(this.dataGridView_q);
            this.Controls.Add(this.dataGrid_bub);
            this.Name = "analys";
            this.Text = "Анализ";
            ((System.ComponentModel.ISupportInitialize)(this.dataGrid_bub)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_q)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn bubble_col;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_col;
        private System.Windows.Forms.DataGridView dataGrid_bub;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dataGridView_q;
        private System.Windows.Forms.Button an_start;
    }
}