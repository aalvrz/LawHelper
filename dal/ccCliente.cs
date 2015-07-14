using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccCliente
    {

        public static void agregarCliente(blc.Persona cliente)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query;
            
            query = "INSERT INTO Cliente VALUES('" + cliente.ID + "','" + cliente.Nombre + "','" + cliente.Apellido + "','" +
                cliente.Nacionalidad + "','" + cliente.Edad + "','" + cliente.EstadoCivil + "','" + cliente.Domicilio + "','" +
                cliente.Telefono + "','" + cliente.Celular + "','" + cliente.Email + "','" + cliente.Foto + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();
        }

        public static blc.Persona buscarCliente(string id)
        {
            blc.Persona cliente = new blc.Persona();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Cliente WHERE ID = '" + id + "'";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();
            
            while (DataReader.Read())
            {
                cliente.ID = DataReader.GetValue(0).ToString();
                cliente.Nombre = DataReader.GetValue(1).ToString();
                cliente.Apellido = DataReader.GetValue(2).ToString();                
                cliente.Nacionalidad = DataReader.GetValue(3).ToString();
                cliente.Edad = int.Parse(DataReader.GetValue(4).ToString());
                cliente.EstadoCivil = DataReader.GetValue(5).ToString();
                cliente.Domicilio = DataReader.GetValue(6).ToString();
                cliente.Telefono = DataReader.GetValue(7).ToString();
                cliente.Celular = DataReader.GetValue(8).ToString();
                cliente.Email = DataReader.GetValue(9).ToString();
                cliente.Foto = DataReader.GetValue(10).ToString();
            }
            DataReader.Close();
            Comando.Connection.Close();
            return cliente;
        }

        public static bool clienteExiste(string id)
        {
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Cliente WHERE ID = '" + id + "'";

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
            string query = "SELECT ID FROM Cliente";

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
