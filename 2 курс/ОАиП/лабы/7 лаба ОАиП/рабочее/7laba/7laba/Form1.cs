using _7laba.UserControls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7laba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UC_HOME uc = new UC_HOME();
            addUserControl(uc);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            panel_container.Controls.Clear();
            panel_container.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UC_2laba uc = new UC_2laba();
            addUserControl(uc);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_HOME uc = new UC_HOME();
            addUserControl(uc);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UC_3laba uc = new UC_3laba();
            addUserControl(uc);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UC_4laba uc = new UC_4laba();
            addUserControl(uc);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UC_5laba uc = new UC_5laba();
            addUserControl(uc);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            UC_6laba uc = new UC_6laba();
            addUserControl(uc);
        }

        private void label1_Click(object sender, EventArgs e)
        {
            UC_HOME uc = new UC_HOME();
            addUserControl(uc);
        }
    }
}
