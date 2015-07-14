using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccEvidencia
    {
        public static void agregarEvidencia(blc.Evidencia evidencia)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO Evidencia VALUES('" + evidencia.Codigo + "','" + evidencia.Descripcion + "','" + evidencia.Caso + "','" +
                evidencia.Path + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static blc.Evidencia buscarEvidencia(string codigo)
        {
            blc.Evidencia evidencia = new blc.Evidencia();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Evidencia WHERE codigoEvidencia = '" + codigo + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                evidencia.Codigo = DataReader.GetValue(0).ToString();
                evidencia.Descripcion = DataReader.GetValue(1).ToString();
                evidencia.Caso = DataReader.GetValue(2).ToString();
                evidencia.Path = DataReader.GetValue(3).ToString();
            }
            DataReader.Close();
            Comando.Connection.Close();

            return evidencia;
        }

        public static bool existeEvidencia(string codigo)
        {
            blc.Evidencia evidencia = new blc.Evidencia();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Evidencia WHERE codigoEvidencia = '" + codigo + "'";

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

        public static List<string> obtenerIDs()
        {
            List<string> ids = new List<string>();

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT codigoEvidencia FROM Evidencia";

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
