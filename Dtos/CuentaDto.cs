using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteYBancoC_.Dtos
{
    internal class CuentaDto
    {
        int id;
        string isban = "ES3900750122705746009420";
        string swift = "CSI1SSXX";
        string fchAltaCliente = "9999/12/31";
        string fchBajaCliente = "9999/12/31";
        string indentificadorUsu = "aaaa1111";

        public int Id { get => id; set => id = value; }
        public string Isban { get => isban; set => isban = value; }
        public string Swift { get => swift; set => swift = value; }
        public string FchAltaCliente { get => fchAltaCliente; set => fchAltaCliente = value; }
        public string FchBajaCliente { get => fchBajaCliente; set => fchBajaCliente = value; }
        public string IndentificadorUsu { get => indentificadorUsu; set => indentificadorUsu = value; }

        public CuentaDto(int id, string isban, string swift, string fchAltaCliente, string fchBajaCliente, string indentificadorUsu)
        {
            this.id = id;
            this.isban = isban;
            this.swift = swift;
            this.fchAltaCliente = fchAltaCliente;
            this.fchBajaCliente = fchBajaCliente;
            this.indentificadorUsu = indentificadorUsu;
        }
        public CuentaDto() { }  

        override
            public string ToString()
        {
            string clieneteCuenta = "id:   " + this.id +
                "isban   " + this.isban +
                "swift   " + this.swift +
                "faecha de alta   " + this.fchAltaCliente +
                "fecha de baja   " + this.fchBajaCliente +
                "identificador de la ceunta con el usuaeio   " + this.indentificadorUsu;
                return clieneteCuenta;
        }
    }
}

    

