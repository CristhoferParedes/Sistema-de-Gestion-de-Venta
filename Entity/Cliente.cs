namespace Sistema_de_Gestion_de_Venta.Entity
{
    public class Cliente
    {
        public string Dni;
        public string Nombre;
        public string Apellido;
        public static Cliente[] ColeccionCliente = new Cliente[0];

        public Cliente(string dni, string nombre, string apellido)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
        }
        public static string BuscarCliente(string dni)
        {
            for (int i = 0; i < ColeccionCliente.Length; i++)
            {
                if (ColeccionCliente[i].Dni == dni)
                {
                    return $"{ColeccionCliente[i].Nombre} {ColeccionCliente[i].Apellido}";
                }
            }
            return "Cliente no encontrado";
        }
        public static void Agregar(string dni, string nombre, string apellido)
        {
            Cliente nuevoCliente = new Cliente(dni, nombre, apellido);
            Array.Resize(ref ColeccionCliente, ColeccionCliente.Length + 1);
            ColeccionCliente[ColeccionCliente.Length - 1] = nuevoCliente;
        }
    } 
}
