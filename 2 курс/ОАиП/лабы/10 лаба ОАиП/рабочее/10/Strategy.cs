using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10
{
    public interface ISort
    {
        void Sort(int[] counts);
    }

    public class SortExchange : ISort
    {
        public void Sort(int[] counts)
        {
            int eq = 0;
            int peres = 0;
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            sw.Start();
            for (int write = 0; write < counts.Length; write++)
            {
                for (int sort = 0; sort < counts.Length - 1 - write; sort++)
                {
                    eq++;
                    changer.text_for_txt += $"Обмен {eq}: {counts[sort]} и {counts[sort + 1]}\n";
                    if (counts[sort] > counts[sort + 1])
                    {
                        int temp = counts[sort + 1];
                        counts[sort + 1] = counts[sort];
                        counts[sort] = temp;

                        peres++;
                        changer.text_for_txt += $"Сравнения {peres}: {counts[sort]} и {counts[sort + 1]}, {sort} и {sort + 1}\n";
                        Form1.draw_row(counts, sort, sort + 1);


                    }
                }
            }
            
            sw.Stop();
            var rez = sw.Elapsed;
            string formated_rez = String.Format("{0:00}:{1:00}:{2:000}", rez.Minutes, rez.Seconds, rez.Milliseconds);
            changer.time.Text = formated_rez;
            changer.peres_count.Text = peres.ToString();
            changer.eq_count.Text = eq.ToString();

        }
    }








    public class SortPor : ISort
    {
        static int eqs = 0;
        private int[] global_counts;

        public void Sort(int[] counts)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
            global_counts = counts;
            sw.Start();
            Sorting(counts, 0, counts.Length - 1);
            var rez = sw.Elapsed;

            string formated_rez = String.Format("{0:00}:{1:00}:{2:000}", rez.Minutes, rez.Seconds, rez.Milliseconds);

            changer.time.Text = formated_rez;
            changer.peres_count.Text = "";
            changer.eq_count.Text = eqs.ToString();
        }

        public void Sorting(int[] counts, int left, int right)
        {
            if (left < right)
            {
                int pivotIndex = Partition(counts, left, right);

                Form1.draw_row(global_counts, pivotIndex, pivotIndex);

                Sorting(counts, left, pivotIndex - 1);
                Sorting(counts, pivotIndex + 1, right);
            }
        }

        private int Partition(int[] counts, int left, int right)
        {
            int pivot = counts[right];
            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                eqs++;
                changer.text_for_txt += $"Сравнение {eqs}: {counts[j]} и {pivot}\n";

                if (counts[j] < pivot)
                {
                    i++;
                    Swap(counts, i, j);
                }
            }

            Swap(counts, i + 1, right);

            return i + 1;
        }

        private void Swap(int[] counts, int i, int j)
        {
            int temp = counts[i];
            counts[i] = counts[j];
            counts[j] = temp;

            Form1.draw_row(counts, i, j);
        }

    }
    public class Strategy
    {
        public static int[] array;
        public ISort ContextSort { get; set; }
        public Strategy(ISort _ContextSort)
        {
            ContextSort = _ContextSort;
        }
        public void ExecuteSort(int[] row)
        {
            ContextSort.Sort(row);
        }
    }
}
