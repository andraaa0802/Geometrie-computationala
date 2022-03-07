using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2Martie
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int[] x = new int[100];
            int[] y = new int[100];
            Random rnd = new Random();
            int i, n;
            
            n = rnd.Next(25);
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black, 2);
            for (i = 0; i < n; i++)
            {
                x[i] = rnd.Next(100);
                y[i] = rnd.Next(100);
                g.DrawEllipse(p, x[i], y[i], 3, 3);
            }
        }
    }
}
