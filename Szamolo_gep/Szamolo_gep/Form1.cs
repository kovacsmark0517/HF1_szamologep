using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


    namespace Szamolo_gep
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        public void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        public void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        public void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        public void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        public void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        public void button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        public void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        public void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        public void button10_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";

        }

        public void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        public void button11_Click(object sender, EventArgs e)
        {
            
        }
        public void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - textBox1.Text.Length);
        }
    }
}
