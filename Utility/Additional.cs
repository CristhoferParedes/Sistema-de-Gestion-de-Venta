namespace Sistema_de_Gestion_de_Venta.Utility
{
    public class Additional
    {
        public static void ClearBox(int posX, int posY, int width, int height)
        {
            for (int i = 0; i < height; i++)
            {                
                Console.SetCursorPosition(posX, posY + i);
                Console.WriteLine(new string(' ', width));
            }
        }
    }
}
