using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class Form1 : Form
    {

        int[] counts;

        Strategy sort_context;
        public Form1()
        {
            InitializeComponent();

            changer.view = view;
            changer.eq_count = eq_count;
            changer.time = time;
            changer.peres_count = peres_count;

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clear_sort_params_btn_Click(object sender, EventArgs e)
        {
            
            
            eq_count.Text = "";
            time.Text = "";
            peres_count.Text = "";

            view.Text = "";
        }

        private void open_gen_win_btn_Click(object sender, EventArgs e)
        {
            ValuesGen v_gen = new ValuesGen(this);
            v_gen.Show();
        }

        public void values_add(string row) {
            view.Text = row;

            string[] st_counts = row.Split(' ');
            counts = new int[st_counts.Length - 1];

            for (int i = 0; i < st_counts.Length - 1; i++)
            {
                counts[i] = int.Parse(st_counts[i]);
            }

        }

        private void sort_btn_Click(object sender, EventArgs e)
        {
            if (bubble_rb.Checked)
            {
                sort_context = new Strategy(new SortExchange());
            }
            else
            {
                sort_context = new Strategy(new SortPor());
            }

            start_sort();
        }

        public static void draw_row(int[] row, int ch_ind_1, int ch_ind_2){
            string st_row = "";
            for (int i = 0; i < row.Length; i++)
            {
                
                if (i == ch_ind_1 || i == ch_ind_2)
                {
                    st_row += "["  + row[i].ToString() + "]";
                }
                else
                {
                    st_row += row[i].ToString();
                }

                st_row += " ";
            }
            changer.text_for_txt += st_row + "\n";
            changer.view.Text += "\n" + st_row;
        }

        private void start_sort()
        {
            sort_context.ExecuteSort(counts);
        }

        private void import_Click(object sender, EventArgs e)
        {
            string text;
            var ofd = new OpenFileDialog();
            ofd.Filter = "Text Files(*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                using (var reader = new StreamReader(ofd.FileName))
                    text = reader.ReadToEnd();
            }
            else return;

            string[] stArr = text.Split(' ');

            int[] intArr = new int[stArr.Length];

            for (int i = 0; i < intArr.Length; i++)
            {
                int val;
                if (!int.TryParse(stArr[i], out val))
                {
                    MessageBox.Show("Ошибка");
                    return;
                }

                intArr[i] = val;

            }
            counts = intArr;
            changer.view.Text = text;
        }

        private void txt_export_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog();
            sfd.Filter = "Text Files(*.txt)|*.txt";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                using (var writer = new StreamWriter(sfd.FileName))
                    writer.Write(changer.text_for_txt);
            }

        }

        private void analysis_Click(object sender, EventArgs e)
        {
            analys an = new analys();
            an.Show();
        }
    }


    static class changer
    {
        public static Label time;
        public static Label peres_count;
        public static Label eq_count;

        public static RichTextBox view;

        public static string text_for_txt = "";
    }
}
