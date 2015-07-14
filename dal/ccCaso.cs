using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccCaso
    {

        public static void agregarCaso(blc.Caso caso)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;
            
            query = "INSERT INTO Caso VALUES('" + caso.NumAccion + "','" + caso.Accion + "','" + caso.Materia +
                "','" + caso.Oficina + "','" + caso.Cliente.ID + "','" + "PARTE2" + "','" + caso.Observaciones + "')";
            
            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static blc.Caso obtenerCaso(string num)
        {
            blc.Caso caso = new blc.Caso();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Caso WHERE numAccion = '" + num + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                caso.NumAccion = DataReader.GetValue(0).ToString();
                caso.Accion = DataReader.GetValue(1).ToString();
                caso.Materia = DataReader.GetValue(2).ToString();
                caso.Oficina = DataReader.GetValue(3).ToString();
                caso.Cliente.ID = DataReader.GetValue(4).ToString();
                caso.Observaciones = DataReader.GetValue(6).ToString();
            }
            DataReader.Close();
            Comando.Connection.Close();
            return caso;
        }

        public static bool casoExiste(string num)
        {
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Caso WHERE numAccion = '" + num + "'";

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
            string query = "SELECT numAccion FROM Caso";

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
