﻿using System;
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
    }
}
