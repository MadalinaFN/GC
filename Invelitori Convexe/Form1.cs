using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Invelitori_Convexe
{
    public partial class Form1 : Form
    {
        public List<PointF> points = new List<PointF>();
        static int n = 20;

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

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            foreach (PointF p in points)
            {
                e.Graphics.DrawEllipse(new Pen(Color.Black), p.X - 2, p.Y - 2, 2, 2);
            }

            /*e.Graphics.DrawEllipse(new Pen(Color.Black), 0, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 150, 250, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 0, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 500, 100, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 550, 200, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 700, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 500, 400, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 300, 600, 2, 2);

            e.Graphics.DrawLine(new Pen(Color.Red), 0, 300, 200, 0);
            e.Graphics.DrawLine(new Pen(Color.Red), 200, 0, 500, 100);
            e.Graphics.DrawLine(new Pen(Color.Red), 500, 100, 700, 300);
            e.Graphics.DrawLine(new Pen(Color.Red), 700, 300, 300, 600);
            e.Graphics.DrawLine(new Pen(Color.Red), 300, 600, 0, 300);*/

            AlgSlab.AlgoritmulSlab(points, e);
            //SuperiorInferior.SepararePlanuri(points, e);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
