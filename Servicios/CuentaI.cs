using ClienteYBancoC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    /// <summary>
    /// interfaz encargada de crear una nueva cuenta
    /// amd 211123
    /// </summary>
    internal interface CuentaI
    {
        /// <summary>
        /// metodo que crea una nueva cuenta
        /// amd 211123
        /// </summary>
        /// <param name="listaAntigua"></param>
        public void darAltaCuenta(List<CuentaDto>listaAntigua);
    }
}
