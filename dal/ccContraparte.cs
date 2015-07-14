using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccContraparte
    {
        
        public static void agregarContraparte(blc.Persona contra)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO Contraparte VALUES('" + contra.ID + "','" + contra.Nombre + "','" + contra.Apellido + "','" +
                contra.Nacionalidad + "','" + contra.Edad + "','" + contra.EstadoCivil + "','" + contra.Domicilio + "','" +
                contra.Telefono + "','" + contra.Celular + "','" + contra.Email + "','" + contra.Foto + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }
        
        public static List<string> obtenerIDs()
        {
            List<string> ids = new List<string>();

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT ID FROM Contraparte";

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
