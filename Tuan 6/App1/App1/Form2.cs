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
    public partial class Linh2 : Form
    {
        public Linh2()
        {
            InitializeComponent();
        }
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Font f = new Font("Arial", 30);
            SolidBrush a = new SolidBrush(Color.Blue);
            SolidBrush b = new SolidBrush(Color.Yellow);
            SolidBrush c = new SolidBrush(Color.Black);
            SolidBrush d = new SolidBrush(Color.Green);
            SolidBrush t = new SolidBrush(Color.Red);


            Pen round = new Pen(a, 3);
            Rectangle tron = new Rectangle(200, 200, 60, 60);
            g.DrawEllipse(round, tron);

            Pen round2 = new Pen(b, 3);
            Rectangle tron2 = new Rectangle(235, 230, 60, 60);
            g.DrawEllipse(round2, tron2);

            Pen round3 = new Pen(c, 3);
            Rectangle tron3 = new Rectangle(270, 200, 60, 60);
            g.DrawEllipse(round3, tron3);

            Pen round4 = new Pen(d, 3);
            Rectangle tron4 = new Rectangle(305, 230, 60, 60);
            g.DrawEllipse(round4, tron4);

            Pen round5 = new Pen(t, 3);
            Rectangle tron5 = new Rectangle(340, 200, 60, 60);
            g.DrawEllipse(round5, tron5);

        }

    }
}
