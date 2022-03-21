using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
/// Se da o multime de n puncte in plan. Sa se determine dreptunghiul de arie minima care 
/// sa contina toate punctele date
/// </summary>
namespace DreptunghiArieMinima
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Red, 3), p1 = new Pen(Color.Black, 3);
            Random rnd = new Random();
            int n, i;
            n = rnd.Next(100);
            int[] x = new int[n];
            int[] y = new int[n];
            for (i = 0; i < n; i++)
            {
                x[i] = rnd.Next(300);
                y[i] = rnd.Next(300);
                g.DrawEllipse(p1, x[i], y[i], 1, 1);
            }
            g.DrawRectangle(p, x.Min(), y.Min(), x.Max(), y.Max());
        }
    }
}
