using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_19
{
    public partial class Form1 : Form
    {
        string name = "";
        double num = 0;
        double price = 0;
        double rem = 0;
        double round = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            name = textBox1.Text;
            num = Convert.ToDouble(textBox2.Text);
            price = Convert.ToDouble(textBox3.Text);
            if (num >= 100)
            {
                rem = num % 100;
                round = num / 100;
                total = ((num * price) + (rem * 0.50) + (round * 30));
            }
            else if (num < 100)
            {
                rem = num % 100;
                total = ((num * price) + (rem * 0.50));
            }

            MessageBox.Show("You purchased " + num + " shares of " + name + "\nYour total was : $" + total);
        }
    }
}
