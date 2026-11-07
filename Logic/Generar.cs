using Sistema_de_Gestion_de_Venta.Utility;

namespace Sistema_de_Gestion_de_Venta.Logic
{
    public class Generar //meter dentro de utilidades
    {
        public static int MenuInicial(string orientacion, string[] opcion, int x, int y, ConsoleColor color)
        {
            int index = 0;
            ConsoleKey tecla;
            do
            {
                ForLogic.DibujarMenu(orientacion, opcion, x, y, color, index);
                tecla = Console.ReadKey(true).Key;
                ForLogic.ManejarNavegacion(orientacion, tecla, opcion, ref index);
            } while (tecla != ConsoleKey.Enter);

            Additional.ClearBox(2, 5, 81, 24);

            return index;
        }
        public static int MenuInterno(string orientacion, string[] opcion, int x, int y, ConsoleColor color)
        {
            int index = 0;
            ConsoleKey tecla;
            do
            {
                ForLogic.DibujarMenu(orientacion, opcion, x, y, color, index);
                tecla = Console.ReadKey(true).Key;
                ForLogic.ManejarNavegacion(orientacion, tecla, opcion, ref index);
            }while (tecla != ConsoleKey.Enter);
            Additional.ClearBox(2, 5, 81, 24);

            return index;
        }      
    }
}
