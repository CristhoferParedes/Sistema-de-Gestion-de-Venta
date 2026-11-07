using Sistema_de_Gestion_de_Venta.Entity;
using Sistema_de_Gestion_de_Venta.Utility;

namespace Sistema_de_Gestion_de_Venta.View
{
    internal class OpcionVentas
    {
        public static void Boletas()
        {
            Console.SetCursorPosition(37, 6);         
            Console.Write("BOLETA DE VENTA");           
            Console.SetCursorPosition(8, 8);
            Console.Write("DNI Cliente: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                  ");
            Console.ResetColor();
            Console.SetCursorPosition(4, 10);
            Console.Write(" Nombre Cliente: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                  ");
            Console.ResetColor();
            Console.SetCursorPosition(7, 25);
            Console.Write("DNI Vendedor: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.Write("                                  ");
            Console.ResetColor();
            Console.SetCursorPosition(58, 8);
            Console.Write("Nro Boleta: ");
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Write($" 123-2026 ");
            Console.ResetColor();
            Console.SetCursorPosition(63, 25);
            Console.Write("Total: ");

            Console.BackgroundColor = ConsoleColor.White;
            Console.Write($"          ");
            Console.ResetColor();

            Console.SetCursorPosition(5, 12);
            Console.Write("CODIGO            PRODUCTO                  CANTIDAD     PRECIO/U     MONTO");

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            string dniCliente = Validation.EntradaTexto(22, 8);
            Console.ResetColor();

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.SetCursorPosition(22, 10);
            Console.WriteLine(Cliente.BuscarCliente(dniCliente));
            Console.ResetColor();

        }
        public static void Facturas()
        {
            //Console.Clear();
            //Console.WriteLine("Opcion de Facturas");
            //Console.ReadKey();
        }
    }
}
