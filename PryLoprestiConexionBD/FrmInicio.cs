using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryLoprestiConexionBD
{
    public partial class FrmInicio : Form
    {
        public FrmInicio()
        {
            InitializeComponent();
        }

        private void verStockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmStock v = new FrmStock();
            v.ShowDialog();
        }

        private void cargaDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmProductos v = new FrmProductos();
            v.ShowDialog();
        }

        private void contactosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmContacos v = new FrmContacos();
            v.ShowDialog();
        }

    }
}
