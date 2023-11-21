using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    internal class menuC : menuI
    {
        public int menuCl()
        {
            Console.WriteLine("0. cerrar");
            Console.WriteLine("1. añadir cliente");
            Console.WriteLine("2. anadir cuenta bancaria");
            int seleccion = Console.ReadKey(true).KeyChar - ('0');
            return seleccion;
        }
    }
}
