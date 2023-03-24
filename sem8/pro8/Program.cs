using pro8.Models;
using pro8.DAO;

CrudProducto CrudProducto = new CrudProducto();
Producto Producto = new Producto();

Console.WriteLine("Menu");
Console.WriteLine("pulse 1 para insertar un nuevo producto");
Console.WriteLine("pulse 0 para cancelar");
var Menu = Convert.ToInt32(Console.ReadLine());

switch (Menu)
{

    case 1:
        int bucle = 1;
        while (bucle == 1)
        {
            Console.WriteLine("ingresa el nombre del producto");
            Producto.Nombre = Console.ReadLine();
            Console.WriteLine("ingrese la descripcion del producto");
            Producto.Descripcion = Console.ReadLine();
            Console.WriteLine("ingrese el precio del producto 00.00");
            Producto.Precio = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese la cantidad en stock");
            Producto.Stock = Convert.ToInt32(Console.ReadLine());
            CrudProducto.AgregarProducto(Producto);
            Console.WriteLine("El producto se agrego correctamente ");
            Console.WriteLine("pulsa 1 para agregar otro producto");
            Console.WriteLine("pulsa 0 para salir");
            bucle = Convert.ToInt32(Console.ReadLine());
        }
        break;
}
    //CrudUsuarios.AgregarUsuario(Usuario);
    //case 2:
    //CrudUsuarios.ActualizarUsuario(Usuario);
    // break;
