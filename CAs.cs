using System;
using System.Reflection;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration.Install;
using System.Linq;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.ServiceProcess;

namespace sistemaBufetes
{
    [RunInstaller(true)]
    public partial class CAs : System.Configuration.Install.Installer
    {               
        public CAs()
        {
            InitializeComponent();            
        }

        /* CUSTOM ACTIONS */


        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Install(IDictionary stateSaver)
        {
            base.Install(stateSaver);

            string opcion = Context.Parameters["radio"];

            if (opcion != "2")
                return;            

            /* Obtener el Assembly */
            Assembly asm = Assembly.GetExecutingAssembly();
            
            //* Obtener el path del assemvbly */
            Stream path = asm.GetManifestResourceStream(asm.GetName().Name + "." + "script.txt");
            
            /* Leer el script */
            StreamReader reader = new StreamReader(path);
            string script = reader.ReadToEnd();

            /* Conectar al servidor SQL */
            string coneccion = "Server=.\\SQLEXPRESS; Trusted_Connection=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = coneccion;

            try
            {
                /* Intentar establecer la connecion */
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Environment.Exit(0);
            }

            /* Definir el comando para crear la BD */
            System.Data.SqlClient.SqlCommand Command;
            Command = new System.Data.SqlClient.SqlCommand("CREATE DATABASE BUFETE");
            Command.Connection = connection;

            /* Ejecutar el script */
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {                
                MessageBox.Show("Base de datos ya existe, Se reemplazara por una nueva.");
                Command.CommandText = "DROP DATABASE BUFETE";
                Command.ExecuteNonQuery();
                Command.CommandText = "CREATE DATABASE BUFETE";
                Command.ExecuteNonQuery();
            }

            /* Crear las tablas */
            Command = null;
            Command = new System.Data.SqlClient.SqlCommand(script);
            Command.Connection = connection;

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            
            /* Cambiar el modo de autenticacion del servidor a Mixed Mode */
            string query = "USE [BUFETE]; EXEC xp_instance_regwrite N'HKEY_LOCAL_MACHINE', N'Software\\Microsoft\\MSSQLServer\\MSSQLServer', N'LoginMode', REG_DWORD, 2";
            Command = null;
            Command = new System.Data.SqlClient.SqlCommand(query);
            Command.Connection = connection;
            

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            /* Crear el usuario SQL */
            string auth = "ALTER LOGIN sa ENABLE";
            string auth2 = "ALTER LOGIN sa WITH PASSWORD = 'BufAdmin'";
            Command = null;
            Command = new System.Data.SqlClient.SqlCommand(auth);
            Command.Connection = connection;

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            Command = null;
            Command = new System.Data.SqlClient.SqlCommand(auth2);
            Command.Connection = connection;

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
            /* Cerrar la coneccion */            
            connection.Close();                                                
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Commit(IDictionary savedState)
        {
            base.Commit(savedState);

            string opcion = Context.Parameters["radio"];

            if (opcion != "2")
                return;

            /* Correr el Script de SQL para definir las configuraciones iniciales en la BD */
            string nombreBufete = Context.Parameters["bufete"];

            /* Crear un grupo default */
            blc.Grupo grupo = new blc.Grupo();
            grupo.Codigo = 0;
            grupo.Nombre = "Administracion";
            grupo.PermisoCasos = "Y";
            grupo.PermisoClientes = "Y";
            grupo.PermisoConfiguracion = "Y";
            grupo.PermisoEvidencia = "Y";
            grupo.PermisoGestion = "Y";
            grupo.PermisoInventario = "Y";
            grupo.PermisoReportes = "Y";
            grupo.PermisoTestigos = "Y";

            /* Crear el usuario default */
            blc.Usuario usuario = new blc.Usuario();
            usuario.Codigo = Context.Parameters["user"];
            usuario.Password = ccUtilities.GetMD5Hash(Context.Parameters["pass"]);
            usuario.Nombre = usuario.Codigo;
            usuario.Apellido = usuario.Codigo;
            usuario.Superusuario = "Y";
            usuario.Grupo = grupo;

            /* Abrir la coneccion con la base de datos */
            dal.DT dt = new dal.DT(null);
            dt.dbConnect();

            /* Configurar los parametros del bufete en la BD */
            dal.ccBufete.insertarConfiguracion(nombreBufete, dt);

            /* Agregar el usuario y grupo default a la BD */
            dal.ccGrupo.agregarGrupoPredeterminado(grupo, dt);
            dal.ccUsuario.agregarUsuarioPredeterminado(usuario, dt);

            ///* Resetear el servidor */
            //ServiceController controller = new ServiceController("MSSQL$SQLEXPRESS");
            //try
            //{
            //    controller.Stop();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}
            //try
            //{
            //    controller.Start();
            //}
            //catch (Exception e)
            //{
            //    MessageBox.Show(e.Message);
            //}

            //controller.Close();
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Rollback(IDictionary savedState)
        {
            base.Rollback(savedState);
        }

        [System.Security.Permissions.SecurityPermission(System.Security.Permissions.SecurityAction.Demand)]
        public override void Uninstall(IDictionary savedState)
        {
            base.Uninstall(savedState);

            /* Borrar la base de datos */
            /* Conectar al servidor SQL */
            string coneccion = "Server=.\\SQLEXPRESS; Trusted_Connection=True";
            SqlConnection connection = new SqlConnection();
            connection.ConnectionString = coneccion;

            try
            {
                /* Intentar establecer la connecion */
                connection.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                System.Environment.Exit(0);
            }

            /* Definir el comando para borrar la BD */
            System.Data.SqlClient.SqlCommand Command;
            Command = new System.Data.SqlClient.SqlCommand("DROP DATABASE [BUFETE]");
            Command.Connection = connection;

            /* Ejecutar el script */
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                
            }
            
            /* Cerrar la coneccion */
            connection.Close();
            
        }
    }
}
