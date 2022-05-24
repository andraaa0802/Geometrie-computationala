using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Desenare_poligon
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Point> MyCircles = new List<Point>();
        private void panel1_Click(object sender, EventArgs e)
        {
            var cursorPosition = panel1.PointToClient(Cursor.Position);
            MyCircles.Add(cursorPosition);
            panel1.Refresh();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.Black, 3);
            Pen pen = new Pen(Color.Red, 3);
            foreach (var item in MyCircles)
            {
                e.Graphics.DrawEllipse(p, item.X, item.Y, 3, 3);
            }
            if (MyCircles.Count >= 2)
            {
                Point x, p1, p2;
                p1 = x = MyCircles[0];
                for (int i = 1; i < MyCircles.Count; i++)
                {
                    p2 = MyCircles[i];
                    e.Graphics.DrawLine(pen, p1, p2);
                    p1 = p2;
                }
                e.Graphics.DrawLine(pen, p1, x);
            }
        }
    }
}
