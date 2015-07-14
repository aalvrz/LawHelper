using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class cctestigosCaso
    {

        public static void agregarTestigoACaso(blc.Caso caso, int testigo)
        {

            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO testigosCaso VALUES('" + caso.Testigos[testigo].ID + "','" + caso.NumAccion + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static List<blc.Persona> obtenerTestigosDeCaso(blc.Caso caso)
        {
            List<blc.Persona> testigos = new List<blc.Persona>();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT idTestigo FROM testigosCaso WHERE idCaso = '" + caso.NumAccion + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())            
                testigos.Add(new blc.Persona(DataReader.GetValue(0).ToString() ));

            DataReader.Close();
            Comando.Connection.Close();

            return testigos;
        }
    }
}
