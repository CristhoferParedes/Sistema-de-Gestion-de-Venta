using Sistema_de_Gestion_de_Venta.Utility;

namespace Sistema_de_Gestion_de_Venta.Entity
{
    public class Producto
    {
        public string Codigo;
        public string Nombre;
        public int Stock;
        public decimal Precio;
        public static Producto[] ColeccionProducto = new Producto[0];

        public Producto(string codigo, string nombre, int stock, decimal precio)
        {
            Codigo = codigo;
            Nombre = nombre;
            Stock = stock;
            Precio = precio;
        }
        public static void Agregar(string nombre, int stock, decimal precio)
        {          
            string codigo = ColeccionProducto.Length + 1.ToString();
            Producto nuevoProducto = new Producto(codigo, nombre, stock, precio);
            ForLogic.RedimensionarColeccion(ref ColeccionProducto);
            ForLogic.InsertarValor(ref ColeccionProducto, nuevoProducto);
        }
        public static void BuscarProducto(string codigo)
        {
            
        }
        //seguir trabajando aqui ConsolaV2
    }
}