﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsArticulo
    {
        private string _Codigo;
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





         public clsArticulo(string parCodigo, string parNombre, string parLote, string parMarca, int parCantidad,
                                    string parTipo, float parPrecioCompra, float parPrecioVenta,
                                     int parStock)
                {
                    Codigo = parCodigo;
                    Nombre = parNombre;
                    Lote = parLote;
                    Marca = parMarca;
                    Cantidad = parCantidad;
                    Tipo = parTipo;
                    PrecioCompra = parPrecioCompra;
                    PrecioVenta = parPrecioVenta;
                    Stock = parStock;
                    

                }

        public clsArticulo(string parCodigo,string parNombre, string parLote, string parMarca, int parCantidad,
                            string parTipo, float parPrecioCompra, float parPrecioVenta,
                            DateTime parFechaCompra, int parStock, string parDescripcion)
        {
            Codigo = parCodigo;
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


        public string Codigo
        {
            get { return _Codigo; }
            set { _Codigo = value; }
        }     
        public string Nombre
        {
            get
            { return _Nombre; }
            set
            {
                if (value.Length > 30)
                {
                    throw new Exception("El codigo debe ser inferior a 12 caracteres.");
                }
                else if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Nombre no debe quedar nulo o vacio");
                }
                _Nombre = value; }
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
                _Lote = value;
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
                _Marca = value; 
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
                _Tipo = value; 
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
            { _Descripcion = value; }
        }
        public DateTime FechaCompra
        {
            get { return _FechaCompra; }
            set { _FechaCompra = value; }
        }
        

        
        //Metodo

        public void Insertar_Articulo()
        {

            SqlConnection conexion;

            conexion = new
            SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;

            comando = new SqlCommand("usp_Articulo_Insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parCodigoProd",Codigo);
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
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;

            comando = new SqlCommand("usp_Articulo_Listar_Todos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();
            SqlDataReader contenedor;
            contenedor = comando.ExecuteReader();

            while (contenedor.Read() == true)
            {
                clsArticulo miobjeto;
                miobjeto = new clsArticulo(contenedor["Cod_Producto"].ToString(),
                                            contenedor["Nombre"].ToString(),
                                             contenedor["Lote"].ToString(),
                                             contenedor["Marca"].ToString(),
                                             Convert.ToInt32(contenedor["Cantidad"]),
                                             contenedor["TipoArticulo"].ToString(),
                                             Convert.ToSingle(contenedor["PrecioCompra"]),
                                             Convert.ToSingle(contenedor["PrecioVenta"]),
                                             Convert.ToDateTime(contenedor["FechaCompra"]),
                                             Convert.ToInt32(contenedor["Stock"]),
                                             contenedor["Descripcion"].ToString());

                x.Add(miobjeto);
            }

            conexion.Close();
            return x;
        }                     
            
        
            public static List<clsArticulo> Listar_Articulo_Nombre(string parNombre)
        {
            List<clsArticulo> x = new List<clsArticulo>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

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
                miobjeto = new clsArticulo(contenedor["Cod_Producto"].ToString(), 
                                            contenedor["Nombre"].ToString(),
                                             contenedor["Lote"].ToString(),
                                             contenedor["Marca"].ToString(),
                                             Convert.ToInt32(contenedor["Cantidad"]),
                                             contenedor["TipoArticulo"].ToString(),
                                             Convert.ToSingle(contenedor["PrecioCompra"]),
                                             Convert.ToSingle(contenedor["PrecioVenta"]),
                                             Convert.ToDateTime(contenedor["FechaCompra"]),
                                             Convert.ToInt32(contenedor["Stock"]),
                                             contenedor["Descripcion"].ToString());

                x.Add(miobjeto);
             }

                conexion.Close();
                return x;             
         }
        

    }
}
