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
    }
}
