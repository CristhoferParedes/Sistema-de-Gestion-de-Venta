namespace Sistema_de_Gestion_de_Venta.Utility
{
    public class Validation
    {
        public static string EntradaTexto(int x, int y)
        {
            string? entrada;
            Console.SetCursorPosition(x, y);

            while (string.IsNullOrWhiteSpace(entrada = Console.ReadLine()))
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("No puedes dejar este campo vacío.");
                Console.ReadKey(true);
                Additional.ClearBox(x, y, 32, 1);
                Console.SetCursorPosition(x, y);
                //Console.ResetColor();
            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(entrada);
            //Console.ResetColor();
            return entrada;
        }
        public static int EntradaEntero(int x, int y)
        {
            int entrada;
            Console.SetCursorPosition(x, y);

            while (!int.TryParse(Console.ReadLine(), out entrada))
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingresa un número entero válido.");
                Console.ReadKey(true);
                Additional.ClearBox(x, y, 32, 1);
                Console.SetCursorPosition(x, y);
                //Console.ForegroundColor = ConsoleColor.Black;
                //Console.ResetColor();

            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(entrada);
            Console.ResetColor();

            return entrada;
        }
        public static decimal EntradaDecimal(int x, int y)
        {
            decimal entrada;
            Console.SetCursorPosition(x, y);

            while (!decimal.TryParse(Console.ReadLine(), out entrada))
            {
                Console.SetCursorPosition(x, y);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Ingresa un número entero válido.");
                Console.ReadKey(true);
                Additional.ClearBox(x, y, 40, 1);
                Console.SetCursorPosition(x, y);
                Console.ResetColor();
            }
            Console.SetCursorPosition(x, y);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(entrada);
            Console.ResetColor();
            return entrada;
        }
    }
}
