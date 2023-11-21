using ClienteYBancoC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    internal interface CuentaI
    {
        public void darAltaCuenta(List<CuentaDto>listaAntigua);
    }
}
