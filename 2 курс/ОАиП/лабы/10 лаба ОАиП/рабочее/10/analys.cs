using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _10
{
    public partial class analys : Form
    {
        private int[] an_params = { 10, 100, 1000, 10000 };
        private static int eqs = 0;
        public analys()
        {
            InitializeComponent();
        }

        public string BubbleSort(int[] counts)
        {
            int eq = 0;
            int peres = 0;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int write = 0; write < counts.Length; write++)
            {
                for (int sort = 0; sort < counts.Length - 1; sort++)
                {
                    eq++;
                    if (counts[sort] > counts[sort + 1])
                    {
                        int temp = counts[sort + 1];
                        counts[sort + 1] = counts[sort];
                        counts[sort] = temp;

                        peres++;
                    }
                }
            }

            sw.Stop();
            var rez = sw.Elapsed;
            string formated_rez = $"С: {eq}" + $" П: {peres} " + String.Format("{0:00}:{1:00}:{2:000}", rez.Minutes, rez.Seconds, rez.Milliseconds);
            // dataGrid.Rows.Add(new string[] {counts.Length.ToString(), formated_rez, });
            return formated_rez;

        }

        public string QuickSort(int[] counts)
        {

            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();

            counts = QuickSorting(counts);
            var rez = sw.Elapsed;

            string formated_rez = eqs.ToString() + " " + String.Format("{0:00}:{1:00}:{2:000}", rez.Minutes, rez.Seconds, rez.Milliseconds);


            return formated_rez;
        }

        public int[] QuickSorting(int[] counts)
        {
            if (counts.Length == 1 || counts.Length == 0) return counts;
            int op_ind = counts.Length / 2;

            int op_el = counts[op_ind];

            List<int> lower = new List<int>();
            List<int> eq = new List<int>();
            List<int> upper = new List<int>();

            foreach (int i in counts)
            {
                eqs++;
                if (i < op_el)
                {
                    lower.Add(i);
                }
                else if (i > op_el)
                {
                    upper.Add(i);
                }
                else
                {
                    eq.Add(i);
                }
            }


            int[] rez = QuickSorting(lower.ToArray()).Concat(eq.ToArray()).Concat(QuickSorting(upper.ToArray())).ToArray();
            return rez;
        }


        private int[] gen_counts(int len)
        {
            Random random = new Random();
            int[] counts = new int[len];
            for (int i = 0; i < len; i++)
            {
                int new_count = random.Next(1, 100);
                counts[i] = new_count;
            }

            return counts;
        }

        private void an_start_Click(object sender, EventArgs e)
        {
            foreach (int param in an_params)
            {
                int[] posl = gen_counts(param);

                string bub_sort_rez = BubbleSort(posl);

                string q_sort_rez = QuickSort(posl);
                dataGrid_bub.Rows.Add(new string[] { param.ToString(), bub_sort_rez });
                dataGridView_q.Rows.Add(new string[] { param.ToString(), q_sort_rez });


            }
        }

        private void dataGrid_bub_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void an_start_Click_1(object sender, EventArgs e)
        {
            foreach (int param in an_params)
            {
                int[] posl = gen_counts(param);

                string bub_sort_rez = BubbleSort(posl);

                string q_sort_rez = QuickSort(posl);
                dataGrid_bub.Rows.Add(new string[] { param.ToString(), bub_sort_rez });
                dataGridView_q.Rows.Add(new string[] { param.ToString(), q_sort_rez });


            }
        }
    }
}
