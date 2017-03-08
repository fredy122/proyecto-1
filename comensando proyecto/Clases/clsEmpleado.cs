using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace comensando_proyecto
{
    public class clsEmpleado
    {
        private int _IDEmpleado;

        private string _DNI;
        private string _Nombre;
        private string _Apellido;
        private string _Telefono;
        private string _Direccion;
        private char _Sexo;            
        private DateTime _FechaNacimiento;
        private string _Correo;
        private string _Usuario;
        private string _TipoUsuario;
        private string _Contrasena;

        //insertar
        public clsEmpleado (string parDNI,string parNombre,string parApellido,string parTelefono,
                            string parDireccion, char parSexo,DateTime parFechaNacimiento,string parCorreo,string parUsuario,
                            string parTipoUsuario,string parContrasena)
        {
            DNI = parDNI;
            Nombre = parNombre;
            Apellido =parApellido;
            Telefono = parTelefono;
            Direccion = parDireccion;
            Sexo = parSexo;
            FechaNacimiento = parFechaNacimiento;
            Correo = parCorreo;
            Usuario = parUsuario;
            TipoUsuario = parTipoUsuario;
            Contrasena = parContrasena;
        }

        //listar
        public clsEmpleado(int parIDEmpleado, string parDNI, string parNombre, string parApellido
                           , DateTime parFechaNacimiento, string parCorreo)
        {
            IDEmpleado = parIDEmpleado;
            DNI = parDNI;
            Nombre = parNombre;
            Apellido = parApellido;
            FechaNacimiento = parFechaNacimiento;
            Correo = parCorreo;
        }

        public clsEmpleado(string parNombre, string parApellido
                           , string parCorreo)
        {
           
            Nombre = parNombre;
            Apellido = parApellido;
           
            Correo = parCorreo;
        }
        public clsEmpleado(string parNombre, string parDNI)
        {
            Nombre = parNombre;
            DNI = parDNI;
        }

        public int IDEmpleado
        {
            get { return _IDEmpleado; }
            set { _IDEmpleado = value; }
        }

        public string DNI
        {
            get
            {               
                return _DNI;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El DNI No Debe Quedar Vacio");
                }
                else if (value.Length > 18)
                {
                    throw new Exception("El DNI No Debe Tener Mas de 18 Caracteres");
                }
                else
                { 
                _DNI = value;
                }
            }
        }

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

        public string Telefono
        {
            get
            {
                return _Telefono;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Telefono No Debe Quedar Vacio");
                }
                else if (value.Length > 20)
                {
                    throw new Exception("El Telefono No Debe Tener Mas de 20  Digitos");
                }   
                _Telefono = value;
            }
        }

        public string Direccion
        {
            get
            {
                return _Direccion;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Direccion No Debe Quedar Vacio");
                }
                else if (value.Length > 90)
                {
                    throw new Exception("El Direccion No Debe Tener Mas de 90 Caracteres");
                }
                _Direccion = value;
            }
        }

        public char Sexo
        {
            get { return _Sexo; }
            set { _Sexo = value; }
        }    

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public string Correo
        {
            get
            {
                return _Correo;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("El Correo No Debe Quedar Vacio");
                }
                else if (value.Length > 50)
                {
                    throw new Exception("El Correo No Debe Tener Mas de 50 Caracteres");
                }
                _Correo = value;
            }
        }


        public string Usuario
        {
            get { return _Usuario; }
            set { _Usuario = value; }
        }

        public string TipoUsuario
        {
            get { return _TipoUsuario; }
            set { _TipoUsuario = value; }
        }

        public string Contrasena
        {
            get { return _Contrasena; }
            set { _Contrasena = value; }
        }
        public int Edad
        {
            get { return System.DateTime.Now.Year - FechaNacimiento.Year; }

        }


        public void Insertar_Empleado()
        {

            SqlConnection conexion;

            conexion = new
            SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");


            SqlCommand comando;

            comando = new SqlCommand("usp_Empleado_Insertar", conexion);

            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parDNI", DNI);
            comando.Parameters.AddWithValue("@parNombres", Nombre);
            comando.Parameters.AddWithValue("@parApellido", Apellido);
            comando.Parameters.AddWithValue("@parDireccion", Direccion);
            comando.Parameters.AddWithValue("@parTelefono", Telefono);
            comando.Parameters.AddWithValue("@parCorreo", Correo);
            comando.Parameters.AddWithValue("@parSexo", Sexo);
            comando.Parameters.AddWithValue("@parFechaNacimiento", FechaNacimiento);
            comando.Parameters.AddWithValue("@parUsuarrio",Usuario );
            comando.Parameters.AddWithValue("@parTipoUsuario",TipoUsuario );
            comando.Parameters.AddWithValue("@parContrasena", Contrasena);
            

            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close(); 
        }


        public static List<clsEmpleado> Buscar_Empleado_PorApellido(string parametroApellido)
        {
            List<clsEmpleado> x = new List<clsEmpleado>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_Empleado_Buscar_PorApellido", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;
            comando.Parameters.AddWithValue("@parApellidoEmpleado", parametroApellido);

            conexion.Open();

            SqlDataReader contenedor;

            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {

                clsEmpleado MiObjeto;
                MiObjeto = new clsEmpleado(Convert.ToInt32(contenedor["Id_Empleado"].ToString()),
                                            contenedor["DNI"].ToString(),
                                            contenedor["Nombres"].ToString(),
                                            contenedor["Apellidos"].ToString(),
                                            Convert.ToDateTime(contenedor["fechaNacimiento"]),
                                            contenedor["CorreoElectronico"].ToString());



                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }
        public static List<clsEmpleado> Listar_Todos_Empleados()
        {
            List<clsEmpleado> x = new List<clsEmpleado>();

            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_Empleado_Listar_Todos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            conexion.Open();

            SqlDataReader contenedor;

            contenedor = comando.ExecuteReader();
            while (contenedor.Read() == true)
            {

                clsEmpleado MiObjeto;
                MiObjeto = new clsEmpleado(Convert.ToInt32( contenedor["Id_Empleado"].ToString()),
                                            contenedor["DNI"].ToString(),
                                            contenedor["Nombres"].ToString(),
                                            contenedor["Apellidos"].ToString(),
                                            Convert.ToDateTime(contenedor["fechaNacimiento"]),
                                            contenedor["CorreoElectronico"].ToString());

                x.Add(MiObjeto);
            }
            conexion.Close();

            return x;
        }

        public void Actualizar_empleado(clsEmpleado NuevosDatos)
        {
            SqlConnection conexion;
            conexion = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand comando;
            comando = new SqlCommand("usp_empleado_Actualizar_Datos", conexion);
            comando.CommandType = System.Data.CommandType.StoredProcedure;

            comando.Parameters.AddWithValue("@parDNI", DNI);
            comando.Parameters.AddWithValue("@parNuevoNombres", NuevosDatos.Nombre);
            comando.Parameters.AddWithValue("@parNuevoApellidos", NuevosDatos.Apellido);
            comando.Parameters.AddWithValue("@parNuevoCorreoElectronico", NuevosDatos.Correo);
            


            conexion.Open();
            comando.ExecuteNonQuery();
            conexion.Close();

        }
        public static clsEmpleado Validar_Credenciales(string parUsuario, string parContrasena)
        {
            clsEmpleado x = null;
            SqlConnection CONEXION;
            CONEXION = new SqlConnection(@"SERVER=DJFREDY-PC\SISTEMAS;DATABASE=Barber_Shop_03;USER=sa;PWD=ftisland");

            SqlCommand elComando;
            elComando = new SqlCommand("usp_Usuario_Validar_Ingreso", CONEXION);
            elComando.CommandType = System.Data.CommandType.StoredProcedure;
            elComando.Parameters.AddWithValue("@parUsuario", parUsuario);
            elComando.Parameters.AddWithValue("@parcontrasena", parContrasena);
            CONEXION.Open();
            SqlDataReader contenedor;
            contenedor = elComando.ExecuteReader();
            while (contenedor.Read() == true)
            {
                x = new clsEmpleado(contenedor["Usuario"].ToString(),
                                contenedor["Contrasena"].ToString());
            }
            CONEXION.Close();
            CONEXION.Dispose();
            return x;
        }
    }
}
