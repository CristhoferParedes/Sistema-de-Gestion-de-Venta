namespace Sistema_de_Gestion_de_Venta.Utility
{
    public class ForLogic
    {
        public static void DibujarMenu(string orientacion, string[] opcion, int x, int y, ConsoleColor color, int index)
        {
            if (orientacion == "h") Console.SetCursorPosition(x, y);//se pueden independizar las logicas de dibujo horizontal y vertical para que no se repita el codigo

            for (int i = 0; i < opcion.Length; i++)
            {
                if (orientacion == "v") Console.SetCursorPosition(x, y + i);

                if (i == index)
                {
                    Console.BackgroundColor = color;
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                else
                {
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ForegroundColor = ConsoleColor.Black;
                }

                Console.Write($" {opcion[i]} ");
                Console.ResetColor();
                Console.Write(" ");//independizar para que no afecte el espacio al seundo menu
            }
        }
        public static void ManejarNavegacion(string orientacion, ConsoleKey tecla, string[] opcion, ref int index)
        {
            if (orientacion == "h") // se puede independizar la logica de navegacion horizontal y vertical, para que no se repita el codigo
            {
                if (tecla == ConsoleKey.RightArrow) index++;
                else if (tecla == ConsoleKey.LeftArrow) index--;
            }
            else
            {
                if (tecla == ConsoleKey.DownArrow) index++;
                else if (tecla == ConsoleKey.UpArrow) index--;               
            }
            if (index > opcion.Length - 1) index = 0;
            else if (index < 0) index = opcion.Length - 1;//configurar una deteccion de la tecla escape para salir del menu y volver al menu anterior
        }
        public static void RedimensionarColeccion<T>(ref T[] arreglo)
        {
            Array.Resize(ref arreglo, arreglo.Length + 1);
        }
        public static void InsertarValor<T>(ref T[] arreglo, T Elemento)
        {
            arreglo[arreglo.Length - 1] = Elemento;
        }
    }
}
