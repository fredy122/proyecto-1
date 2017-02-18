using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsComprobante
    {
        private clsCliente _Cliente;
        private clsEmpleado _Empleado;
        private float _PrecioTotal;        
        private string _TipoComprobnte;
        private clsArticulo _Articulo;
        private clsCorte _Corte;
        

        


        public clsComprobante(clsCliente parCliente, clsEmpleado parEmpleado,
                          float parPrecioTotal)
        {
            Cliente = parCliente;
            Empleado = parEmpleado;
            PrecioTotal = parPrecioTotal;
                        
        }

        public clsComprobante(string parTipoComprobante, clsEmpleado parEmpleado,
                          float parPrecioTotal)
        {
            TipoComprobante = parTipoComprobante;
            Empleado = parEmpleado;
            PrecioTotal = parPrecioTotal;
            
        }


        public clsCliente Cliente
        {
            get
            {
                return _Cliente;
            }
            set
            {
                _Cliente = value;
            }
        }

        public clsEmpleado Empleado
        {
            get
            {
                return _Empleado;
            }
            set
            {
                _Empleado = value;
            }
        }

        public float PrecioTotal
        {
            get
            {
                return _PrecioTotal;
            }
            set
            {
                _PrecioTotal = value;
            }
        }

        public clsArticulo Articulo
        {
            get
            {
                return _Articulo;
            }
            set
            {
                _Articulo = value;
            }
        }

        public clsCorte Corte
        {
            get
            {
                return _Corte;
            }
            set
            {
                _Corte = value;
            }
        }


        public string TipoComprobante
        {
            get
            {
                return _TipoComprobnte;
            }
            set
            {
                _TipoComprobnte = value;
            }
        }


        public void insertar_comprobante()
        {
            SqlConnection conexion;

            conexion = new
            SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;

            comando = new SqlCommand("usp_comprobante_insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parTipoComprobante", TipoComprobante);
            comando.Parameters.AddWithValue("@parDNIEmpleado", Empleado.DNI);
            
                      
            
            

            
            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close(); 
 
        }


    }
}
