using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccTestigo
    {
        public static void agregarTestigo(blc.Persona testigo)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO Testigo VALUES('" + testigo.ID + "','" + testigo.Nombre + "','" + testigo.Apellido + "','" +
                testigo.Nacionalidad + "','" + testigo.Edad + "','" + testigo.EstadoCivil + "','" + testigo.Domicilio + "','" +
                testigo.Telefono + "','" + testigo.Celular + "','" + testigo.Email + "','" + testigo.Foto + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }

        public static blc.Persona buscarTestigo(string id)
        {
            blc.Persona testigo = new blc.Persona();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Testigo WHERE ID = '" + id + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                testigo.ID = DataReader.GetValue(0).ToString();
                testigo.Nombre = DataReader.GetValue(1).ToString();
                testigo.Apellido = DataReader.GetValue(2).ToString();
                testigo.Nacionalidad = DataReader.GetValue(4).ToString();
                testigo.Edad = (int)DataReader.GetValue(5);
                testigo.EstadoCivil = DataReader.GetValue(6).ToString();
                testigo.Domicilio = DataReader.GetValue(7).ToString();
                testigo.Telefono = DataReader.GetValue(8).ToString();
                testigo.Celular = DataReader.GetValue(9).ToString();
                testigo.Email = DataReader.GetValue(10).ToString();
                testigo.Foto = DataReader.GetValue(11).ToString();                
            }
            DataReader.Close();
            Comando.Connection.Close();
            return testigo;
        }

        public static List<string> obtenerIDs()
        {
            List<string> ids = new List<string>();

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT ID FROM Testigo";

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

        public static bool testigoExiste(string id)
        {
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Testigo WHERE ID = '" + id + "'";

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
    }
}
