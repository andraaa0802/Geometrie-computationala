using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _9Martie_2
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
            Pen p = new Pen(Color.Green, 3), p1=new Pen(Color.Blue, 3);
            Random r = new Random();
            int n = r.Next(100);
            float d = r.Next(1, Math.Min(panel1.Width, panel1.Height) - 10);
            float raza = 1;
            float qx = r.Next(50, panel1.Width - 50);
            float qy = r.Next(50, panel1.Height - 50);
            g.DrawEllipse(p, qx - raza, qy - raza, raza * 2, raza * 2);
            p = new Pen(Color.Black, 3);
            for (int i = 0; i < n; i++)
            {
                float x = r.Next(10, panel1.Width);
                float y = r.Next(10, panel1.Height);
                float dist = (float)Math.Sqrt(Math.Pow(qx - x, 2) + Math.Pow(qy - y, 2));
                if (dist < d)
                    g.DrawEllipse(p1, x - raza, y - raza, raza * 2, raza * 2);
                else
                    g.DrawEllipse(p, x - raza, y - raza, raza * 2, raza * 2);

            }
            
        }
    }
}
