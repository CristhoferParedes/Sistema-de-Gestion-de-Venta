using Sistema_de_Gestion_de_Venta.Entity;
using Sistema_de_Gestion_de_Venta.Utility;

namespace Sistema_de_Gestion_de_Venta.View
{
    internal class OpcionRegistrar
    {
        public static void Productos()
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("Ingresar el nombre del Producto :");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Ingresar el stock del Producto  :");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("Ingresar el Precio del Producto :");
            string nombre = Validation.EntradaTexto(38, 6);
            int stock = Validation.EntradaEntero(38, 7);
            decimal precio = Validation.EntradaDecimal(38, 8);
            Producto.Agregar(nombre, stock, precio);

            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 27);
            Console.WriteLine("Se agrego Correctamente la informacion...!");
            Console.ReadKey(true);
            Additional.ClearBox(2, 5, 81, 24);

        }
        public static void Clientes()
        {
            Console.CursorVisible = true;
            Console.SetCursorPosition(4, 6);
            Console.WriteLine("Ingresar el dni del cliente      :");
            Console.SetCursorPosition(4, 7);
            Console.WriteLine("Ingresar el nombre del cliente   :");
            Console.SetCursorPosition(4, 8);
            Console.WriteLine("Ingresar el apellido del cliente :");
            string dni = Validation.EntradaTexto(38, 6);
            string nombre = Validation.EntradaTexto(38, 7);
            string apellido = Validation.EntradaTexto(38, 8);
            Cliente.Agregar(dni, nombre, apellido);

            Console.CursorVisible = false;
            Console.SetCursorPosition(4, 27);
            Console.WriteLine("Se agrego Correctamente la informacion...!");
            Console.ReadKey(true);
            Additional.ClearBox(2, 5, 81, 24);
        }
    }
}
