using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TriunghiVarfuriDinMultime
{
    /// <summary>
    /// se da o multime de puncte in plan. sa se determine triunghiul de arie minima
    /// ale carui varfuri sa faca parte din multimea data
    /// </summary>
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Random rnd = new Random();
            Pen p = new Pen(Color.Black, 2), p1 = new Pen(Color.Red, 2);
            Graphics g = e.Graphics;

            int n;
            n = rnd.Next(3,20);

            int[] x = new int[n];
            int[] y = new int[n];

            int i,j,k;
            for(i=0;i<n;i++)
            {
                x[i] = rnd.Next(200);
                y[i] = rnd.Next(200);

                g.DrawEllipse(p, x[i], y[i], 2, 2);
            }

            double arie, arieMinima=double.MaxValue;

            int x1=0, x2=0, x3=0, y1=0, y2=0, y3=0;
        
            for(i=0;i<n-2;i++)
                for(j=i+1;j<n-1;j++)
                    for(k=j+1;k<n;k++)
                    {
                        arie = 0.5 *( Math.Abs(x[i] * y[j] + x[i] * y[k] + x[k] * y[i] - x[k] * y[j] - x[i] * y[k] - x[j] * y[i]));
                        if (arie<arieMinima)
                        {
                            arieMinima = arie;
                            x1 = x[i]; x2 = x[j]; x3 = x[k];
                            y1 = y[i]; y2 = y[j]; y3 = y[k];
                        }
                    }

            Point point1 = new Point(x1, y1);
            Point point2 = new Point(x2, y2);
            Point point3 = new Point(x3, y3);

            Point[] points = { point1, point2, point3 };

            e.Graphics.DrawPolygon(p1, points);
        }
    }
}
