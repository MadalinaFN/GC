using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Pen Red = new Pen(Color.Red);
        Pen Green = new Pen(Color.Green);
        Pen Blue = new Pen(Color.Blue);
        Pen Yellow = new Pen(Color.Yellow);
        Pen Black = new Pen(Color.Black);
        Pen Orange = new Pen(Color.Orange);
        Pen Pink = new Pen(Color.Pink);
        Pen Purple = new Pen(Color.Purple);

        Rectangle square = new Rectangle(20, 20, 40, 40);
        Rectangle square1 = new Rectangle(50, 50, 70, 70);
        Rectangle square2 = new Rectangle(60, 60, 150, 150);
        Rectangle square3 = new Rectangle(200, 200, 400, 400);
        Rectangle square4 = new Rectangle(100, 100, 200, 200);
        Rectangle square5 = new Rectangle(250, 250, 350, 350);
        Rectangle square6 = new Rectangle(70, 70, 170, 170);
        Rectangle square7 = new Rectangle(30, 30, 60, 60);

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawRectangle(Red, square);
            g.DrawRectangle(Green, square1);
            g.DrawRectangle(Blue, square2);
            g.DrawRectangle(Yellow, square3);
            g.DrawRectangle(Black, square4);
            g.DrawRectangle(Orange, square5);
            g.DrawRectangle(Pink, square6);
            g.DrawRectangle(Purple, square7);

            Point p1 = new Point(60, 60);
            Point p2 = new Point(210, 210);
            Point p3 = new Point(210, 60);
            Point p4 = new Point(60, 210);
            Point p5 = new Point(60, 135);
            Point p6 = new Point(210, 135);
            Point p7 = new Point(135, 60);
            Point p8 = new Point(135, 210);

            g.DrawLine(Pens.Red, p1, p2);
            g.DrawLine(Pens.Red, p3, p4);
            g.DrawLine(Pens.Red, p5, p6);
            g.DrawLine(Pens.Red, p7, p8);
        }
    }
}
