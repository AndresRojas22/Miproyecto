using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntidadesTienda;
using ManejadorTienda;

namespace PresentacionTienda
{
    public partial class FrmAdd : Form
    {
        Entidad E;
        Manejador M;
        public FrmAdd()
        {
            InitializeComponent();
            E = new Entidad();
            M = new Manejador();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(M.Guardar(new Entidad(int.Parse(txtid.Text),txtNombre.Text,txtDesc.Text, int.Parse(txtPrecio.Text))));
            Close();
        }
    }
}
