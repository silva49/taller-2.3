﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller2._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnazul_Click(object sender, EventArgs e)
        {
            BackColor = Color.Blue;
        }

        private void btnrojo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Red;

        }

        private void btnverde_Click(object sender, EventArgs e)
        {
            BackColor = Color.Green;

        }

        private void btnamarillo_Click(object sender, EventArgs e)
        {
            BackColor = Color.Yellow;

        }

        private void btncafe_Click(object sender, EventArgs e)
        {
            BackColor = Color.Salmon;

        }
    }
}
