using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laborator_7
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
            mylab.Text = "Punctele eliminate sunt: P1(60, 240), P7(170, 240)";
            mylab.Location = new Point(10, 10);
            mylab.AutoSize = true;
            mylab.Font = new Font("Arial", 12);
            mylab.ForeColor = Color.Black;
            mylab.Padding = new Padding(6);

            // Adding this control to the form
            this.Controls.Add(mylab);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawEllipse(new Pen(Color.Black), 60, 240, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 30, 270, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 150, 180, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 240, 270, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 30, 90, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 180, 210, 2, 2);
            e.Graphics.DrawEllipse(new Pen(Color.Black), 170, 240, 2, 2);

            e.Graphics.DrawLine(new Pen(Color.Red), 30, 270, 240, 270);
            e.Graphics.DrawLine(new Pen(Color.Red), 240, 270, 180, 210);
            e.Graphics.DrawLine(new Pen(Color.Red), 180, 210, 150, 180);
            e.Graphics.DrawLine(new Pen(Color.Red), 150, 180, 30, 90);
            e.Graphics.DrawLine(new Pen(Color.Red), 30, 90, 30, 270);
        }
    }
}
