﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ventacelular
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bATERÍASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmbaterias f = new frmbaterias();
            f.MdiParent = this;
            f.Text = "baterias";
            f.Show();
        }

        private void pLACASToolStripMenuItem_Click(object sender, EventArgs e)
        {
            placas f = new placas();
            f.MdiParent = this;
            f.Text = "baterias";
            f.Show();
        }
    }
}