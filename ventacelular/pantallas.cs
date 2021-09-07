using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ventacelular
{
    public partial class pantallas : Form
    {
        public pantallas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de añadir a compra?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada!", "UNONU Movile UR3!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (m == DialogResult.No)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (m == DialogResult.Cancel)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de añadir a compra?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada!", "UNONU Movile UR3!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (m == DialogResult.No)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (m == DialogResult.Cancel)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult m = MessageBox.Show("¿Estas seguro de añadir a compra?", "¿Confirmar compra?", MessageBoxButtons.YesNoCancel);
            if (m == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada!", "UNONU Movile UR3!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            if (m == DialogResult.No)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (m == DialogResult.Cancel)
            {
                MessageBox.Show("Haz cancelado tu compra!", "Compra cancelada", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }
    }
}