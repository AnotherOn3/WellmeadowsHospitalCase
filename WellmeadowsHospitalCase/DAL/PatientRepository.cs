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

        public List<Patient> LoadAllPatients()
        {
            //Loading all the companies from the database - making the connection, creating and executing the command
            List<Patient> result = new List<Patient>();
            SqlConnection connection = CreateConnection();

            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, FName, LName, Address, PhoneNumber, Gender, MaritalStatus, RegisterDate, NextOfKinId, LocalDoctorId,IsOutpatient from Patient";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.Id = reader.GetInt32(0);
                    patient.FName = reader.GetString(1);
                    patient.LName = reader.GetString(2);
                    patient.Address = reader.GetString(3);
                    patient.PhoneNumber = reader.GetString(4);
                    patient.Gender = reader.GetString(5);
                    patient.MaritalStatus = reader.GetString(6);
                    patient.RegisterDate = reader.GetDateTime(7);
                    patient.NextOfKinId = reader.GetInt32(8);
                    patient.LocalDoctorId = reader.GetInt32(9);
                    patient.IsOutpatient = reader.GetBoolean(10);

                    result.Add(patient);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }


            return result;
        }

        public List<Patient> LoadAllOutPatients()
        {
            //Loading all the companies from the database - making the connection, creating and executing the command
            List<Patient> result = new List<Patient>();
            SqlConnection connection = CreateConnection();

            try
            {
                connection.Open();
                SqlCommand command = connection.CreateCommand();
                command.CommandText = "SELECT Id, FName, LName, Address, PhoneNumber, Gender, MaritalStatus, RegisterDate, NextOfKinId, LocalDoctorId,IsOutpatient from Patient WHERE IsOutpatient = 1";
                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Patient patient = new Patient();
                    patient.Id = reader.GetInt32(0);
                    patient.FName = reader.GetString(1);
                    patient.LName = reader.GetString(2);
                    patient.Address = reader.GetString(3);
                    patient.PhoneNumber = reader.GetString(4);
                    patient.Gender = reader.GetString(5);
                    patient.MaritalStatus = reader.GetString(6);
                    patient.RegisterDate = reader.GetDateTime(7);
                    patient.NextOfKinId = reader.GetInt32(8);
                    patient.LocalDoctorId = reader.GetInt32(9);
                    patient.IsOutpatient = reader.GetBoolean(10);

                    result.Add(patient);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            finally
            {
                connection.Close();
            }


            return result;
        }
    }
}