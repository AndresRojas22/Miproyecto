using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesTienda
{
    public class Entidad
    {
        public int _id_producto { get; set; }
        public string _Nombre { get; set; }
        public string _Descripcion { get; set; }
        public int _Precio { get; set; }
        public Entidad(int id_producto, string Nombre, string Descripcion, int Precio)
        {
            _id_producto = id_producto;
            _Nombre = Nombre;
            _Descripcion = Descripcion;
            _Precio = Precio;

        }
        public Entidad()
        {

        }
    }
}
