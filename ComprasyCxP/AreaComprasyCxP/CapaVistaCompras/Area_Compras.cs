using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaVistaSeguridadHSC;
using CapaVista;
using CapaVistaReporte;

namespace CapaVistaCompras
{
    public partial class Area_Compras : Form
    {        

        public Area_Compras()
        {
            InitializeComponent();
        }

        private void Area_Compras_Load(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            {
                this.Close();
            }
        }

        private void cerrarSesiónToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLoginHSC form = new frmLoginHSC();
            if (form.ShowDialog() == DialogResult.OK)
            {
                txtusuario.Text = form.usuario();
                this.Show();
            }
            else
            { this.Close();
                txtusuario.Text = "";
                this.Close();
            }

        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void consultasInteligentesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menuconsultas formulario = new menuconsultas();
            formulario.Show();
        }

        private void reporteadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ReporteadorAdmin formulario = new ReporteadorAdmin();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void moduloDeSeguridadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMIDSeguridad formulario = new frmMIDSeguridad();
            formulario.Show();
        }

        private void ingresarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarOrdenDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void facturasEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarFacturasEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarFacturasEncabezadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ingresarFacturaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscarFacturaDetalleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

    

        private void ordenesDeCompraYFacturasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ordenesDeCompraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void ayudasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trasladoDeProductosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudasTP/AyudaTP.chm", "/Traslado-de-Productos.html/ ");
        }

        private void trasladoDeProductoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void trasladoDeProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void enlaceContableToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void enlaceContableToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmEnlaceContableCompras formulario = new frmEnlaceContableCompras();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void enlaceContableToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmAyudaEnlaceContable formulario = new frmAyudaEnlaceContable();
            formulario.MdiParent = this;
            formulario.Show();
        }

        private void enlaceContableToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            frmReporteEnlaceContable formulario = new frmReporteEnlaceContable();
            formulario.MdiParent = this;
            formulario.Show();
        }
    }
}
