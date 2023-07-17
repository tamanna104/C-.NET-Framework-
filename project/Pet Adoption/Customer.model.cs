using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Addaptation
{
    internal class Customer : Model
    {
        public string Id;
        public string Name;
        public string Email;
        public string Address;

        public DataTable GetAll()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Customer", sqlConnection);
            sqlCommand.ExecuteNonQuery();
            DataTable dataTable = new DataTable();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
        public DataTable search(string search)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Customer where Name = @Search", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Search", search);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }

}
