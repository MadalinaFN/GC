using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_6
{
    public partial class Form1 : Form
    {
        public List<PointF> points = new List<PointF>();
        static int n = 15;

        public Form1()
        {
            InitializeComponent();

            Random r = new Random();

            for (int i = 0; i < n; i++)
            {
                PointF p = new PointF(r.Next() % this.Size.Width - 20, r.Next() % this.Size.Height - 20);
                if (p.X < 20)
                    p.X = 20;
                if (p.Y < 20)
                    p.Y = 20;
                points.Add(p);
            }
        }

        private void Form1_Paint_1(object sender, PaintEventArgs e)
        {
            foreach (PointF p in points)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Black), p.X - 2, p.Y - 2, 2, 2);
            }
            Jarvis.AlgoritmulJarvis(points, e);
            //Graham.ScanareGraham(points, e);
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
