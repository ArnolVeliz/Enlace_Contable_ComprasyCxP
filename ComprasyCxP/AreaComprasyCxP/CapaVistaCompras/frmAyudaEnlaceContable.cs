﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaVistaCompras
{
    public partial class frmAyudaEnlaceContable : Form
    {
        public frmAyudaEnlaceContable()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Help.ShowHelp(this, "ayudaEnlaceContable/ayudaEnlaceContabilidad.chm", "ManualDeUsuarioEnlaceContable.html");
        }
    }
}
