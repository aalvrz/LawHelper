using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccBufete
    {
        public static void actualizarBufete(string nombre, string idioma, string tema, string logo)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "UPDATE Bufete SET nombreBufete = '" + nombre + "'," +
                    "idioma = '" + idioma + "'," +
                    "tema = '" + tema + "'," +
                    "logo = '" + logo + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static void insertarConfiguracion(string nombre, dal.DT dt)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO Bufete VALUES('" + nombre + "', 'Español', 'Papiro', '')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        
        }

        public static string obtenerNombre()
        {
            string nombre = null;

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT nombreBufete FROM Bufete";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while ( DataReader.Read() )
                nombre = DataReader.GetValue(0).ToString();
            
            DataReader.Close();
            Comando.Connection.Close();

            return nombre;

        }

        public static string obtenerLogo()
        {
            string logo = null;
            
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT logo FROM Bufete";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while ( DataReader.Read() )
                logo = DataReader.GetValue(0).ToString();

            DataReader.Close();
            Comando.Connection.Close();


            return logo;

        }
    }
}
