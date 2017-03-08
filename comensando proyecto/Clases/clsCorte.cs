using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsCorte
    {
        private string _Nombre;
        private float _Precio;

        public clsCorte(string parNombre, float parPrecio)
        {
            Nombre = parNombre;
            Precio = parPrecio;
        }

        public string Nombre
        {
            get
            {
                return _Nombre;
            }
            set
            {
                _Nombre = value;
            }
        }

        public float Precio
        {
            get
            {
                return _Precio;
            }
            set
            {
                _Precio = value;
            }
        }

        

        public void insertar()
        {
            SqlConnection conexion;

            conexion = new
                SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;

            comando = new SqlCommand("usp_Corte_Insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parNombre", Nombre);
            comando.Parameters.AddWithValue("@parPrecio", Precio);

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close(); 
        }

        public static List<clsCorte> Listar_Corte()
        {
            List<clsCorte> x = new List<clsCorte>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_Corte_Listar_Todos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();

            SqlDataReader contenedor;

            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {

                clsCorte MiObjeto;
                MiObjeto = new clsCorte(contenedor["Nombre"].ToString(), Convert.ToSingle(contenedor["Precio"]));
                                            

                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }
    }
}
