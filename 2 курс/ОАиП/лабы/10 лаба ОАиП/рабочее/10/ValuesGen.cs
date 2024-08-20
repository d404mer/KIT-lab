using System;
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
    public partial class ValuesGen : Form
    {
        Form1 parent;
        public ValuesGen(Form1 parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void gen_btn_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            string st = "";
            for (int i = 0; i <= inp_count.Value; i++)
            {
                int new_count = random.Next(1, 100);
                st += new_count.ToString() + " ";
            }
            parent.values_add(st);
        }
    }
}
