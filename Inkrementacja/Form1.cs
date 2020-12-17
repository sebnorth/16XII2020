using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inkrementacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 1;

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = $"x= {x}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.Text += $"{x++}\n";
            label1.Text = $"x= {x}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = "";
            richTextBox2.Text = "";
            x = 1;
            label1.Text = $"x= {x}";
        }
    }
}
