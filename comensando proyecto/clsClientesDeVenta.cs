using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comensando_proyecto
{
    public class clsClientesDeVenta
    {
        private clsCliente _Cliente;      
        private clsVenta _Venta;

        public clsClientesDeVenta(clsCliente parcliente, clsVenta parVenta)
        {
            Cliente = parcliente;
            Venta = parVenta;
        }

        public clsCliente Cliente
        {
            get { return _Cliente; }
            set { _Cliente = value; }
        }
        public clsVenta Venta
        {
            get { return _Venta; }
            set { _Venta = value; }
        }

    }
}
