using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9_17
{
    public partial class Form1 : Form
    {
        int numCoins = 0;
        int headCount = 0;
        int result = 0;
        int totalToss = 0;
        string totalRes = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numCoins = Convert.ToInt32(textBox1.Text);
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < numCoins; j++)
                {
                    result = rnd.Next(2);
                    if (result == 0)
                    {
                        headCount++;
                    }
                    else
                    {

                    }
                    totalToss++;
                    
                }
            }
            totalRes = ("" + headCount + " / " + totalToss);
            MessageBox.Show("" + totalRes);

        }
    }
}
