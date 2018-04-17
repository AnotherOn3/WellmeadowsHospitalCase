using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace WellmeadowsHospitalCase.DAL
{

    public class BaseRepository
    {
        //This is my base repository
        protected SqlConnection CreateConnection()
        {
            SqlConnection connection = new SqlConnection();
            connection = new SqlConnection();
            connection.ConnectionString = "Server=localhost;Database=WellmeadowsHospitalCase;Integrated Security=SSPI;";
            return connection;
        }
    }
}