using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Pet_Addaptation
{
    internal class Model
    {
        protected SqlConnection sqlConnection = new SqlConnection(@"Data Source=DESKTOP-GV4UO3F\SQLEXPRESS;Initial Catalog=petShop;Integrated Security=True");
    }
}
