namespace Sistema_de_Gestion_de_Venta.View
{
    public class PantallaBase
    {
        public static void MarcoTitulo()
        {
            Console.CursorVisible = false;

            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("                                                                                     ");
            Console.WriteLine("                              SISTEMA PARA GESTIONAR VENTAS                          ");
            Console.WriteLine("                                                                                     ");

            Console.SetCursorPosition(0, 4);
            Console.Write("                                                                                     ");

            for (int i = 5; i < 30; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("  ");
                Console.SetCursorPosition(83, i);
                Console.Write("  ");
            }

            Console.SetCursorPosition(0, 29);
            Console.Write("                                                                                     ");
            Console.ResetColor();
        }
    }
}
