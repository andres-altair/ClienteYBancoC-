using ClienteYBancoC_;
using ClienteYBancoC_.Dtos;
using ClienteYBancoC_.Servicios;

namespace ClienteYBancoC_
{
    class program
    {
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaDto> listaCuenta = new List<CuentaDto>();

            menuI mi = new menuC();
            ClieneteI ci = new ClienteC();
            CuentaI cuenta = new CuentaC();
            
            bool cerrarMenu = false;
            int recogido = mi.menuCl();
            
            while(!cerrarMenu)
            {
                switch (recogido) 
                {
                    case 0: cerrarMenu = true; 
                        break;
                    case 1: ci.darAltaCliente(listaClientes);
                        break;
                    case 2: cuenta.darAltaCuenta(listaCuenta); 
                        break; 
                    default:
                        Console.WriteLine("[INFO] - La opcion seleccionada no coincide con ninguna.");
                        break;
                }

            }
        }
    }
}