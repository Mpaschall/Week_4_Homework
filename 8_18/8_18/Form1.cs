using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_18
{
    public partial class Form1 : Form
    {
        private Font arial = new Font("Arial", 16, FontStyle.Bold);
        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int arialStart = (10);
            g.DrawString("Tomato Soup Co.", arial, Brushes.Red, arialStart, 120);
            Pen clear = new Pen(Color.Transparent, 1);
            Pen black = new Pen(Color.Black, 1);
            g.DrawRectangle(black, 40, 60, 25, 5);
            g.FillRectangle(Brushes.Green, 40, 60, 25, 5);
            g.DrawRectangle(clear, 50, 50, 50, 50);
            g.DrawEllipse(black, 50, 50, 50, 50);
            g.FillEllipse(Brushes.Red, 50, 50, 50, 50);
            base.OnPaint(e);
        }
    }
}
