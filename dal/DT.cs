using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace sistemaBufetes.dal
{
    public class DT
    {
        public static string connectionStr;

        private SqlConnection connection;

        public DT(string server)
        {
            if (server == null)
                connectionStr = "Server=.\\SQLEXPRESS; Database=BUFETE; Trusted_Connection=True"; // local
            else
                connectionStr = "Server=" + server + "\\SQLEXPRESS; Database=BUFETE; User Id=sa; Password=BufAdmin";
        }

        public void dbConnect()
        {
            connection = new SqlConnection();            
            connection.ConnectionString = connectionStr;

            try
            {
                /* Intentar establecer la connecion */
                connection.Open();
            }
            catch (Exception e)
            {                
                MessageBox.Show(e.Message);
                return;         
            }

            /* Definir el commando para utilizar la base de datos */
            System.Data.SqlClient.SqlCommand Command;
            Command = new System.Data.SqlClient.SqlCommand("USE BUFETE");
            Command.Connection = connection;

            /* Ejecutar el commando para utilizar la base de datos */
            Command.ExecuteReader();
            connection.Close();
        }        

        public SqlConnection Connecion
        {
            get { return connection; }
            set { connection = value; }
        }

        public string ConnectionStr
        {
            get { return connectionStr; }
            set { connectionStr = value; }
        }
    }
}
