using Sistema_de_Gestion_de_Venta.View;

PantallaBase.MarcoTitulo();

int opcMenu;
int opcSubMenu;

do
{
    opcMenu = Menu.Inicial();
    switch (opcMenu)
    {
        case 0:
            opcSubMenu = Menu.Registrar();
            switch (opcSubMenu)
            {
                case 0: OpcionRegistrar.Productos(); break;
                case 1: OpcionRegistrar.Clientes(); break;
            }
            break;
        case 1:
            opcSubMenu = Menu.Ventas();
            switch (opcSubMenu)
            {
                case 0: OpcionVentas.Boletas(); break;
                case 1: OpcionVentas.Facturas(); break;
            }
            break;
    }
} while (opcMenu != 5);