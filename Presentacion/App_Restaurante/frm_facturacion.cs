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
    public partial class frm_facturacion : Form
    {
        public frm_facturacion()
        {
            InitializeComponent();
        }

        private void txt_Soledad_TextChanged(object sender, EventArgs e)
        {
            if (txt_Soledad.Text == "13")
            { 
                MessageBox.Show("AQUIIIIIIIIIIII TIENES PARA QUE ME LA BESES BB");
            }
            else
            {
                MessageBox.Show("Debe responder bien");

            }
        }
    }
}
