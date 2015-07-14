using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccArticulo
    {
        public static List<string> obtenerIds()
        {
            List<string> ids = new List<string>();

            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT codigoArticulo FROM Articulo";

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

        public static void agregarArticulo(blc.Articulo articulo)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;

            query = "INSERT INTO Articulo VALUES('" + articulo.Codigo + "','" + articulo.Nombre + "','" + articulo.Costo + "','" +
                articulo.Ubicacion + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static blc.Articulo buscarArticulo(string codigo)
        {
            blc.Articulo articulo = new blc.Articulo();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Articulo WHERE codigoArticulo = '" + codigo + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                articulo.Codigo = DataReader.GetValue(0).ToString();
                articulo.Nombre = DataReader.GetValue(1).ToString();
                articulo.Costo = double.Parse(DataReader.GetValue(2).ToString());
                articulo.Ubicacion = DataReader.GetValue(3).ToString();
            }
            DataReader.Close();
            Comando.Connection.Close();

            return articulo;
        }

    }
}
