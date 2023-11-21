using ClienteYBancoC_;
using ClienteYBancoC_.Dtos;
using ClienteYBancoC_.Servicios;

namespace ClienteYBancoC_
{
    /// <summary>
    /// clase principal
    /// amd 211123
    /// </summary>
    class program
    {
        /// <summary>
        /// metodo principal
        /// amd 211123
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            List<ClienteDto> listaClientes = new List<ClienteDto>();
            List<CuentaDto> listaCuenta = new List<CuentaDto>();

            menuI mi = new menuC();
            ClieneteI ci = new ClienteC();
            CuentaI cuenta = new CuentaC();
            
            bool cerrarMenu = false;
            int recogido;

            while (!cerrarMenu)
            {
                recogido = mi.menuCl();
                switch (recogido) 
                {
                    case 0: cerrarMenu = true; 
                        break;
                    case 1: ci.darAltaCliente(listaClientes);
                        foreach (ClienteDto cliente in listaClientes)
                        {
                            Console.WriteLine(cliente.ToString());
                        }
                        break;
                    case 2: cuenta.darAltaCuenta(listaCuenta); 
                        break; 
                    default:
                        Console.WriteLine("La opcion seleccionada no coincide con ninguna.");
                        break;
                       
                }

            }
        }
    }
}