using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sistemaBufetes.dal
{
    public class ccGrupo
    {
        public static List<blc.Grupo> obtenerGrupos()
        {
            List<blc.Grupo> grupos = new List<blc.Grupo>();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT Codigo, Nombre FROM Grupo";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
                grupos.Add(new blc.Grupo( (int)DataReader.GetValue(0), DataReader.GetValue(1).ToString()));                          

            DataReader.Close();
            Comando.Connection.Close();
            return grupos;
        }

        public static blc.Grupo obtenerGrupo(string nombreGrupo, string codigoGrupo)
        {
            blc.Grupo grupo = new blc.Grupo();
            System.Data.SqlClient.SqlCommand Comando;
            System.Data.SqlClient.SqlDataReader DataReader;
            string query = "SELECT * FROM Grupo WHERE Nombre = '" + nombreGrupo + "' OR Codigo = '" + codigoGrupo + "'";
            
            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            DataReader = Comando.ExecuteReader();

            while (DataReader.Read())
            {
                grupo.Codigo = (int)DataReader.GetValue(0);
                grupo.Nombre = DataReader.GetValue(1).ToString();
                grupo.PermisoGestion = DataReader.GetValue(2).ToString();
                grupo.PermisoCasos = DataReader.GetValue(3).ToString();
                grupo.PermisoClientes = DataReader.GetValue(4).ToString();
                grupo.PermisoTestigos = DataReader.GetValue(5).ToString();
                grupo.PermisoInventario = DataReader.GetValue(6).ToString();
                grupo.PermisoEvidencia = DataReader.GetValue(7).ToString();
                grupo.PermisoReportes = DataReader.GetValue(8).ToString();
                grupo.PermisoConfiguracion = DataReader.GetValue(9).ToString();
            }

            DataReader.Close();
            Comando.Connection.Close();
            return grupo;
        }       
       
        public static void agregarGrupo(blc.Grupo grupo)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query = "INSERT INTO Grupo VALUES('" + grupo.Codigo + "','" + grupo.Nombre +
                "','" + grupo.PermisoGestion + "','" + grupo.PermisoCasos + "','" + grupo.PermisoClientes + 
                "','" + grupo.PermisoTestigos + "','" + grupo.PermisoInventario + "','" + grupo.PermisoEvidencia + "','" + grupo.PermisoReportes + "','" + grupo.PermisoConfiguracion + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = Program.dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }

        public static void agregarGrupoPredeterminado(blc.Grupo grupo, dal.DT dt)
        {
            System.Data.SqlClient.SqlCommand Comando;
            string query = "INSERT INTO Grupo VALUES('" + grupo.Codigo + "','" + grupo.Nombre +
                "','" + grupo.PermisoGestion + "','" + grupo.PermisoCasos + "','" + grupo.PermisoClientes +
                "','" + grupo.PermisoTestigos + "','" + grupo.PermisoInventario + "','" + grupo.PermisoEvidencia + "','" + grupo.PermisoReportes + "','" + grupo.PermisoConfiguracion + "')";

            Comando = new System.Data.SqlClient.SqlCommand(query);
            Comando.Connection = dt.Connecion;
            Comando.Connection.Open();
            Comando.ExecuteNonQuery();
            Comando.Connection.Close();

        }
    }
}
