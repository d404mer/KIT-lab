
namespace _10
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.bubble_rb = new System.Windows.Forms.RadioButton();
            this.quick_rb = new System.Windows.Forms.RadioButton();
            this.sort_btn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.time = new System.Windows.Forms.Label();
            this.peres_count = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clear_sort_params_btn = new System.Windows.Forms.Button();
            this.eq_count = new System.Windows.Forms.Label();
            this.view = new System.Windows.Forms.RichTextBox();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.import = new System.Windows.Forms.Button();
            this.txt_export = new System.Windows.Forms.Button();
            this.open_gen_win_btn = new System.Windows.Forms.Button();
            this.analysis = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Controls.Add(this.bubble_rb, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.quick_rb, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.sort_btn, 0, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(711, 68);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(320, 142);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // bubble_rb
            // 
            this.bubble_rb.AutoSize = true;
            this.bubble_rb.Checked = true;
            this.bubble_rb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bubble_rb.Location = new System.Drawing.Point(4, 4);
            this.bubble_rb.Margin = new System.Windows.Forms.Padding(4);
            this.bubble_rb.Name = "bubble_rb";
            this.bubble_rb.Size = new System.Drawing.Size(312, 39);
            this.bubble_rb.TabIndex = 0;
            this.bubble_rb.TabStop = true;
            this.bubble_rb.Text = "Обмен";
            this.bubble_rb.UseVisualStyleBackColor = true;
            this.bubble_rb.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // quick_rb
            // 
            this.quick_rb.AutoSize = true;
            this.quick_rb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.quick_rb.Location = new System.Drawing.Point(4, 51);
            this.quick_rb.Margin = new System.Windows.Forms.Padding(4);
            this.quick_rb.Name = "quick_rb";
            this.quick_rb.Size = new System.Drawing.Size(312, 39);
            this.quick_rb.TabIndex = 1;
            this.quick_rb.Text = "Быстрая сортировка:";
            this.quick_rb.UseVisualStyleBackColor = true;
            // 
            // sort_btn
            // 
            this.sort_btn.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.sort_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sort_btn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.sort_btn.Location = new System.Drawing.Point(4, 98);
            this.sort_btn.Margin = new System.Windows.Forms.Padding(4);
            this.sort_btn.Name = "sort_btn";
            this.sort_btn.Size = new System.Drawing.Size(312, 40);
            this.sort_btn.TabIndex = 2;
            this.sort_btn.Text = "Сортировать";
            this.sort_btn.UseVisualStyleBackColor = false;
            this.sort_btn.Click += new System.EventHandler(this.sort_btn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "Сравнений:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 55.95238F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 44.04762F));
            this.tableLayoutPanel2.Controls.Add(this.time, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.peres_count, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.clear_sort_params_btn, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.eq_count, 1, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(707, 239);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 4;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(324, 146);
            this.tableLayoutPanel2.TabIndex = 2;
            this.tableLayoutPanel2.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel2_Paint);
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Dock = System.Windows.Forms.DockStyle.Fill;
            this.time.Location = new System.Drawing.Point(185, 72);
            this.time.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(135, 36);
            this.time.TabIndex = 9;
            // 
            // peres_count
            // 
            this.peres_count.AutoSize = true;
            this.peres_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.peres_count.Location = new System.Drawing.Point(185, 36);
            this.peres_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.peres_count.Name = "peres_count";
            this.peres_count.Size = new System.Drawing.Size(135, 36);
            this.peres_count.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(0, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(181, 36);
            this.label4.TabIndex = 5;
            this.label4.Text = "Время сортировки";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(0, 36);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(181, 36);
            this.label2.TabIndex = 2;
            this.label2.Text = "Перестановок:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clear_sort_params_btn
            // 
            this.tableLayoutPanel2.SetColumnSpan(this.clear_sort_params_btn, 2);
            this.clear_sort_params_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clear_sort_params_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_sort_params_btn.Location = new System.Drawing.Point(4, 112);
            this.clear_sort_params_btn.Margin = new System.Windows.Forms.Padding(4);
            this.clear_sort_params_btn.Name = "clear_sort_params_btn";
            this.clear_sort_params_btn.Size = new System.Drawing.Size(316, 30);
            this.clear_sort_params_btn.TabIndex = 6;
            this.clear_sort_params_btn.Text = "Очистить";
            this.clear_sort_params_btn.UseVisualStyleBackColor = true;
            this.clear_sort_params_btn.Click += new System.EventHandler(this.clear_sort_params_btn_Click);
            // 
            // eq_count
            // 
            this.eq_count.AutoSize = true;
            this.eq_count.Dock = System.Windows.Forms.DockStyle.Fill;
            this.eq_count.Location = new System.Drawing.Point(185, 0);
            this.eq_count.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.eq_count.Name = "eq_count";
            this.eq_count.Size = new System.Drawing.Size(135, 36);
            this.eq_count.TabIndex = 7;
            // 
            // view
            // 
            this.view.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.view.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.view.Location = new System.Drawing.Point(16, 54);
            this.view.Margin = new System.Windows.Forms.Padding(4);
            this.view.Name = "view";
            this.view.ReadOnly = true;
            this.view.Size = new System.Drawing.Size(668, 524);
            this.view.TabIndex = 3;
            this.view.Text = "";
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Controls.Add(this.import, 0, 2);
            this.tableLayoutPanel3.Controls.Add(this.txt_export, 0, 1);
            this.tableLayoutPanel3.Controls.Add(this.open_gen_win_btn, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(707, 423);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 3;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(324, 142);
            this.tableLayoutPanel3.TabIndex = 4;
            // 
            // import
            // 
            this.import.Dock = System.Windows.Forms.DockStyle.Fill;
            this.import.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.import.Location = new System.Drawing.Point(4, 98);
            this.import.Margin = new System.Windows.Forms.Padding(4);
            this.import.Name = "import";
            this.import.Size = new System.Drawing.Size(316, 40);
            this.import.TabIndex = 2;
            this.import.Text = "Импорт неотсортированного";
            this.import.UseVisualStyleBackColor = true;
            this.import.Click += new System.EventHandler(this.import_Click);
            // 
            // txt_export
            // 
            this.txt_export.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txt_export.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txt_export.Location = new System.Drawing.Point(4, 51);
            this.txt_export.Margin = new System.Windows.Forms.Padding(4);
            this.txt_export.Name = "txt_export";
            this.txt_export.Size = new System.Drawing.Size(316, 39);
            this.txt_export.TabIndex = 1;
            this.txt_export.Text = "Экспорт в txt";
            this.txt_export.UseVisualStyleBackColor = true;
            this.txt_export.Click += new System.EventHandler(this.txt_export_Click);
            // 
            // open_gen_win_btn
            // 
            this.open_gen_win_btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.open_gen_win_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open_gen_win_btn.Location = new System.Drawing.Point(4, 4);
            this.open_gen_win_btn.Margin = new System.Windows.Forms.Padding(4);
            this.open_gen_win_btn.Name = "open_gen_win_btn";
            this.open_gen_win_btn.Size = new System.Drawing.Size(316, 39);
            this.open_gen_win_btn.TabIndex = 0;
            this.open_gen_win_btn.Text = "Генерация значений";
            this.open_gen_win_btn.UseVisualStyleBackColor = true;
            this.open_gen_win_btn.Click += new System.EventHandler(this.open_gen_win_btn_Click);
            // 
            // analysis
            // 
            this.analysis.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.analysis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.analysis.Location = new System.Drawing.Point(707, 29);
            this.analysis.Name = "analysis";
            this.analysis.Size = new System.Drawing.Size(133, 32);
            this.analysis.TabIndex = 5;
            this.analysis.Text = "анализ";
            this.analysis.UseVisualStyleBackColor = false;
            this.analysis.Click += new System.EventHandler(this.analysis_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(1067, 647);
            this.Controls.Add(this.analysis);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.view);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "10 баба";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton bubble_rb;
        private System.Windows.Forms.RadioButton quick_rb;
        private System.Windows.Forms.Button sort_btn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button clear_sort_params_btn;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private System.Windows.Forms.Button import;
        private System.Windows.Forms.Button txt_export;
        private System.Windows.Forms.Button open_gen_win_btn;
        private System.Windows.Forms.Label time;
        private System.Windows.Forms.Label peres_count;
        private System.Windows.Forms.Label eq_count;
        private System.Windows.Forms.RichTextBox view;
        private System.Windows.Forms.Button analysis;
    }
}

