namespace Sistema_de_Gestion_de_Venta.Entity
{
    public class Boleta
    {
        public string idVenta;
        public string idCliente;
        public string idProducto;
        public string idVendedor;
        public int cantidad;
        public static Boleta[] coleccionBoleta = new Boleta[0];

    public Boleta(string idVenta, string idCliente, string idProducto, string idVendedor, int cantidad)
    {
        //me quede aqui
    }
}
