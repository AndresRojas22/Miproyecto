using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesTienda;
using AccesoDatosTienda;
using System.Windows.Forms;

namespace ManejadorTienda
{
    public class Manejador
    {
        Base b = new Base("localhost", "root", "", "Tienda");
        public string Guardar(Entidad e)
        {
            return b.Comando(string.Format("Insert into producto velues({0},{1},{2},{3});", e._id_producto, e._Nombre +
                e._Descripcion, e._Precio));
        }
        public void Mostrar(DataGridView dtg)
        {

        }

    }
}
