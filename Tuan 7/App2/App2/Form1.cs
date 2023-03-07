﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFont_Click(object sender, EventArgs e)
        {
            DialogResult kq;
            kq = fdlFont.ShowDialog();
            if (kq == DialogResult.OK)
            {
                richTextBox1.SelectionFont = fdlFont.Font;
                richTextBox1.SelectionColor = fdlFont.Color;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            DialogResult sv;
            sv = saveFile.ShowDialog();
            if(sv == DialogResult.OK)
            {
                Name = saveFile.FileName;
            }

        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            DialogResult op;
            op = openFile.ShowDialog();
            if (op == DialogResult.OK)
            {
              
            }
        }
    }
}
