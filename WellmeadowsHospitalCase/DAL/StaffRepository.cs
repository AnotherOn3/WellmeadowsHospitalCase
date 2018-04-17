using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WellmeadowsHospitalCase.Models;

namespace WellmeadowsHospitalCase.DAL
{
    public class StaffRepository : BaseRepository
    {
        public void SaveStaffMember(Staff Staff)
        {
            SqlConnection connection = CreateConnection();

            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO Staff(FName, LName, StaffNumber, TypeOfShift, Address, PhoneNumber, DateOfBirth, Gender, Insurance, ContractId, PositionId, WardId) values(@FName, @LName, @StaffNumber, @TypeOfShift, @Address, @PhoneNumber, @DateOfBirth, @Gender, @Insurance, @ContractId, @PositionId, @WardId)";
                command.Parameters.Add("@FName", SqlDbType.NVarChar).Value = Staff.FName;
                command.Parameters.Add("@LName", SqlDbType.NVarChar).Value = Staff.LName;
                command.Parameters.Add("@StaffNumber", SqlDbType.Int).Value = Staff.StaffNumber;
                command.Parameters.Add("@TypeOfShift", SqlDbType.NVarChar).Value = Staff.TypeOfShift;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Staff.Address;
                command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = Staff.PhoneNumber;
                command.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = Staff.DateOfBirth;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Staff.Gender;
                command.Parameters.Add("@Insurance", SqlDbType.NVarChar).Value = Staff.Insurance;
                command.Parameters.Add("@ContractId", SqlDbType.Int).Value = Staff.ContractId;
                command.Parameters.Add("@PositionId", SqlDbType.Int).Value = Staff.PositionId;
                command.Parameters.Add("@WardId", SqlDbType.Int).Value = Staff.WardId;

                command.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }
        }
    }
}