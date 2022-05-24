using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CercContinandToatePunctele
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// se da o multime de puncte in plan; sa se determine cercul de arie minima care
        /// sa contina toate punctele in interior
        /// </summary>
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Random rnd = new Random();
            Pen p = new Pen(Color.Black, 2), p1 = new Pen(Color.Red, 2), p2 = new Pen(Color.Blue, 2);

            int n;
            n = rnd.Next(20);
            int[] x = new int[n];
            int[] y = new int[n];

            int i;
            for (i=0;i<n;i++)
            {
                x[i] = rnd.Next(300);
                y[i] = rnd.Next(300);
                g.DrawEllipse(p, x[i],y[i],2,2);
            }
            Rectangle rect = new Rectangle(x.Min(), y.Min(), x.Max(), y.Max());
            g.DrawRectangle(p1, x.Min(), y.Min(), x.Max(), y.Max());
            g.DrawEllipse(p2, rect);
        }
    }
}
