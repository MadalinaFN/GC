using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Label mylab = new Label();
            mylab.Text = "Aria = 71250"; //116250
            mylab.Location = new Point(600, 300); //500,300
            mylab.AutoSize = true;
            mylab.Font = new Font("Times New Roman", 15);
            mylab.ForeColor = Color.Black;
            mylab.Padding = new Padding(6);

            this.Controls.Add(mylab);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            /*e.Graphics.DrawEllipse(new Pen(Color.Black), 50, 0, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 100, 100, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 0, 350, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 450, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 350, 350, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 550, 200, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 100, 400, 2, 2);

            e.Graphics.DrawLine(new Pen(Color.Red), 50, 0, 100, 100);
            e.Graphics.DrawLine(new Pen(Color.Red), 100, 100, 550, 200);
            e.Graphics.DrawLine(new Pen(Color.Red), 550, 200, 350, 350);
            e.Graphics.DrawLine(new Pen(Color.Red), 350, 350, 200, 450);
            e.Graphics.DrawLine(new Pen(Color.Red), 200, 450, 100, 400);
            e.Graphics.DrawLine(new Pen(Color.Red), 100, 400, 0, 350);
            e.Graphics.DrawLine(new Pen(Color.Red), 0, 350, 50, 0);*/

            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 200, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 250, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 300, 200, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 350, 200, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 450, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 550, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 300, 550, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 300, 450, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 350, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 300, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 300, 250, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 200, 200, 2, 2);

            e.Graphics.DrawLine(new Pen(Color.Blue), 200, 200, 300, 200);
            e.Graphics.DrawLine(new Pen(Color.Blue), 300, 200, 300, 250);
            e.Graphics.DrawLine(new Pen(Color.Blue), 300, 250, 350, 200);
            e.Graphics.DrawLine(new Pen(Color.Blue), 350, 200, 450, 300);
            e.Graphics.DrawLine(new Pen(Color.Blue), 450, 300, 550, 300);
            e.Graphics.DrawLine(new Pen(Color.Blue), 550, 300, 300, 550);
            e.Graphics.DrawLine(new Pen(Color.Blue), 300, 550, 300, 450);
            e.Graphics.DrawLine(new Pen(Color.Blue), 300, 450, 200, 350);
            e.Graphics.DrawLine(new Pen(Color.Blue), 200, 350, 250, 300);
            e.Graphics.DrawLine(new Pen(Color.Blue), 250, 300, 200, 300);
            e.Graphics.DrawLine(new Pen(Color.Blue), 200, 300, 200, 200);
        }
    }
}
