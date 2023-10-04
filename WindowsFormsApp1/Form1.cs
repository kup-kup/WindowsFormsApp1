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
        Double memo_1, memo_2, ans;
        String temp_hold, type;

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
            memo_label.Text = memo_label.Text + " " + main_textbox.Text;
            memo_2 = Convert.ToDouble(main_textbox.Text);

            switch (type)
            {
                case "+": ans = memo_1 + memo_2; break;
                case "-": ans = memo_1 - memo_2; break;
                case "x": ans = memo_1 * memo_2; break;
                case "/": ans = memo_1 / memo_2; break;
            }

            main_textbox.Text = Convert.ToString(ans);
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        void set_cal(String type)
        {
            temp_hold = main_textbox.Text;
            memo_1 = Convert.ToDouble(temp_hold);
            memo_label.Text = temp_hold + type;
            main_textbox.Text = "";
        }

        private void plus_butt_Click(object sender, EventArgs e)
        {
            set_cal(" +");
            type = "+";
        }

        private void minus_butt_Click_1(object sender, EventArgs e)
        {
            set_cal(" -");
            type = "-";
        }

        private void cleat_butt_Click(object sender, EventArgs e)
        {
            main_textbox.Text = "";
            memo_label.Text = "";
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void mul_butt_Click(object sender, EventArgs e)
        {
            set_cal(" x");
            type = "x";
        }

        private void div_butt_Click(object sender, EventArgs e)
        {
            set_cal(" /");
            type = "/";
        }
    }
}
