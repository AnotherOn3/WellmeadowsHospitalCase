using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using WellmeadowsHospitalCase.Models;

namespace WellmeadowsHospitalCase.DAL
{
    public class PatientRepository :BaseRepository
    {
        public void SavePatient(Patient Patient)
        {
            SqlConnection connection = CreateConnection();

            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();

                command.CommandText = "INSERT INTO Patient(FName, LName, Address, PhoneNumber, Gender, MaritalStatus, RegisterDate, NextOfKinId, LocalDoctorId,IsOutpatient) values(@FName, @LName, @Address, @PhoneNumber, @Gender, @MaritalStatus, @RegisterDate, @NextOfKinId, @LocalDoctorId, @IsOutpatient)";
                command.Parameters.Add("@FName", SqlDbType.NVarChar).Value = Patient.FName;
                command.Parameters.Add("@LName", SqlDbType.NVarChar).Value = Patient.LName;
                command.Parameters.Add("@Address", SqlDbType.NVarChar).Value = Patient.Address;
                command.Parameters.Add("@PhoneNumber", SqlDbType.NVarChar).Value = Patient.PhoneNumber;
                command.Parameters.Add("@Gender", SqlDbType.NVarChar).Value = Patient.Gender;
                command.Parameters.Add("@MaritalStatus", SqlDbType.NVarChar).Value = Patient.MaritalStatus;
                command.Parameters.Add("@RegisterDate", SqlDbType.Date).Value = Patient.RegisterDate;
                command.Parameters.Add("@NextOfKinId", SqlDbType.Int).Value = Patient.NextOfKinId;
                command.Parameters.Add("@LocalDoctorId", SqlDbType.Int).Value = Patient.LocalDoctorId;
                command.Parameters.Add("@IsOutpatient", SqlDbType.Bit).Value = Patient.IsOutpatient;


                command.ExecuteNonQuery();
            }
            catch (Exception ex)
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