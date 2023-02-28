using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App1
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 16);
            SolidBrush a = new SolidBrush(Color.Red);

            Pen head = new Pen(a);
            Brush h1 = new SolidBrush(Color.Red);
            Rectangle h = new Rectangle(280, 40, 150, 75);
            g.DrawRectangle(head, h);
            g.FillRectangle(h1, h);



        }
    }
}
