using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
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

        private void chuotvaoform(object sender, EventArgs e)
        {
            this.BackColor = Color.Blue;
        }

        private void chuotroiform(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }

        private void Nhapchuot(object sender, MouseEventArgs e)
        {
            this.BackColor = Color.Aqua;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You have just clicked", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult kq;
            kq = MessageBox.Show("Ban muon dong cua so nay khong", "Exit", MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if(kq == DialogResult.No)
            {
                e.Cancel = true;
            } else e.Cancel = false;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 16);
            SolidBrush b = new SolidBrush(Color.Red);
            Point p = new Point(50, 100);
            g.DrawString("Nothing gonna chaange", f, b, p);

            Pen cn = new Pen(b);
            Rectangle r = new Rectangle(50, 70, 100, 125);
            g.DrawRectangle(cn, r);

            Pen round = new Pen(b);
            Rectangle tron = new Rectangle(200, 200, 60, 60);
            g.DrawEllipse(round, tron);

        }
    }
}
