using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App_Restaurante
{
    public partial class frm_presentacion : Form
    {
        public frm_presentacion()
        {
            InitializeComponent();
        }

        private void AbrirFormularios (object formhija)
        {
            if (this.pnl_Contenedor.Controls.Count > 0)
                this.pnl_Contenedor.Controls.RemoveAt(0);
                Form fh = formhija as Form;
                fh.TopLevel = false;
                fh.Dock = DockStyle.Fill;
                this.pnl_Contenedor.Controls.Add(fh);
                this.pnl_Contenedor.Tag = fh;
                fh.Show();
        }

        private void btn_facturacion_Click(object sender, EventArgs e)
        {
            AbrirFormularios(new frm_facturacion());
        }
    }
}
