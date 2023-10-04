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
    public partial class MainForm : Form
    {
        String memo_1 = "";

        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void set_cal()
        {
            String temp_hold;

            temp_hold = textBox1.Text;
            memo_1 = Convert.ToDouble(temp_hold);
            label1.Text = memo_1;
        }

        private void plus_butt_Click(object sender, EventArgs e)
        {

        }

        private void minus_butt_Click(object sender, EventArgs e)
        {

        }

        private void mul_butt_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void minus_butt_Click_1(object sender, EventArgs e)
        {

        }
    }
}
