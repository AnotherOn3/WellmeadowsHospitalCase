using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WellmeadowsHospitalCase.Models;

namespace WellmeadowsHospitalCase.DAL
{
    public class PositionRepository : BaseRepository
    {
        public Position LoadPosition(int id)
        {
            Position result = new Position();
            SqlConnection connection = CreateConnection();
                try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, Name FROM Position WHERE id= " + id;

                SqlDataReader reader = command.ExecuteReader();

                reader.Read();
                Position position = new Position();
                position.Id = reader.GetInt32(0);
                position.Name = reader.GetString(1);

               result = position;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally{
                connection.Close();
            }
            return result;
        }
    }
}