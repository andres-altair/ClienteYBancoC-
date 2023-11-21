using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Dtos
{
    /// <summary>
    /// clase que contiene las listas de las cuentas
    /// amd 211123
    /// </summary>
    internal class CuentaDto
    {
        int id= 123456789;
        string isban = "ES3900750122705746009420";
        string swift = "CSI1SSXX";
        string fchAltaCliente = "9999/12/31";
        string fchBajaCliente = "9999/12/31";
        string indentificadorUsu = "aaaa1111";
       
        /// <summary>
        /// metodo que contiene los getters y setters
        /// amd 211123
        /// </summary>
        public int Id { get => id; set => id = value; }
        public string Isban { get => isban; set => isban = value; }
        public string Swift { get => swift; set => swift = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
        public string IndentificadorUsu { get => indentificadorUsu; set => indentificadorUsu = value; }

        /// <summary>
        /// metodo-constructor con get y set
        /// amd 211123
        /// </summary>
        /// <param name="id"></param>
        /// <param name="isban"></param>
        /// <param name="swift"></param>
        /// <param name="fchAltaCliente"></param>
        /// <param name="fchBajaCliente"></param>
        /// <param name="indentificadorUsu"></param>
        /// <param name="idCliente"></param>
        public CuentaDto(int id, string isban, string swift, string fchAltaCliente, string fchBajaCliente, string indentificadorUsu, long idCliente)
        {
            this.id = id;
            this.isban = isban;
            this.swift = swift;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
            this.indentificadorUsu = indentificadorUsu;
        }

        /// <summary>
        /// metodo-contructor por defecto
        /// amd 211123
        /// </summary>
        public CuentaDto() { }  

        /// <summary>
        /// metodo ToString
        /// amd 211123
        /// </summary>
        /// <returns>string</returns>
        override
            public string ToString()
        {
            string clieneteCuenta = "id:   " + this.id +
                "isban   " + this.isban +
                "swift   " + this.swift +
                "faecha de alta   " + this.fchAltaCliente +
                "fecha de baja   " + this.fchBajaCliente +
                "identificador de la ceunta con el usuario   " + this.indentificadorUsu;
                return clieneteCuenta;
        }
    }
}

    

