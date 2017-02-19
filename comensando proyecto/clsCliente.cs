using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comensando_proyecto
{
    public class clsCliente
    {
        private int _ID_Cliente;

        private string _Nombre;       
        private string _Apellido;        
        private string _DNI;
        private string _Ocupacion;             
        private string _Telefono;       
        private string _Correo;       
        private char _Sexo;
        private DateTime _FechaNacimiento;

        //Actulizar
        public clsCliente(int parID, string parNombre, string parApellido, string parDNI, string parCorreo,
                            DateTime parFechaNacimiento)
        {
            ID_Cliente = parID;
            Nombre = parNombre;
            Apellido = parApellido;
            DNI = parDNI;
            Correo = parCorreo;
            FechaNacimiento = parFechaNacimiento;
        }
        

        public clsCliente(string parNombre, string parApellido,
                          string parCorreo, char parSexo, DateTime parFechaNacimiento)
        {
            
            Nombre = parNombre;
            Apellido = parApellido;        
            Correo = parCorreo;
            Sexo = parSexo;
            FechaNacimiento = parFechaNacimiento;
            
        }

        public clsCliente(string parNombre, string parApellido,
                          string parCorreo, DateTime parFechaNacimiento, string parDNI)
        {
            
            Nombre = parNombre;
            Apellido = parApellido;
            DNI = parDNI;
            FechaNacimiento = parFechaNacimiento;
            Correo = parCorreo;
            
            
        }
        public clsCliente( string parNombre, string parApellido,
                          string parCorreo,string parDNI)
        {
            
            Nombre = parNombre;
            Apellido = parApellido;
            DNI = parDNI;
            
            Correo = parCorreo;


        }


        public int ID_Cliente
        {
            get { return _ID_Cliente; }
            set { _ID_Cliente = value; }
        }
        
        

        //===========
        public string Nombre
        {
            get 
            {
                return _Nombre; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Nombre No Debe Quedar Vacio");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("El Nombre No Debe Tener Mas de 50 Caracteres");
                }
                _Nombre = value; 
            }
        }
        public string Apellido
        {
            get 
            {
                return _Apellido; 
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Apellido No Debe Quedar Vacio");
                }
                else if (value.Length > 80)
                {
                    throw new Exception("El Apellido No Debe Tener Mas de 80 Caracteres");
                }
                _Apellido = value; 
            }
        }
        public string DNI
        {
            get 
            {
                return _DNI; 
            }
            set 
            {
                if (value.Length > 8)
                {
                    throw new Exception("El DNI No Debe Tener Mas de 8 Caracteres");
                }
                _DNI = value; 
            }
        }
        
        public string Telefono
        {
            get 
            {
                return _Telefono; 
            }
            set 
            {
                if (value.Length > 20)
                {
                    throw new Exception("El Telefono No Debe Tener Mas de 20 Digitos");
                }   
                _Telefono = value; 
            }
        }
        public string Correo
        {
            get
            {
                return _Correo; 
            }
            set 
            {
                if (value.Length > 50)
                {
                    throw new Exception("El Correo No Debe Tener Mas de 50 Caracteres");
                }
                else if(string.IsNullOrWhiteSpace(value))  
                {
                    throw new Exception("El correo no puede quedar nulo");
                }
                _Correo = value; 
            }
        }
        public char Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }

        public string Ocupacion
        {
            get { return _Ocupacion; }
            set { _Ocupacion = value; }
        }  

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public void Insertar_Cliente()
        {
            
            SqlConnection conexion;
            
            conexion = new
            SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            
            SqlCommand comando;

            comando = new SqlCommand("usp_Cliente_Insertar", conexion);
            
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            
            comando.Parameters.AddWithValue("@parNombres", Nombre);
            comando.Parameters.AddWithValue("@parApellido", Apellido);                    
            comando.Parameters.AddWithValue("@parCorreo", Correo);
            comando.Parameters.AddWithValue("@parSexo", Sexo);
            comando.Parameters.AddWithValue("@parFechaNacimiento", FechaNacimiento);
            if (string.IsNullOrEmpty(DNI))
            {
               comando.Parameters.AddWithValue("@parDNI", DBNull.Value); 
            }
            else
            {
                comando.Parameters.AddWithValue("@parDNI", DNI);
            }
            if (string.IsNullOrEmpty(Ocupacion))
            {
                comando.Parameters.AddWithValue("@parOcupacion", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parOcupacion", Ocupacion);
            }
            if (string.IsNullOrEmpty(Telefono))
            {
                comando.Parameters.AddWithValue("@parTelefono", DBNull.Value);
            }
            else
            {
                comando.Parameters.AddWithValue("@parTelefono", Telefono);
            }
            
            conexion.Open(); 
            comando.ExecuteNonQuery(); 
            conexion.Close(); 

        }

        

        public static List<clsCliente> Listar()
        {
            List<clsCliente> y = new List<clsCliente>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_Clientes_Listar_Todos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();

            SqlDataReader contenedor;

            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {

                clsCliente MiObjeto;
                MiObjeto = new clsCliente(Convert.ToInt32(contenedor["Id_Cliente"]),
                                            contenedor["Nombres"].ToString(),
                                            contenedor["Apellidos"].ToString(),
                                            contenedor["DNI"].ToString(),
                                            contenedor["Correo_Facebook"].ToString(),
                                            Convert.ToDateTime(contenedor["FechaNacimiento"]));

                y.Add(MiObjeto);
            }
            conexion.Close();

            return y;
        }

        public void Actualizar_cliente(clsCliente NuevosDatos)
        {
            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_Cliente_Actualizar_Datos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parID", ID_Cliente);
            comando.Parameters.AddWithValue("@parNombres", NuevosDatos.Nombre);
            comando.Parameters.AddWithValue("@parApellidos", NuevosDatos.Apellido);
            comando.Parameters.AddWithValue("@parCorreo_Facebook", NuevosDatos.Correo);
            comando.Parameters.AddWithValue("@parDNI",NuevosDatos.DNI);


            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }

        public static List<clsCliente> Buscar_PorApellido(string parametroApellido)
        {
            List<clsCliente> x = new List<clsCliente>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            
            SqlCommand comando;
            comando = new SqlCommand("usp_Cliente_Buscar_PorApellido", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parApellidoCliente", parametroApellido);

            conexion.Open();
            
            SqlDataReader contenedor;
            
            contenedor = comando.ExecuteReader(); 
            while (contenedor.Read() == true)
            {
                
                clsCliente MiObjeto;
                MiObjeto = new clsCliente(contenedor["Nombres"].ToString(),
                                             contenedor["Apellidos"].ToString(),
                                             contenedor["Correo_Facebook"].ToString(),
                                             Convert.ToDateTime(contenedor["FechaNacimiento"]),
                                             contenedor["DNI"].ToString());
                
                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }

        public static List<clsCliente> Buscar_PorDNI(string parametroDNI)
        {
            List<clsCliente> x = new List<clsCliente>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;
            comando = new SqlCommand("usp_Cliente_Buscar_PorDNI", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parDNI", parametroDNI);

            conexion.Open();

            SqlDataReader contenedor;

            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {

                clsCliente MiObjeto;
                MiObjeto = new clsCliente(contenedor["Nombres"].ToString(),
                                             contenedor["Apellidos"].ToString(),
                                             contenedor["Correo_Facebook"].ToString(),
                                             Convert.ToDateTime(contenedor["FechaNacimiento"]),
                                             contenedor["DNI"].ToString());

                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }


    }
}
