//dar alta una nueva cuenta bancaria ,
//tiene que terner un campo que identifique al usuario de esa cuenta bancaria
//id, isban, codigo switch del banco, a que cliente le pertenece esa cuenta bancaria , fecha alta y baja de la cuenta
using ClienteYBancoC_;
using ClienteYBancoC_.Servicios;

namespace ClienteYBancoC_
{
    class program
    {
        static void Main(string[] args)
        {
            menuI mi = new menuC();
            ClieneteI ci = new ClienteC();
            
            bool cerrarMenu = false;
            int recogido = mi.menuCl();
            
            while(!cerrarMenu)
            {
                switch (recogido) 
                {
                    case 1: cerrarMenu = true; break;
                    case 2: ci.darAltaCliente(); break;
                    case 3: 


                }

            }
        }
    }
}