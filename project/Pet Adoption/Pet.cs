using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;

namespace Pet_Addaptation
{
    internal class Pet : Model
    {
        public string Id;
        public string Breed;
        public string Category;
        public string Age;
        public string Price;


        

        public void create()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("insert into Pet values (@Breed, @Category, @Age, @Price)", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Breed", Breed);
            sqlCommand.Parameters.AddWithValue("@Category", Category);
            sqlCommand.Parameters.AddWithValue("@Age", Age);
            sqlCommand.Parameters.AddWithValue("@Price", Price);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
            
        }
        public void update()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Update Pet set Breed = @Breed, Age = @Age, Price = @Price  where Id = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            sqlCommand.Parameters.AddWithValue("@Breed", Breed);
            sqlCommand.Parameters.AddWithValue("@Age", Age);
            sqlCommand.Parameters.AddWithValue("@Price", Price);
            sqlCommand.ExecuteNonQuery();

            sqlConnection.Close();
        }
        public void delete()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Delete from Pet where Id = @Id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public DataTable GetAll()
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("Select * from Pet", sqlConnection);
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
            SqlCommand sqlCommand = new SqlCommand("Select * from Pet where Breed like '%' + @Search + '%'", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@Search", search);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCommand);
            DataTable dataTable = new DataTable();
            sqlDataAdapter.Fill(dataTable);
            sqlConnection.Close();
            return dataTable;
        }
    }
}
