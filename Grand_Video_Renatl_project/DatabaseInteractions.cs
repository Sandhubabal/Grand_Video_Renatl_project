using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grand_Video_Renatl_project
{
    public class DatabaseInteractions
    {
        // set data connection string
        public SqlConnection sqlConnection;

        public string connectionString = "Data Source=DESKTOP-LTQK306;Initial Catalog=Grand_Video_Store;Integrated Security=True";
        public SqlCommand sqlCommand;
        public SqlDataReader sqlDataReader;
        public void Operations(string query)
        {
            sqlConnection = new SqlConnection(connectionString);
            sqlConnection.Open();
            sqlCommand = new SqlCommand(query, sqlConnection);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }

        public DataTable DatabaseOperations(string qry)
        {
            DataTable dataTable = new DataTable();

            sqlConnection = new SqlConnection(connectionString);

            sqlConnection.Open();

            sqlCommand = new SqlCommand(qry, sqlConnection);

            sqlDataReader = sqlCommand.ExecuteReader();

            dataTable.Load(sqlDataReader);

            sqlConnection.Close();

            return dataTable;
        }
    }
}
