﻿using ClienteYBancoC_.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Servicios
{
    internal class CuentaC : CuentaI
    {
        public void darAltaCuenta(List<CuentaDto> listaAntigua)
        {
            CuentaDto cuenta = new CuentaDto();
            listaAntigua.Add(cuenta);
        }
        private CuentaDto crearNuevaCuenta()
        {
            CuentaDto nuevaCuenta = new CuentaDto();
            Console.WriteLine("escribe tu id");
            nuevaCuenta.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("escribe tu isban");
            nuevaCuenta.Isban = Console.ReadLine();
            Console.WriteLine("escribe tu swift");
            nuevaCuenta.Swift = Console.ReadLine();
            Console.WriteLine("escribe tu isban");
            Console.WriteLine("Introduzca la fecha de alta: ");
            nuevaCuenta.FchAltaCliente = Console.ReadLine();
            
            
            return nuevaCuenta; 
        }
    }
}