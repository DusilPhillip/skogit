using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int cis = Convert.ToInt32(textBox1.Text);
            int fak = 1;
            for (int i = 2; i <= cis; i++)
            {
                fak *= i;
            }
            label1.Text = fak.ToString();
        }
    }
}
