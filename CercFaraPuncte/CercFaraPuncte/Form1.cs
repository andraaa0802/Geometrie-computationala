using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CercFaraPuncte
{
/// <summary>
/// se dau n puncte in plan si un punct q. sa se determine cercul cu centru in q de raza
/// maxima care sa nu contina niciun punct din multimea data
/// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Green, 3);
            Random r = new Random();
            int n = r.Next(10);
            float raza = 1;
            float qx = r.Next(50, panel1.Width - 10);
            float qy = r.Next(50, panel1.Height - 10);
            g.DrawEllipse(p, qx - raza, qy - raza, raza * 2, raza * 2);
            p = new Pen(Color.Black, 3);
            float dist_min = panel1.Width;
            for (int i = 0; i < n; i++)
            {
                float x = r.Next(10, panel1.Width);
                float y = r.Next(10, panel1.Height);
                g.DrawEllipse(p, x - raza, y - raza, raza * 2, raza * 2);
                float dist = (float)Math.Sqrt(Math.Pow(qx - x, 2) + Math.Pow(qy - y, 2));
                if (dist_min > dist)
                    dist_min = dist;
            }
            g.DrawEllipse(p, qx - dist_min, qy - dist_min, dist_min * 2, dist_min * 2);
        }
    }
}
