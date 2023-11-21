using ClienteYBancoC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    /// <summary>
    /// interfaz encargada de dar alta al usuario
    /// amd 211123
    /// </summary>
    internal interface ClieneteI
    /// <summary>
    /// metodo que da de alata ala ususario
    /// amd 211123
    /// </summary>
    {
        public void darAltaCliente(List<ClienteDto> listaAntigua);
    }
}
