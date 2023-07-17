using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Addaptation
{
    internal class Vet : Model
    {
        public string Id;
        public string Name;
        public string Email;
        public string Time_Schedule;

        public void create()
        {
            sqlConnection.Open();
            SqlCommand cmd = new SqlCommand("insert into Veterin values (@Name, @Email, @Time_Schedule)", sqlConnection);
            cmd.Parameters.AddWithValue("@Name", Name);
            cmd.Parameters.AddWithValue("@Email", Email);
            cmd.Parameters.AddWithValue("@Time_Schedule", Time_Schedule);
            cmd.ExecuteNonQuery();

            sqlConnection.Close();
           
        }
        public void update()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Veterin set Name = @Name, Email = @Email, Time_Schedule = @Time_Schedule  where Id = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            sqlCommand.Parameters.AddWithValue("@Name", Name);
            sqlCommand.Parameters.AddWithValue("@Email", Email);
            sqlCommand.Parameters.AddWithValue("@Time_Schedule", Time_Schedule);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void delete()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete Veterin where Id = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetAll()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Veterin", sqlConnection);
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
            SqlCommand sqlCommand = new SqlCommand("Select * from Veterin where Name like '%' + @Search + '%'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Search", search);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }

    }
}
