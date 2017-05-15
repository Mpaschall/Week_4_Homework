using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_18
{
    public partial class Form1 : Form
    {
        double num = 0.00;
        double orderTotal = 0.00;
        string item = "";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            priceLabel.Text = "0.00";
            num = Convert.ToDouble(textBox1.Text);
            if (comboBox1.Text == "Dozen eggs - $1.90")
            {
                for (int i = 0; i < num; i++)
                {
                    listBox1.Items.Add("Dozen eggs - $1.90");
                }
                MessageBox.Show(num + " dozen eggs added to cart");
            }
            else if (comboBox1.Text == "Quart milk - $1.47")
            {
                for (int i = 0; i < num; i++)
                {
                    listBox1.Items.Add("Quart milk - $1.47");
                   
                }
                MessageBox.Show(num + " Quart of milk added to cart");
            }
            else if (comboBox1.Text == "Loaf bread - $1.90")
            {
                for (int i = 0; i < num; i++)
                {
                    listBox1.Items.Add("Loaf bread - $1.90");
                }
                MessageBox.Show(num + " Loaf of bread added to cart");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Dozen eggs - $1.90");
            comboBox1.Items.Add("Quart milk - $1.47");
            comboBox1.Items.Add("Loaf bread - $1.90");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < listBox1.Items.Count; i++)
            {
               listBox1.SetSelected(i, true);
                if (listBox1.SelectedItem.ToString() == "Dozen eggs - $1.90")
                {
                    orderTotal += 1.90;
                }
                else if (listBox1.SelectedItem.ToString() == "Quart milk - $1.47")
                {
                    orderTotal += 1.47;
                }
                else if (listBox1.SelectedItem.ToString() == "Loaf bread - $1.90")
                {
                    orderTotal += 1.90;
                }
            }
            priceLabel.Text = orderTotal.ToString();
        }
    }
}
