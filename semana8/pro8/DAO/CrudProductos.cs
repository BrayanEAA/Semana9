using pro8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pro8.DAO
{
    public class CrudProducto
    {
        public void AgregarProducto(Producto ParametroProducto)
        {
            using (AlmacenContext db = new AlmacenContext()) ;
)
            {
                Producto producto = new Usuario();
                producto.Nombre = ParametroProducto.Nombre;
                producto.Descripcion = ParametroProducto.Descripcion;
                producto.Precio = ParametroProducto.Precio;
                producto.Stock = ParametroProducto.Stock;
                db.Add(producto);
                db.SaveChanges();

            }
        }


    }
}