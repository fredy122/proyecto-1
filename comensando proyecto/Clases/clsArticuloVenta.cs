using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comensando_proyecto
{
    public class clsArticuloDeVenta
    {
        private clsArticulo _Articulo;      
        private clsVenta _Venta;
        private clsCorte _Corte;      
        private int _Cantidad;
        private Single PrecioTotalVenta;
       

        public clsArticuloDeVenta(clsArticulo parArticulo)
        {
            Articulo = parArticulo;

        }

        public clsArticulo Articulo
        {
            get { return _Articulo; }
            set { _Articulo = value; }
        }
        public clsVenta Venta
        {
            get { return _Venta; }
            set { _Venta = value; }
        }
        public clsCorte Corte
        {
            get { return _Corte; }
            set { _Corte = value; }
        }
        public int Cantidad
        {
            get { return _Cantidad; }
            set { _Cantidad = value; }
        }

        public Single PrecioTotalVenta1
        {
            get { return PrecioTotalVenta; }
            set { PrecioTotalVenta = value; }
        }
    }
}
