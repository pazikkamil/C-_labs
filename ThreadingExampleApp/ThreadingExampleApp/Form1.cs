using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThreadingExampleApp
{
    public partial class Form1 : Form
    {
        private void DrawRandomPoint()
        {
            System.Threading.Thread.Sleep(2000);
            Random rnd = new Random();
            int x = rnd.Next(0, 400);
            int y = rnd.Next(0, 400);
            var graphics = this.CreateGraphics();

            Pen blackPen = new Pen(Color.Black, 3);
            Point point1 = new Point(x, y);

            Size s = new Size(10, 10);
            Rectangle rect_limit = new Rectangle(point1, s);
            graphics.DrawEllipse(Pens.Red, rect_limit);
            graphics.FillEllipse(Brushes.Blue, rect_limit);
        }
        private void DrawRectangle(int width, int height)
        {
            System.Drawing.Pen myPen = new System.Drawing.Pen(System.Drawing.Color.Red);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.DrawRectangle(myPen, new Rectangle(0, 0, width, height));
            myPen.Dispose();
            formGraphics.Dispose();
        }
        public Form1()
        {
            InitializeComponent();
            Thread th1; 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var graphics = this.CreateGraphics();
            Pen pen = new Pen(Color.FromArgb(255, 0, 0, 0));
            graphics.DrawLine(pen, 20, 10, 300, 100);

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // th = new Thread()
            Thread thread = new Thread(() => DrawRandomPoint());
            thread.Start();
            //DrawRandomPoint();
        }
    

        private void Form1_Shown(object sender, EventArgs e)
        {
            int offset = 150;
            DrawRectangle(this.Width-offset, this.Height-offset);
        }
    }
}
