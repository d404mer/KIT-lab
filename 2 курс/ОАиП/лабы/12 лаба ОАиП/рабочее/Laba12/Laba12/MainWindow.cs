using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba12
{
    public partial class MainWindow : Form
    {
        private AppDbContext context;
        private DepartamentClass dp;
        public MainWindow(AppDbContext context, DepartamentClass dp)
        {
            InitializeComponent();
            this.context = context;
            this.dp = dp;

            dp.Emps = context.Emps.Where
        }
    }
}
