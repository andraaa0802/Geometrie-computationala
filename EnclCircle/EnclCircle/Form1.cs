using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EnclCircle
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
                Pen p = new Pen(Color.Red, 3), p1 = new Pen(Color.Black, 3), p2 = new Pen(Color.Green, 3);
                Random rnd = new Random();
                int n, i, x_centru, y_centru;
                double dist_puncte;
                float raza;
                n = rnd.Next(100);
                int[] x = new int[n];
                int[] y = new int[n];
                for (i = 0; i < n; i++)
                {
                    x[i] = rnd.Next(100, 300);
                    y[i] = rnd.Next(100, 300);
                    g.DrawEllipse(p1, x[i], y[i], 1, 1);
                }


                dist_puncte = Math.Sqrt((x.Max() - x.Min()) * (x.Max() - x.Min()) + (y.Max() - y.Min()) * (y.Max() - y.Min()));

                raza = Convert.ToSingle(dist_puncte / 2);

                x_centru = (x.Min() + x.Max()) / 2;
                y_centru = (y.Min() + y.Max()) / 2;

                float X = x_centru - raza;
                float Y = y_centru - raza;
                float width = 2 * raza;
                float height = 2 * raza;

                g.DrawEllipse(p2, X, Y, width, height);


            }
        }
    }

