using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    /// <summary>
    /// interfaz encragada de mostra un menu y guarda la eleccion del usuario
    /// amd-201123
    /// </summary>
    internal interface menuI
    {
        /// <summary>
        /// metodo que mostra un menu y guarda la eleccion del usuario
        /// amd-201123
        /// </summary>
        /// <returns>int</returns>
        public int menuCl();
    }
}
