using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8_14
{
    public partial class ChessBoard : Form
    {
        public ChessBoard()
        {
            InitializeComponent();
            Size = new Size(400, 400);
            Text = "Chess";
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            int x = 10;
            int y = 10;
            int z = 10;
            int h = 10;

            Graphics g = e.Graphics;
            Pen black = new Pen(Color.Black, 1);
            for (int i = 0; i < 64; i++)
            {
                g.DrawRectangle(black, 10, 10, 80, 80);
                while (y <= 80)
                {
                    g.DrawRectangle(black, x, y, z, h);
                g.FillRectangle(Brushes.Black, x, y, z, h);
                base.OnPaint(e);
                x = x + 20;   
                    if (x == 90 || x == 100)
                    {
                        y = y + 10;
                        if (y == 20 || y == 40 || y == 60 || y == 80)
                        {
                            x = 20;
                        }
                        else
                        {
                            x = 10;
                        }
                    }
                }
            }
        }

        public static void main()
        {
            Application.Run(new ChessBoard());
        }
    }
}
