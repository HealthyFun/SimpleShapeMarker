using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleShapeMarker
{
    public partial class SimpleShapeMarker : Form

    {
        public SimpleShapeMarker()
        {
            InitializeComponent();
        
            this.BackColor = Color.White;
            Button button1 = new Button();
            button1.Text = "Let's draw!";
            button1.Location = new Point(110, 10);
            button1.Size = new Size(70, 40);
            button1.BackColor = Color.LightGray;
            button1.Click += new System.EventHandler(button1_Click);

            this.Controls.Add(button1);

        }

        void button1_Click(object o, EventArgs e)
        {
            DrawSomeShape();
        }


        void DrawSomeShape()
        {
            Graphics g = this.CreateGraphics();

            Pen greenPen = new Pen(Color.Green, 3);
            Pen redPen = new Pen(Color.Red, 15);

            g.DrawLine(greenPen, 140, 170, 140, 230);
            g.DrawRectangle(greenPen, 100, 60, 50, 60);
            g.DrawPie(greenPen, 100, 100, 100, 60, 10, 25);
            g.DrawPie(redPen, 300, 100, 150, 80, 10, 75);
            g.DrawPie(redPen, 400, 150, 100, 60, 40, 85);
            g.DrawEllipse(redPen, 200, 150, 80, 60);

            g.Dispose();
        }

        static void Main()
        {
            Application.Run(new SimpleShapeMarker());
        }

        //SimpleShapeMarker

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
