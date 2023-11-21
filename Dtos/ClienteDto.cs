using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Dtos
{
    /// <summary>
    /// clase donde se guarda la lista sobre los clientes creados
    /// amd 2111223
    /// </summary>
    internal class ClienteDto
    {
        long idCliente; //PK

        string nombreCliente = "aaaaa";

        string apellidosCliente = "aaaaa";

        string dniCliente = "aaaaa";

        string fchNacimientoCliente = "31/12/9999";

        string emailCliente = "aaaaa";

        int tlfCliente = 111111111;

        string fchAltaCliente = "9999/12/31";

        string fchBajaCliente = "9999/12/31";

        /// <summary>
        /// metodo que contiene los getters y setters
        /// amd 211123
        /// </summary>
        public long IdCliente { get => idCliente; set => idCliente = value; }
        public string NombreCliente { get => nombreCliente; set => nombreCliente = value; }
        public string ApellidosCliente { get => apellidosCliente; set => apellidosCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string FchNacimientoCliente { get => fchNacimientoCliente; set => fchNacimientoCliente = value; }
        public string EmailCliente { get => emailCliente; set => emailCliente = value; }
        public int TlfCliente { get => tlfCliente; set => tlfCliente = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }

        /// <summary>
        /// metodo-constructor con get y set
        /// amd 211123
        /// </summary>
        /// <param name="idCliente"></param>
        /// <param name="nombreCliente"></param>
        /// <param name="apellidosCliente"></param>
        /// <param name="dniCliente"></param>
        /// <param name="fchNacimientoCliente"></param>
        /// <param name="emailCliente"></param>
        /// <param name="tlfCliente"></param>
        /// <param name="fchAltaCliente"></param>
        /// <param name="fchBajaCliente"></param>
        public ClienteDto(long idCliente, string nombreCliente, string apellidosCliente, string dniCliente, string fchNacimientoCliente, string emailCliente, int tlfCliente, string fchAltaCliente, string fchBajaCliente)
        {
            this.idCliente = idCliente;
            this.nombreCliente = nombreCliente;
            this.apellidosCliente = apellidosCliente;
            this.dniCliente = dniCliente;
            this.fchNacimientoCliente = fchNacimientoCliente;
            this.emailCliente = emailCliente;
            this.tlfCliente = tlfCliente;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
        }

        /// <summary>
        /// metodo-constructor por defecto
        /// amd 211123
        /// </summary>
        public ClienteDto() { }

        /// <summary>
        /// metodo ToString
        /// amd 211123
        /// </summary>
        /// <returns>string</returns>
        override
        public string ToString()
        {
            string clienteString = "Nombre: " + this.nombreCliente +
                " Apellidos: " + this.apellidosCliente +
                " DNI: " + this.dniCliente +
                " Fecha Nacimiento: " + this.fchNacimientoCliente +
                " Email: " + this.emailCliente +
                " Tlf: " + this.tlfCliente +
                " Fecha Alta: " + this.fchAltaCliente +
                " Fecha Baja: " + this.fchBajaCliente;

            return clienteString;
        }
    }
}
