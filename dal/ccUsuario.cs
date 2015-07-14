using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccUsuario
    {
        public static bool autenticacionValida(string usuario, string password)
        {
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT Codigo, Password FROM Usuario WHERE Codigo = '" + usuario + "' AND Password = '" + password + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();
            
            if (DataReader.HasRows == true)
            {
                DataReader.Close();
                Comando.Connection.Close();
                return true;
            }
            else
            {
                DataReader.Close();
                Comando.Connection.Close();
                return false;
            }
        }

        public static blc.Usuario cargarUsuario(string usuario)
        {
            blc.Usuario user = new blc.Usuario();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Usuario WHERE Codigo = '" + usuario + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            /* Cargar el objeto con toda su informacion */
            while (DataReader.Read())
            {
                user.Codigo = usuario;
                user.Password = DataReader.GetValue(1).ToString();
                user.Nombre = DataReader.GetValue(2).ToString();
                user.Apellido = DataReader.GetValue(3).ToString();
                user.Celular = DataReader.GetValue(4).ToString();
                user.Email = DataReader.GetValue(5).ToString();
                user.Grupo.Codigo = (int)DataReader.GetValue(6);
                user.Superusuario = DataReader.GetValue(7).ToString();
            }
            DataReader.Close();
            Comando.Connection.Close();
            return user;
        }       

        public static void agregarUsuario(blc.Usuario usuario)
        {
            System.Data.SqlClient.SqlCommand Comando;            
            string query;
            query = "INSERT INTO Usuario VALUES('" + usuario.Codigo + "','" + usuario.Password + "','" + usuario.Nombre + "','" + usuario.Apellido +
                "','" + usuario.Celular + "','" + usuario.Email + "','" + usuario.Grupo.Codigo + "','" + usuario.Superusuario + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();     
        }

        public static void agregarUsuarioPredeterminado(blc.Usuario usuario, dal.DT dt)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;
            query = "INSERT INTO Usuario VALUES('" + usuario.Codigo + "','" + usuario.Password + "','" + usuario.Nombre + "','" + usuario.Apellido +
                "','" + usuario.Celular + "','" + usuario.Email + "','" + usuario.Grupo.Codigo + "','" + usuario.Superusuario + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close(); 
        }

        public static bool usuarioExiste(string codigoUsuario)
        {
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Usuario WHERE Codigo = '" + codigoUsuario + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            if (DataReader.HasRows == true)
            {
                DataReader.Close();
                Comando.Connection.Close();
                return true;
            }
            else
            {
                DataReader.Close();
                Comando.Connection.Close();
                return false;
            }            
        }

        public static List<string> obtenerUsuarios()
        {
            List<string> ids = new List<string>();

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT Codigo FROM Usuario";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
                ids.Add(DataReader.GetValue(0).ToString());

            DataReader.Close();
            Comando.Connection.Close();
            return ids;
        }
        
    }
}
