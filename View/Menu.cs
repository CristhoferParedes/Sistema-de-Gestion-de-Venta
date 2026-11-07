using Sistema_de_Gestion_de_Venta.Logic;

namespace Sistema_de_Gestion_de_Venta.View
{
    public class Menu
    {
        public static int Inicial()
        {
            var opciones = new[] { "  REGISTRAR  ", "  VENTAS  ", "  REPORTES  ", "  MODIFICAR  ", "  AYUDA  ", "  SALIR  " };
            return Generar.MenuInicial("h", opciones, 1, 3, ConsoleColor.Gray);
        }
        public static int Registrar()
        {
            var opciones = new[] { "PRODUCTOS  ", "CLIENTES   ", "VENDEDORES ", "PROVEEDORES" };
            return Generar.MenuInterno("v", opciones, 2, 5, ConsoleColor.Gray);
        }
        public static int Ventas()
        {
            var opciones = new[] { "BOLETAS ", "FACTURAS" };
            return Generar.MenuInterno("v", opciones, 17, 5, ConsoleColor.Gray);
        }
    }
}
