using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsArticulo
    {
        private int _IdArticulo;
        private string _Nombre;
        private string _Lote;
        private string _Marca;
        private int _Cantidad;
        private string _Tipo;
        private float _PrecioCompra;
        private float _PrecioVenta;
        private DateTime _FechaCompra;       
        private int _Stock;
        private string _Descripcion;





         public clsArticulo(string parNombre, string parLote, string parMarca, int parCantidad,
                                    string parTipo, float parPrecioCompra, float parPrecioVenta,
                                     int parStock)
                {
                    
                    Nombre = parNombre;
                    Lote = parLote;
                    Marca = parMarca;
                    Cantidad = parCantidad;
                    Tipo = parTipo;
                    PrecioCompra = parPrecioCompra;
                    PrecioVenta = parPrecioVenta;
                    Stock = parStock;
                    

                }

        public clsArticulo(string parNombre, string parLote, string parMarca, int parCantidad,
                            string parTipo, float parPrecioCompra, float parPrecioVenta,
                            DateTime parFechaCompra, int parStock, string parDescripcion)
        {
            
            Nombre = parNombre;
            Lote = parLote;
            Marca = parMarca;
            Cantidad = parCantidad;
            Tipo = parTipo;
            PrecioCompra = parPrecioCompra;
            PrecioVenta = parPrecioVenta;
            FechaCompra = parFechaCompra;
            Stock = parStock;
            Descripcion = parDescripcion;

        }

        public clsArticulo(string parNombre, string parLote, string parMarca,string parTipo)
        {
            Nombre = parNombre;
            Lote = parLote;
            Marca = parMarca;
            Tipo = parTipo;
        }


        public int IdArticulo
        {
            get { return _IdArticulo; }
            set { _IdArticulo = value; }
        }
   
        public string Nombre
        {
            get
            { return _Nombre; }
            set
            {
                if (value.Length > 30)
                {
                    throw new Exception("El codigo debe ser inferior a 15 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Nombre no debe quedar nulo o vacio");
                }
                _Nombre = value.ToUpper(); }
                
            }


        public string Lote
        {
            get
            { return _Lote; }
            set
            {
                if (value.Length > 30)
                {
                    throw new Exception("El lote debe ser  inferior a 30 caracteres.");
                }
                _Lote = value.ToUpper();
            }
        }

        public string Marca
        {
            get
            { return _Marca; }
            set
            {
                if (value.Length > 30)
                {
                    throw new Exception("La Marca debe ser  inferior a 30 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("La Marca no debe quedar nulo o vacio");
                }
                _Marca = value.ToUpper(); 
            }
        }

        public int Cantidad
        {
            get
            { return _Cantidad; }
            set
            {
                
                _Cantidad = value; 
            }
        }

        public string Tipo
        {
            get
            { return _Tipo; }
            set
            {
                if (value.Length > 30)
                {
                    throw new Exception("La Marca debe ser  inferior a 30 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("el tipo no debe quedar vacio.");
                }
                _Tipo = value.ToUpper(); 
            }
        }

        public float PrecioCompra
        {
            get
            { return _PrecioCompra; }
            set
            { _PrecioCompra = value; }
        }

        public float PrecioVenta
        {
            get
            { return _PrecioVenta; }
            set
            { _PrecioVenta = value; }
        }

        

        public int Stock
        {
            get
            { return _Stock; }
            set
            { _Stock = value; }
        }

        public string Descripcion
        {
            get
            { return _Descripcion; }
            set
            { 
                _Descripcion = value.ToUpper(); 
            }
        }
        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set 
            {
                _FechaCompra = value; 
            }
        }
        

        
        //Metodo

        public void Insertar_Articulo()
        {

            SqlConnection conexion;

            conexion = new  SqlConnection(mdlVariables.CadenaConexion);
            


            SqlCommand comando;

            comando = new SqlCommand("usp_Articulo_Insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

           
            comando.Parameters.AddWithValue("@parNombre", Nombre);
            comando.Parameters.AddWithValue("@parLote", Lote);
            comando.Parameters.AddWithValue("@parMarca", Marca);
            comando.Parameters.AddWithValue("@parCantidad", Cantidad);
            comando.Parameters.AddWithValue("@parTipo", Tipo);
            comando.Parameters.AddWithValue("@parPrecioCompra", PrecioCompra);
            comando.Parameters.AddWithValue("@parPrecioVenta", PrecioVenta);
            comando.Parameters.AddWithValue("@parStock", Stock);

            if (string.IsNullOrEmpty(Descripcion))
            {
                comando.Parameters.AddWithValue("@parDescripcion", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parDescripcion", Descripcion);
            }

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();
        }


        public static List<clsArticulo> Listar_Articulo()
        {
            List<clsArticulo> x = new List<clsArticulo>();

            SqlConnection conexion;
            conexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand comando;

            comando = new SqlCommand("usp_Articulo_Listar_Todos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();
            SqlDataReader contenedor;
            contenedor = comando.ExecuteReader();

            while (contenedor.Read() == true)
            {
                clsArticulo miobjeto;
                miobjeto = new clsArticulo(  contenedor["Nombre"].ToString(),
                                             contenedor["Lote"].ToString(),
                                             contenedor["Marca"].ToString(),
                                             Convert.ToInt32(contenedor["Cantidad"]),
                                             contenedor["TipoArticulo"].ToString(),
                                             Convert.ToSingle(contenedor["PrecioCompra"]),
                                             Convert.ToSingle(contenedor["PrecioVenta"]),
                                             Convert.ToDateTime(contenedor["FechaCompra"]),
                                             Convert.ToInt32(contenedor["Stock"]),
                                             contenedor["Descripcion"].ToString());
                miobjeto.IdArticulo = Convert.ToInt32(contenedor["IdArticulo"]);

                x.Add(miobjeto);
            }

            conexion.Close();
            return x;
        }                     
            
        
            public static List<clsArticulo> Listar_Articulo_Nombre(string parNombre)
        {
            List<clsArticulo> x = new List<clsArticulo>();

            SqlConnection conexion;
            conexion = new SqlConnection(mdlVariables.CadenaConexion);

            SqlCommand comando;

            comando = new SqlCommand("usp_Articulo_Listar_por_Nombre", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parNombre", parNombre);

            conexion.Open();
            SqlDataReader contenedor;
            contenedor = comando.ExecuteReader();

            while (contenedor.Read() == true)
            {
                clsArticulo miobjeto;
                miobjeto = new clsArticulo(  contenedor["Nombre"].ToString(),
                                             contenedor["Lote"].ToString(),
                                             contenedor["Marca"].ToString(),
                                             Convert.ToInt32(contenedor["Cantidad"]),
                                             contenedor["TipoArticulo"].ToString(),
                                             Convert.ToSingle(contenedor["PrecioCompra"]),
                                             Convert.ToSingle(contenedor["PrecioVenta"]),
                                             Convert.ToDateTime(contenedor["FechaCompra"]),
                                             Convert.ToInt32(contenedor["Stock"]),
                                             contenedor["Descripcion"].ToString());
                miobjeto.IdArticulo = Convert.ToInt32(contenedor["IdArticulo"]);

                x.Add(miobjeto);
             }

                conexion.Close();
                return x;             
         }


            public void Actualizar_Articulo(clsArticulo NuevosDatos)
            {
                SqlConnection conexion;
                conexion = new SqlConnection(mdlVariables.CadenaConexion);

                SqlCommand comando;
                comando = new SqlCommand("usp_Articulo_Actualizar", conexion);
                comando.CommandType = System.Data.CommandType.StoredProcedure;

                comando.Parameters.AddWithValue("@parIdArticulo", IdArticulo);
                comando.Parameters.AddWithValue("@parNombre", NuevosDatos.Nombre);
                comando.Parameters.AddWithValue("@parLote", NuevosDatos.Lote);
                comando.Parameters.AddWithValue("@parMarca", NuevosDatos.Marca);
                comando.Parameters.AddWithValue("@parCantidad", NuevosDatos.Cantidad);
                comando.Parameters.AddWithValue("@parTipoArticulo", NuevosDatos.Tipo);
                //comando.Parameters.AddWithValue("@parPrecioCompra", NuevosDatos.PrecioCompra);
                comando.Parameters.AddWithValue("@parPrecioVenta", NuevosDatos.PrecioVenta);
                //comando.Parameters.AddWithValue("@parStock", NuevosDatos.Stock);


                conexion.Open();
                comando.ExecuteNonQuery();
                conexion.Close();

            }
        

    }
}
