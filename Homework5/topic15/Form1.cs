using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace topic15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (graphics == null) graphics = this.CreateGraphics();
            drawCayleyTree(10, 400, 200, 100, -Math.PI / 2);
        }

        private Graphics graphics;

        void drawCayleyTree(int n,double x0,double y0,double leng,double th)
        {
            if (n == 0) return;
            int k = (int)this.numericUpDown1.Value;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);
            double x2 = x0 + leng * k * Math.Cos(th);
            double y2 = y0 + leng * k * Math.Sin(th);

            drawLine(x0, y0, x1, y1, x2, y2);

            drawCayleyTree(n - 1, x1, y1, (double.Parse(trackBar1.Value.ToString())) / 10 * leng, th + double.Parse(textBox1.Text));
            drawCayleyTree(n - 1, x2, y2, (double.Parse(trackBar2.Value.ToString()))/10 * leng, th - double.Parse(textBox2.Text));


        }
        void drawLine(double x0,double y0,double x1,double y1,double x2, double y2)
        {
            Pen myPen = new Pen(Color.Red, float.Parse(comboBox1.Text.ToString()));
            graphics.DrawLine(myPen, (int)x0, (int)y0, (int)x1, (int)y1);
            graphics.DrawLine(myPen, (int)x0, (int)y0, (int)x2, (int)y2);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();
            this.BackColor = this.colorDialog1.Color;
        }
    }
}
