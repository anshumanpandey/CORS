using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using NHS.Common;
using NHS.Common.DTO;


namespace NHS.Data
{
    public class DBEngine
    {
        private static SqlConnection _connection = null;
        private static SqlCommand command = null;
        private string connectionString = string.Empty;
        public DBEngine(string connectionString) { this.connectionString = connectionString; }

        private SqlConnection GetConnection()
        {
            if (_connection == null)
                _connection = new SqlConnection(connectionString);
            else if (_connection.State == ConnectionState.Closed)
                _connection.ConnectionString = connectionString;

            if (_connection.State != ConnectionState.Open)
                _connection.Open();
            return _connection;
        }

        /// <summary>
        /// This method brings in all patient lists or brings in a specific patient information based on the
        /// nhs number.
        /// </summary>
        /// <param name="nhsNumber">string</param>
        /// <returns>List<clsPatientDetails>Patient Details List</returns>
        public List<clsPatientDetails> GetPatientDetails(int? patientID, int userID)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            List <clsPatientDetails> lstPatientDetails = new List<clsPatientDetails>();
            try
            {   
                SqlCommand dbCmd = new SqlCommand("usp_GetPatientDashboardDetails", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (patientID != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", patientID);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", 0);
                dbCmd.Parameters.AddWithValue("@UserID", userID);

                dbReader = dbCmd.ExecuteReader();
                while (dbReader.Read())
                {
                    clsPatientDetails patientDashboard = new clsPatientDetails();
                    if (string.IsNullOrEmpty(dbReader["ID"].ToString()))
                        patientDashboard.ID = 0;
                    else
                        patientDashboard.ID = Convert.ToInt32(dbReader["ID"]);
                    if (string.IsNullOrEmpty(dbReader["PatientId"].ToString()))
                        patientDashboard.PatientId = "";
                    else
                        patientDashboard.PatientId = Convert.ToString(dbReader["PatientId"]);
                    if (string.IsNullOrEmpty(dbReader["SpellNumber"].ToString()))
                        patientDashboard.SpellNumber = 0;
                    else
                        patientDashboard.SpellNumber = Convert.ToInt32(dbReader["SpellNumber"]);
                    if (string.IsNullOrEmpty(dbReader["NHSNumber"].ToString()))
                        patientDashboard.NHSNumber = "";
                    else
                        patientDashboard.NHSNumber = Convert.ToString(dbReader["NHSNumber"]);
                    if (string.IsNullOrEmpty(dbReader["PatientName"].ToString()))
                        patientDashboard.PatientName = "";
                    else
                        patientDashboard.PatientName = Convert.ToString(dbReader["PatientName"]);
                    if (string.IsNullOrEmpty(dbReader["DOB"].ToString()))
                        patientDashboard.DOB = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DOB = Convert.ToDateTime(dbReader["DOB"]);
                    if (string.IsNullOrEmpty(dbReader["DateOfAdmission"].ToString()))
                        patientDashboard.DateofAdmission = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofAdmission = Convert.ToDateTime(dbReader["DateOfAdmission"]);
                    if (string.IsNullOrEmpty(dbReader["DateOfDeath"].ToString()))
                        patientDashboard.DateofDeath = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofDeath = Convert.ToDateTime(dbReader["DateOfDeath"]);
                    if (string.IsNullOrEmpty(dbReader["WardOfDeath"].ToString()))
                        patientDashboard.WardofDeath = "0";
                    else
                        patientDashboard.WardofDeath = Convert.ToString(dbReader["WardOfDeath"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeConsultantName"].ToString()))
                        patientDashboard.DischargeConsutantName = "";
                    else
                        patientDashboard.DischargeConsutantName = Convert.ToString(dbReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dbReader["AdmissionType"].ToString()))
                        patientDashboard.AdmissionType = "";
                    else
                        patientDashboard.AdmissionType = Convert.ToString(dbReader["AdmissionType"]);
                    if (string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        patientDashboard.MedTriage = 2;
                    else
                        patientDashboard.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    if (string.IsNullOrEmpty(dbReader["SJR1"].ToString()))
                        patientDashboard.SJR1 = 0;
                    else
                        patientDashboard.SJR1 = Convert.ToInt32(dbReader["SJR1"]);
                    if(string.IsNullOrEmpty(dbReader["SJR2"].ToString()))
                        patientDashboard.SJR2 = 0;
                    else
                        patientDashboard.SJR2 = Convert.ToInt32(dbReader["SJR2"]);
                    if (string.IsNullOrEmpty(dbReader["SJROutcome"].ToString()))
                        patientDashboard.SJROutcome = 0;
                    else
                        patientDashboard.SJROutcome = Convert.ToInt32(dbReader["SJROutcome"]);
                    if (string.IsNullOrEmpty(dbReader["QAPReview"].ToString()))
                        patientDashboard.QAPReview = 2;
                    else
                        patientDashboard.QAPReview = Convert.ToInt32(dbReader["QAPReview"]);
                    if (string.IsNullOrEmpty(dbReader["CodingReview"].ToString()))
                        patientDashboard.CodingReview = 2;
                    else
                        patientDashboard.CodingReview = Convert.ToInt32(dbReader["CodingReview"]);
                    if (string.IsNullOrEmpty(dbReader["Age"].ToString()))
                        patientDashboard.Age = 0;
                    else
                        patientDashboard.Age = Convert.ToInt32(dbReader["Age"]);
                    if (string.IsNullOrEmpty(dbReader["Gender"].ToString()))
                        patientDashboard.Gender = "";
                    else
                        patientDashboard.Gender = Convert.ToString(dbReader["Gender"]);
                    if (string.IsNullOrEmpty(dbReader["TimeofAdmission"].ToString()))
                        patientDashboard.TimeofAdmission = "";
                    else
                        patientDashboard.TimeofAdmission = Convert.ToDateTime(dbReader["TimeofAdmission"].ToString()).ToString("HH:mm");
                    if (!string.IsNullOrEmpty(dbReader["TimeOfDeath"].ToString()))
                        patientDashboard.TimeofDeath = Convert.ToDateTime(dbReader["TimeOfDeath"].ToString()).ToString("HH:mm");
                    else
                        patientDashboard.TimeofDeath = "";
                    if (string.IsNullOrEmpty(dbReader["DischargeWard"].ToString()))
                        patientDashboard.DischargeWard = "0";
                    else
                        patientDashboard.DischargeWard = Convert.ToString(dbReader["DischargeWard"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeConsultantCode"].ToString()))
                        patientDashboard.DischargeConsultantCode = "0";
                    else
                        patientDashboard.DischargeConsultantCode = Convert.ToString(dbReader["DischargeConsultantCode"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeSpecialityCode"].ToString()))
                        patientDashboard.DischargeSpecialtyCode = "0";
                    else
                        patientDashboard.DischargeSpecialtyCode = Convert.ToString(dbReader["DischargeSpecialityCode"]);
                    if(string.IsNullOrEmpty(dbReader["DischargeSpeciality"].ToString()))
                        patientDashboard.DischargeSpeciality = "";
                    else
                        patientDashboard.DischargeSpeciality = Convert.ToString(dbReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dbReader["Caregroup"].ToString()))
                        patientDashboard.Caregroup = "";
                    else
                        patientDashboard.Caregroup = Convert.ToString(dbReader["Caregroup"]);
                    if (string.IsNullOrEmpty(dbReader["ComorbiditiesCount"].ToString()))
                        patientDashboard.ComorbiditiesCount = 0;
                    else
                        patientDashboard.ComorbiditiesCount = Convert.ToInt32(dbReader["ComorbiditiesCount"]);
                    if (string.IsNullOrEmpty(dbReader["IsFullSJRRequired"].ToString()))
                        patientDashboard.IsFullSJRRequired = false;
                    else
                        patientDashboard.IsFullSJRRequired = Convert.ToBoolean(dbReader["IsFullSJRRequired"]);
                    if (string.IsNullOrEmpty(dbReader["Stage2SJRRequired"].ToString()))
                        patientDashboard.Stage2SJRRequired = false;
                    else
                        patientDashboard.Stage2SJRRequired = Convert.ToBoolean(dbReader["Stage2SJRRequired"]);
                    if (string.IsNullOrEmpty(dbReader["Occupation"].ToString()))
                        patientDashboard.Occupation = "";
                    else
                        patientDashboard.Occupation = Convert.ToString(dbReader["Occupation"]);
                    if (string.IsNullOrEmpty(dbReader["UserRole"].ToString()))
                        patientDashboard.UserRole = "";
                    else
                        patientDashboard.UserRole = Convert.ToString(dbReader["UserRole"]);
                    if (string.IsNullOrEmpty(dbReader["PatientType"].ToString()))
                        patientDashboard.PatientType = "AAPC";
                    else
                        patientDashboard.PatientType = Convert.ToString(dbReader["PatientType"]);
                    if (string.IsNullOrEmpty(dbReader["PatientTypeLongText"].ToString()))
                        patientDashboard.PatientTypeLongText = "Adult Inpatients";
                    else
                        patientDashboard.PatientTypeLongText = Convert.ToString(dbReader["PatientTypeLongText"]);
                    if (string.IsNullOrEmpty(dbReader["QAPCount"].ToString()))
                        patientDashboard.QAPCount = 0;
                    else
                        patientDashboard.QAPCount = Convert.ToInt32(dbReader["QAPCount"]);
                    if (string.IsNullOrEmpty(dbReader["MedCount"].ToString()))
                        patientDashboard.MedCount = 0;
                    else
                        patientDashboard.MedCount = Convert.ToInt32(dbReader["MedCount"]);
                    lstPatientDetails.Add(patientDashboard);
                }
                LogException("After loop", this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            return lstPatientDetails;
        }

        /// <summary>
        /// This method brings in all patient lists or brings in a specific patient information based on the
        /// nhs number.
        /// </summary>
        /// <param name="nhsNumber">string</param>
        /// <returns>List<clsPatientDetails>Patient Details List</returns>
        public List<clsPatientDetails> GetPatientDetailsByQAP(int? patientID, int userID, DateTime startDate, DateTime endDate, string dischargeConsultantCode, string wardOfDeath, string dischargeSpecialityCode, string patientType)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<clsPatientDetails> lstPatientDetails = new List<clsPatientDetails>();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetPatientDashboardDetailsByQAP", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (patientID != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", patientID);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", 0);
                dbCmd.Parameters.AddWithValue("@UserID", userID);

                if (startDate != null)
                    dbCmd.Parameters.AddWithValue("@StartDate", startDate);
                else
                    dbCmd.Parameters.AddWithValue("@StartDate", "");
                if (endDate != null)
                    dbCmd.Parameters.AddWithValue("@EndDate", endDate);
                else
                    dbCmd.Parameters.AddWithValue("@EndDate", "");
                if (dischargeConsultantCode != null)
                    dbCmd.Parameters.AddWithValue("@DischargeConsultantCode", dischargeConsultantCode);
                else
                    dbCmd.Parameters.AddWithValue("@DischargeConsultantCode", "");
                if (wardOfDeath != null)
                    dbCmd.Parameters.AddWithValue("@WardOfDeath", wardOfDeath);
                else
                    dbCmd.Parameters.AddWithValue("@WardOfDeath", "");
                if (dischargeSpecialityCode != null)
                    dbCmd.Parameters.AddWithValue("@DischargeSpecialityCode", dischargeSpecialityCode);
                else
                    dbCmd.Parameters.AddWithValue("@DischargeSpecialityCode", "");
                if (patientType != null)
                    dbCmd.Parameters.AddWithValue("@PatientType", patientType);
                else
                    dbCmd.Parameters.AddWithValue("@PatientType", "");

                dataReader = dbCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    clsPatientDetails patientDashboard = new clsPatientDetails();
                    if (string.IsNullOrEmpty(dataReader["ID"].ToString()))
                        patientDashboard.ID = 0;
                    else
                        patientDashboard.ID = Convert.ToInt32(dataReader["ID"]);
                    if (string.IsNullOrEmpty(dataReader["PatientId"].ToString()))
                        patientDashboard.PatientId = "";
                    else
                        patientDashboard.PatientId = Convert.ToString(dataReader["PatientId"]);
                    if (string.IsNullOrEmpty(dataReader["SpellNumber"].ToString()))
                        patientDashboard.SpellNumber = 0;
                    else
                        patientDashboard.SpellNumber = Convert.ToInt32(dataReader["SpellNumber"]);
                    if (string.IsNullOrEmpty(dataReader["NHSNumber"].ToString()))
                        patientDashboard.NHSNumber = "";
                    else
                        patientDashboard.NHSNumber = Convert.ToString(dataReader["NHSNumber"]);
                    if (string.IsNullOrEmpty(dataReader["PatientName"].ToString()))
                        patientDashboard.PatientName = "";
                    else
                        patientDashboard.PatientName = Convert.ToString(dataReader["PatientName"]);
                    if (string.IsNullOrEmpty(dataReader["DOB"].ToString()))
                        patientDashboard.DOB = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DOB = Convert.ToDateTime(dataReader["DOB"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfAdmission"].ToString()))
                        patientDashboard.DateofAdmission = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofAdmission = Convert.ToDateTime(dataReader["DateOfAdmission"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfDeath"].ToString()))
                        patientDashboard.DateofDeath = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofDeath = Convert.ToDateTime(dataReader["DateOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["WardOfDeath"].ToString()))
                        patientDashboard.WardofDeath = "0";
                    else
                        patientDashboard.WardofDeath = Convert.ToString(dataReader["WardOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantName"].ToString()))
                        patientDashboard.DischargeConsutantName = "";
                    else
                        patientDashboard.DischargeConsutantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dataReader["AdmissionType"].ToString()))
                        patientDashboard.AdmissionType = "";
                    else
                        patientDashboard.AdmissionType = Convert.ToString(dataReader["AdmissionType"]);
                    if (string.IsNullOrEmpty(dataReader["MedTriage"].ToString()))
                        patientDashboard.MedTriage = 2;
                    else
                        patientDashboard.MedTriage = Convert.ToInt32(dataReader["MedTriage"]);
                    if (string.IsNullOrEmpty(dataReader["SJR1"].ToString()))
                        patientDashboard.SJR1 = 0;
                    else
                        patientDashboard.SJR1 = Convert.ToInt32(dataReader["SJR1"]);
                    if (string.IsNullOrEmpty(dataReader["SJR2"].ToString()))
                        patientDashboard.SJR2 = 0;
                    else
                        patientDashboard.SJR2 = Convert.ToInt32(dataReader["SJR2"]);
                    if (string.IsNullOrEmpty(dataReader["SJROutcome"].ToString()))
                        patientDashboard.SJROutcome = 0;
                    else
                        patientDashboard.SJROutcome = Convert.ToInt32(dataReader["SJROutcome"]);
                    if (string.IsNullOrEmpty(dataReader["QAPReview"].ToString()))
                        patientDashboard.QAPReview = 2;
                    else
                        patientDashboard.QAPReview = Convert.ToInt32(dataReader["QAPReview"]);
                    if (string.IsNullOrEmpty(dataReader["CodingReview"].ToString()))
                        patientDashboard.CodingReview = 2;
                    else
                        patientDashboard.CodingReview = Convert.ToInt32(dataReader["CodingReview"]);
                    if (string.IsNullOrEmpty(dataReader["Age"].ToString()))
                        patientDashboard.Age = 0;
                    else
                        patientDashboard.Age = Convert.ToInt32(dataReader["Age"]);
                    if (string.IsNullOrEmpty(dataReader["Gender"].ToString()))
                        patientDashboard.Gender = "";
                    else
                        patientDashboard.Gender = Convert.ToString(dataReader["Gender"]);
                    if (string.IsNullOrEmpty(dataReader["TimeofAdmission"].ToString()))
                        patientDashboard.TimeofAdmission = "";
                    else
                        patientDashboard.TimeofAdmission = Convert.ToDateTime(dataReader["TimeofAdmission"].ToString()).ToString("HH:mm");
                    if (!string.IsNullOrEmpty(dataReader["TimeOfDeath"].ToString()))
                        patientDashboard.TimeofDeath = Convert.ToDateTime(dataReader["TimeOfDeath"].ToString()).ToString("HH:mm");
                    else
                        patientDashboard.TimeofDeath = "";
                    if (string.IsNullOrEmpty(dataReader["DischargeWard"].ToString()))
                        patientDashboard.DischargeWard = "0";
                    else
                        patientDashboard.DischargeWard = Convert.ToString(dataReader["DischargeWard"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantCode"].ToString()))
                        patientDashboard.DischargeConsultantCode = "0";
                    else
                        patientDashboard.DischargeConsultantCode = Convert.ToString(dataReader["DischargeConsultantCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpecialityCode"].ToString()))
                        patientDashboard.DischargeSpecialtyCode = "0";
                    else
                        patientDashboard.DischargeSpecialtyCode = Convert.ToString(dataReader["DischargeSpecialityCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpeciality"].ToString()))
                        patientDashboard.DischargeSpeciality = "";
                    else
                        patientDashboard.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dataReader["Caregroup"].ToString()))
                        patientDashboard.Caregroup = "";
                    else
                        patientDashboard.Caregroup = Convert.ToString(dataReader["Caregroup"]);
                    if (string.IsNullOrEmpty(dataReader["ComorbiditiesCount"].ToString()))
                        patientDashboard.ComorbiditiesCount = 0;
                    else
                        patientDashboard.ComorbiditiesCount = Convert.ToInt32(dataReader["ComorbiditiesCount"]);
                    if (string.IsNullOrEmpty(dataReader["IsFullSJRRequired"].ToString()))
                        patientDashboard.IsFullSJRRequired = false;
                    else
                        patientDashboard.IsFullSJRRequired = Convert.ToBoolean(dataReader["IsFullSJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["Stage2SJRRequired"].ToString()))
                        patientDashboard.Stage2SJRRequired = false;
                    else
                        patientDashboard.Stage2SJRRequired = Convert.ToBoolean(dataReader["Stage2SJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["PatientType"].ToString()))
                        patientDashboard.PatientType = "AAPC";
                    else
                        patientDashboard.PatientType = Convert.ToString(dataReader["PatientType"]);
                    if (string.IsNullOrEmpty(dataReader["PatientTypeLongText"].ToString()))
                        patientDashboard.PatientTypeLongText = "Adult Inpatients";
                    else
                        patientDashboard.PatientTypeLongText = Convert.ToString(dataReader["PatientTypeLongText"]);
                    if (string.IsNullOrEmpty(dataReader["QAPCount"].ToString()))
                        patientDashboard.QAPCount = 0;
                    else
                        patientDashboard.QAPCount = Convert.ToInt32(dataReader["QAPCount"]);
                    if (string.IsNullOrEmpty(dataReader["MedCount"].ToString()))
                        patientDashboard.MedCount = 0;
                    else
                        patientDashboard.MedCount = Convert.ToInt32(dataReader["MedCount"]);
                    lstPatientDetails.Add(patientDashboard);
                }
                LogException("After loop", this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return lstPatientDetails;
        }

        /// <summary>
        /// This method brings in all patient lists or brings in a specific patient information based on the
        /// nhs number.
        /// </summary>
        /// <param name="nhsNumber">string</param>
        /// <returns>List<clsPatientDetails>Patient Details List</returns>
        public List<clsPatientDetails> GetPatientDetailsByMedTriage(int? patientID, int userID, DateTime startDate, DateTime endDate, string dischargeConsultantCode, string wardOfDeath, string dischargeSpecialityCode, string patientType)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<clsPatientDetails> lstPatientDetails = new List<clsPatientDetails>();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetPatientDashboardDetailsByMedTriage", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (patientID != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", patientID);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", 0);
                dbCmd.Parameters.AddWithValue("@UserID", userID);

                if (startDate != null)
                    dbCmd.Parameters.AddWithValue("@StartDate", startDate);
                else
                    dbCmd.Parameters.AddWithValue("@StartDate", "");
                if (endDate != null)
                    dbCmd.Parameters.AddWithValue("@EndDate", endDate);
                else
                    dbCmd.Parameters.AddWithValue("@EndDate", "");
                if (dischargeConsultantCode != null)
                    dbCmd.Parameters.AddWithValue("@DischargeConsultantCode", dischargeConsultantCode);
                else
                    dbCmd.Parameters.AddWithValue("@DischargeConsultantCode", "");
                if (wardOfDeath != null)
                    dbCmd.Parameters.AddWithValue("@WardOfDeath", wardOfDeath);
                else
                    dbCmd.Parameters.AddWithValue("@WardOfDeath", "");
                if (dischargeSpecialityCode != null)
                    dbCmd.Parameters.AddWithValue("@DischargeSpecialityCode", dischargeSpecialityCode);
                else
                    dbCmd.Parameters.AddWithValue("@DischargeSpecialityCode", "");
                if (patientType != null)
                    dbCmd.Parameters.AddWithValue("@PatientType", patientType);
                else
                    dbCmd.Parameters.AddWithValue("@PatientType", "");

                dataReader = dbCmd.ExecuteReader();
                while (dataReader.Read())
                {
                    clsPatientDetails patientDashboard = new clsPatientDetails();
                    if (string.IsNullOrEmpty(dataReader["ID"].ToString()))
                        patientDashboard.ID = 0;
                    else
                        patientDashboard.ID = Convert.ToInt32(dataReader["ID"]);
                    if (string.IsNullOrEmpty(dataReader["PatientId"].ToString()))
                        patientDashboard.PatientId = "";
                    else
                        patientDashboard.PatientId = Convert.ToString(dataReader["PatientId"]);
                    if (string.IsNullOrEmpty(dataReader["SpellNumber"].ToString()))
                        patientDashboard.SpellNumber = 0;
                    else
                        patientDashboard.SpellNumber = Convert.ToInt32(dataReader["SpellNumber"]);
                    if (string.IsNullOrEmpty(dataReader["NHSNumber"].ToString()))
                        patientDashboard.NHSNumber = "";
                    else
                        patientDashboard.NHSNumber = Convert.ToString(dataReader["NHSNumber"]);
                    if (string.IsNullOrEmpty(dataReader["PatientName"].ToString()))
                        patientDashboard.PatientName = "";
                    else
                        patientDashboard.PatientName = Convert.ToString(dataReader["PatientName"]);
                    if (string.IsNullOrEmpty(dataReader["DOB"].ToString()))
                        patientDashboard.DOB = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DOB = Convert.ToDateTime(dataReader["DOB"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfAdmission"].ToString()))
                        patientDashboard.DateofAdmission = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofAdmission = Convert.ToDateTime(dataReader["DateOfAdmission"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfDeath"].ToString()))
                        patientDashboard.DateofDeath = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofDeath = Convert.ToDateTime(dataReader["DateOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["WardOfDeath"].ToString()))
                        patientDashboard.WardofDeath = "0";
                    else
                        patientDashboard.WardofDeath = Convert.ToString(dataReader["WardOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantName"].ToString()))
                        patientDashboard.DischargeConsutantName = "";
                    else
                        patientDashboard.DischargeConsutantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dataReader["AdmissionType"].ToString()))
                        patientDashboard.AdmissionType = "";
                    else
                        patientDashboard.AdmissionType = Convert.ToString(dataReader["AdmissionType"]);
                    if (string.IsNullOrEmpty(dataReader["MedTriage"].ToString()))
                        patientDashboard.MedTriage = 2;
                    else
                        patientDashboard.MedTriage = Convert.ToInt32(dataReader["MedTriage"]);
                    if (string.IsNullOrEmpty(dataReader["SJR1"].ToString()))
                        patientDashboard.SJR1 = 0;
                    else
                        patientDashboard.SJR1 = Convert.ToInt32(dataReader["SJR1"]);
                    if (string.IsNullOrEmpty(dataReader["SJR2"].ToString()))
                        patientDashboard.SJR2 = 0;
                    else
                        patientDashboard.SJR2 = Convert.ToInt32(dataReader["SJR2"]);
                    if (string.IsNullOrEmpty(dataReader["SJROutcome"].ToString()))
                        patientDashboard.SJROutcome = 0;
                    else
                        patientDashboard.SJROutcome = Convert.ToInt32(dataReader["SJROutcome"]);
                    if (string.IsNullOrEmpty(dataReader["QAPReview"].ToString()))
                        patientDashboard.QAPReview = 2;
                    else
                        patientDashboard.QAPReview = Convert.ToInt32(dataReader["QAPReview"]);
                    if (string.IsNullOrEmpty(dataReader["CodingReview"].ToString()))
                        patientDashboard.CodingReview = 2;
                    else
                        patientDashboard.CodingReview = Convert.ToInt32(dataReader["CodingReview"]);
                    if (string.IsNullOrEmpty(dataReader["Age"].ToString()))
                        patientDashboard.Age = 0;
                    else
                        patientDashboard.Age = Convert.ToInt32(dataReader["Age"]);
                    if (string.IsNullOrEmpty(dataReader["Gender"].ToString()))
                        patientDashboard.Gender = "";
                    else
                        patientDashboard.Gender = Convert.ToString(dataReader["Gender"]);
                    if (string.IsNullOrEmpty(dataReader["TimeofAdmission"].ToString()))
                        patientDashboard.TimeofAdmission = "";
                    else
                        patientDashboard.TimeofAdmission = Convert.ToDateTime(dataReader["TimeofAdmission"].ToString()).ToString("HH:mm");
                    if (!string.IsNullOrEmpty(dataReader["TimeOfDeath"].ToString()))
                        patientDashboard.TimeofDeath = Convert.ToDateTime(dataReader["TimeOfDeath"].ToString()).ToString("HH:mm");
                    else
                        patientDashboard.TimeofDeath = "";
                    if (string.IsNullOrEmpty(dataReader["DischargeWard"].ToString()))
                        patientDashboard.DischargeWard = "0";
                    else
                        patientDashboard.DischargeWard = Convert.ToString(dataReader["DischargeWard"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantCode"].ToString()))
                        patientDashboard.DischargeConsultantCode = "0";
                    else
                        patientDashboard.DischargeConsultantCode = Convert.ToString(dataReader["DischargeConsultantCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpecialityCode"].ToString()))
                        patientDashboard.DischargeSpecialtyCode = "0";
                    else
                        patientDashboard.DischargeSpecialtyCode = Convert.ToString(dataReader["DischargeSpecialityCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpeciality"].ToString()))
                        patientDashboard.DischargeSpeciality = "";
                    else
                        patientDashboard.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dataReader["Caregroup"].ToString()))
                        patientDashboard.Caregroup = "";
                    else
                        patientDashboard.Caregroup = Convert.ToString(dataReader["Caregroup"]);
                    if (string.IsNullOrEmpty(dataReader["ComorbiditiesCount"].ToString()))
                        patientDashboard.ComorbiditiesCount = 0;
                    else
                        patientDashboard.ComorbiditiesCount = Convert.ToInt32(dataReader["ComorbiditiesCount"]);
                    if (string.IsNullOrEmpty(dataReader["IsFullSJRRequired"].ToString()))
                        patientDashboard.IsFullSJRRequired = false;
                    else
                        patientDashboard.IsFullSJRRequired = Convert.ToBoolean(dataReader["IsFullSJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["Stage2SJRRequired"].ToString()))
                        patientDashboard.Stage2SJRRequired = false;
                    else
                        patientDashboard.Stage2SJRRequired = Convert.ToBoolean(dataReader["Stage2SJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["PatientType"].ToString()))
                        patientDashboard.PatientType = "AAPC";
                    else
                        patientDashboard.PatientType = Convert.ToString(dataReader["PatientType"]);
                    if (string.IsNullOrEmpty(dataReader["QAPCount"].ToString()))
                        patientDashboard.QAPCount = 0;
                    else
                        patientDashboard.QAPCount = Convert.ToInt32(dataReader["QAPCount"]);
                    if (string.IsNullOrEmpty(dataReader["PatientTypeLongText"].ToString()))
                        patientDashboard.PatientTypeLongText = "Adult Inpatients";
                    else
                        patientDashboard.PatientTypeLongText = Convert.ToString(dataReader["PatientTypeLongText"]);
                    if (string.IsNullOrEmpty(dataReader["MedCount"].ToString()))
                        patientDashboard.MedCount = 0;
                    else
                        patientDashboard.MedCount = Convert.ToInt32(dataReader["MedCount"]);
                    lstPatientDetails.Add(patientDashboard);
                }
                LogException("After loop", this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return lstPatientDetails;
        }

        /// <summary>
        /// This method brings in all patient lists or brings in a specific patient information based on the
        /// nhs number.
        /// </summary>
        /// <param name="nhsNumber">string</param>
        /// <returns>List<clsPatientDetails>Patient Details List</returns>
        public List<clsPatientDetails> GetPatientDetailsByID(int? id, int userID)
        {
            var connection = GetConnection();
            IDataReader dbReader = null;
            List<clsPatientDetails> lstPatientDetails = new List<clsPatientDetails>();
            List<NextOfKin> lstNextOfKin = new List<NextOfKin>();
            clsPatientDetails patientDashboard = new clsPatientDetails();
            NextOfKin nextOfkin;
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetPatientDetailsByID", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);
                dbCmd.Parameters.AddWithValue("@UserID", userID);

                dbReader = dbCmd.ExecuteReader();
                
                while (dbReader.Read())
                {                    
                    if (string.IsNullOrEmpty(dbReader["ID"].ToString()))
                        patientDashboard.ID = 0;
                    else
                        patientDashboard.ID = Convert.ToInt32(dbReader["ID"]);
                    if (string.IsNullOrEmpty(dbReader["PatientId"].ToString()))
                        patientDashboard.PatientId = "";
                    else
                        patientDashboard.PatientId = Convert.ToString(dbReader["PatientId"]);
                    if (string.IsNullOrEmpty(dbReader["SpellNumber"].ToString()))
                        patientDashboard.SpellNumber = 0;
                    else
                        patientDashboard.SpellNumber = Convert.ToInt32(dbReader["SpellNumber"]);
                    if (string.IsNullOrEmpty(dbReader["NHSNumber"].ToString()))
                        patientDashboard.NHSNumber = "";
                    else
                        patientDashboard.NHSNumber = Convert.ToString(dbReader["NHSNumber"]);
                    if (string.IsNullOrEmpty(dbReader["PatientName"].ToString()))
                        patientDashboard.PatientName = "";
                    else
                        patientDashboard.PatientName = Convert.ToString(dbReader["PatientName"]);
                    if (string.IsNullOrEmpty(dbReader["DOB"].ToString()))
                        patientDashboard.DOB = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DOB = Convert.ToDateTime(dbReader["DOB"]);
                    if (string.IsNullOrEmpty(dbReader["DateOfAdmission"].ToString()))
                        patientDashboard.DateofAdmission = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofAdmission = Convert.ToDateTime(dbReader["DateOfAdmission"]);
                    if (string.IsNullOrEmpty(dbReader["DateOfDeath"].ToString()))
                        patientDashboard.DateofDeath = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofDeath = Convert.ToDateTime(dbReader["DateOfDeath"]);
                    if (string.IsNullOrEmpty(dbReader["WardOfDeath"].ToString()))
                        patientDashboard.WardofDeath = "";
                    else
                        patientDashboard.WardofDeath = Convert.ToString(dbReader["WardOfDeath"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeConsultantName"].ToString()))
                        patientDashboard.DischargeConsutantName = "";
                    else
                        patientDashboard.DischargeConsutantName = Convert.ToString(dbReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dbReader["AdmissionType"].ToString()))
                        patientDashboard.AdmissionType = "";
                    else
                        patientDashboard.AdmissionType = Convert.ToString(dbReader["AdmissionType"]);
                    if (string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        patientDashboard.MedTriage = 2;
                    else
                        patientDashboard.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    if (string.IsNullOrEmpty(dbReader["QAPReview"].ToString()))
                        patientDashboard.QAPReview = 2;
                    else
                        patientDashboard.QAPReview = Convert.ToInt32(dbReader["QAPReview"]);
                    if (string.IsNullOrEmpty(dbReader["CodingReview"].ToString()))
                        patientDashboard.CodingReview = 2;
                    else
                        patientDashboard.CodingReview = Convert.ToInt32(dbReader["CodingReview"]);
                    if (string.IsNullOrEmpty(dbReader["SJR1"].ToString()))
                        patientDashboard.SJR1 = 0;
                    else
                        patientDashboard.SJR1 = Convert.ToInt32(dbReader["SJR1"]);
                    if (string.IsNullOrEmpty(dbReader["SJR2"].ToString()))
                        patientDashboard.SJR2 = 0;
                    else
                        patientDashboard.SJR2 = Convert.ToInt32(dbReader["SJR2"]);
                    if (string.IsNullOrEmpty(dbReader["SJROutcome"].ToString()))
                        patientDashboard.SJROutcome = 0;
                    else
                        patientDashboard.SJROutcome = Convert.ToInt32(dbReader["SJROutcome"]);
                    if (string.IsNullOrEmpty(dbReader["Age"].ToString()))
                        patientDashboard.Age = 0;
                    else
                        patientDashboard.Age = Convert.ToInt32(dbReader["Age"]);
                    if (string.IsNullOrEmpty(dbReader["Gender"].ToString()))
                        patientDashboard.Gender = "";
                    else
                        patientDashboard.Gender = Convert.ToString(dbReader["Gender"]);
                    if (string.IsNullOrEmpty(dbReader["TimeofAdmission"].ToString()))
                        patientDashboard.TimeofAdmission = "";
                    else
                        patientDashboard.TimeofAdmission = Convert.ToDateTime(dbReader["TimeofAdmission"].ToString()).ToString("HH:mm");
                    if (!string.IsNullOrEmpty(dbReader["TimeOfDeath"].ToString()))
                        patientDashboard.TimeofDeath = Convert.ToDateTime(dbReader["TimeOfDeath"].ToString()).ToString("HH:mm");
                    else
                        patientDashboard.TimeofDeath = "";
                    if (string.IsNullOrEmpty(dbReader["DischargeWard"].ToString()))
                        patientDashboard.DischargeWard = "";
                    else
                        patientDashboard.DischargeWard = Convert.ToString(dbReader["DischargeWard"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeConsultantCode"].ToString()))
                        patientDashboard.DischargeConsultantCode = "";
                    else
                        patientDashboard.DischargeConsultantCode = Convert.ToString(dbReader["DischargeConsultantCode"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeSpecialityCode"].ToString()))
                        patientDashboard.DischargeSpecialtyCode = "";
                    else
                        patientDashboard.DischargeSpecialtyCode = Convert.ToString(dbReader["DischargeSpecialityCode"]);
                    if (string.IsNullOrEmpty(dbReader["DischargeSpeciality"].ToString()))
                        patientDashboard.DischargeSpeciality = "";
                    else
                        patientDashboard.DischargeSpeciality = Convert.ToString(dbReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dbReader["Caregroup"].ToString()))
                        patientDashboard.Caregroup = "";
                    else
                        patientDashboard.Caregroup = Convert.ToString(dbReader["Caregroup"]);
                    if (string.IsNullOrEmpty(dbReader["Comments"].ToString()))
                        patientDashboard.Comments = "";
                    else
                        patientDashboard.Comments = Convert.ToString(dbReader["Comments"]);
                    if (string.IsNullOrEmpty(dbReader["ComorbiditiesCount"].ToString()))
                        patientDashboard.ComorbiditiesCount = 0;
                    else
                        patientDashboard.ComorbiditiesCount = Convert.ToInt32(dbReader["ComorbiditiesCount"]);
                    //if (!string.IsNullOrEmpty(dbReader["DiagnosisCount"].ToString()))
                    //    patientDashboard.DiagnosisCount = 0;
                    //else
                        patientDashboard.DiagnosisCount = Convert.ToInt32(dbReader["DiagnosisCount"]);
                    //if (!string.IsNullOrEmpty(dbReader["ProcedureCount"].ToString()))
                    //    patientDashboard.ProcedureCount = 0;
                    //else
                        patientDashboard.ProcedureCount = Convert.ToInt32(dbReader["ProcedureCount"]);
                    if (string.IsNullOrEmpty(dbReader["IsFullSJRRequired"].ToString()))
                        patientDashboard.IsFullSJRRequired = false;
                    else
                        patientDashboard.IsFullSJRRequired = Convert.ToBoolean(dbReader["IsFullSJRRequired"]);
                    if (string.IsNullOrEmpty(dbReader["CodingIssueIdentified"].ToString()))
                        patientDashboard.CodingIssueIdentified = false;
                    else
                        patientDashboard.CodingIssueIdentified = Convert.ToBoolean(dbReader["CodingIssueIdentified"]);
                    if (string.IsNullOrEmpty(dbReader["Stage2SJRRequired"].ToString()))
                        patientDashboard.Stage2SJRRequired = false;
                    else
                        patientDashboard.Stage2SJRRequired = Convert.ToBoolean(dbReader["Stage2SJRRequired"]);
                    if (string.IsNullOrEmpty(dbReader["Occupation"].ToString()))
                        patientDashboard.Occupation = "";
                    else
                        patientDashboard.Occupation = Convert.ToString(dbReader["Occupation"]);
                    if (string.IsNullOrEmpty(dbReader["UserRole"].ToString()))
                        patientDashboard.UserRole = "";
                    else
                        patientDashboard.UserRole = Convert.ToString(dbReader["UserRole"]);
                    if (string.IsNullOrEmpty(dbReader["PatientType"].ToString()))
                        patientDashboard.PatientType = "AAPC";
                    else
                        patientDashboard.PatientType = Convert.ToString(dbReader["PatientType"]);
                    if (string.IsNullOrEmpty(dbReader["DataQualityComments"].ToString()))
                        patientDashboard.PatientType = "";
                    else
                        patientDashboard.DataQualityIssueComments = Convert.ToString(dbReader["DataQualityComments"]);
                    if (string.IsNullOrEmpty(dbReader["DataQualityIssuesIdentified"].ToString()))
                        patientDashboard.DataQualityIssuesIdentified = false;
                    else
                        patientDashboard.DataQualityIssuesIdentified = Convert.ToBoolean(dbReader["DataQualityIssuesIdentified"]);
                    if (string.IsNullOrEmpty(dbReader["UrgentMEReview"].ToString()))
                        patientDashboard.UrgentMEReview = false;
                    else
                        patientDashboard.UrgentMEReview = Convert.ToBoolean(dbReader["UrgentMEReview"]);
                    if (string.IsNullOrEmpty(dbReader["UrgentMEReviewComment"].ToString()))
                        patientDashboard.UrgentMEReviewComment = "";
                    else
                        patientDashboard.UrgentMEReviewComment = Convert.ToString(dbReader["UrgentMEReviewComment"]);
                    if (string.IsNullOrEmpty(dbReader["RelativeName"].ToString()))
                        patientDashboard.RelativeName = "";
                    else
                        patientDashboard.RelativeName = Convert.ToString(dbReader["RelativeName"]);
                    if (string.IsNullOrEmpty(dbReader["RelativeTelNo"].ToString()))
                        patientDashboard.RelativeTelNo = "";
                    else
                        patientDashboard.RelativeTelNo = Convert.ToString(dbReader["RelativeTelNo"]);
                    if (string.IsNullOrEmpty(dbReader["Relationship"].ToString()))
                        patientDashboard.Relationship = "";
                    else
                        patientDashboard.Relationship = Convert.ToString(dbReader["Relationship"]);
                    if (string.IsNullOrEmpty(dbReader["GPSurgery"].ToString()))
                        patientDashboard.GPSurgery = "";
                    else
                        patientDashboard.GPSurgery = Convert.ToString(dbReader["GPSurgery"]);
                    lstPatientDetails.Add(patientDashboard);
                }
                
                if (dbReader.NextResult())
                {
                    while (dbReader.Read())
                    {
                        nextOfkin = new NextOfKin();
                        if (string.IsNullOrEmpty(dbReader["PatientID"].ToString()))
                            nextOfkin.PatientID = "";
                        else
                            nextOfkin.PatientID = Convert.ToString(dbReader["PatientID"]);
                        if (string.IsNullOrEmpty(dbReader["RelativeName"].ToString()))
                            nextOfkin.RelativeName = "";
                        else
                            nextOfkin.RelativeName = Convert.ToString(dbReader["RelativeName"]);
                        if (string.IsNullOrEmpty(dbReader["RelativeTelNo"].ToString()))
                            nextOfkin.RelativeTelNo = "";
                        else
                            nextOfkin.RelativeTelNo = Convert.ToString(dbReader["RelativeTelNo"]);

                        if (string.IsNullOrEmpty(dbReader["Relationship"].ToString()))
                            nextOfkin.Relationship = "";
                        else
                            nextOfkin.Relationship = Convert.ToString(dbReader["Relationship"]);

                        if (string.IsNullOrEmpty(dbReader["PresentAtDeath"].ToString()))
                            nextOfkin.PresentAtDeath = false;
                        else
                            nextOfkin.PresentAtDeath = Convert.ToBoolean(dbReader["PresentAtDeath"]);

                        if (string.IsNullOrEmpty(dbReader["IsInformed"].ToString()))
                            nextOfkin.IsInformed = false;
                        else
                            nextOfkin.IsInformed = Convert.ToBoolean(dbReader["IsInformed"]);

                        if (string.IsNullOrEmpty(dbReader["NextOfKinID"].ToString()))
                            nextOfkin.NextOfKinID = 0;
                        else
                            nextOfkin.NextOfKinID = Convert.ToInt32(dbReader["NextOfKinID"]);
                        lstNextOfKin.Add(nextOfkin);
                    }
                }
                patientDashboard.lstNEXTKin = lstNextOfKin;
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (patientDashboard.ID == 0 || patientDashboard.ID == null) patientDashboard.ID = Convert.ToInt32(id);
            return lstPatientDetails;
        }

        public int InsertKin(NextOfKin nextofkin)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_InsertNextOfKinDetails", connection);
            SqlDataReader dataReader = null;

            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", nextofkin.PatientID);
                dbCommand.Parameters.AddWithValue("@RelativeName", nextofkin.RelativeName);
                dbCommand.Parameters.AddWithValue("@RelativeTelNo", nextofkin.RelativeTelNo);
                dbCommand.Parameters.AddWithValue("@Relationship", nextofkin.Relationship);
                dbCommand.Parameters.AddWithValue("@PresentAtDeath", nextofkin.PresentAtDeath);
                dbCommand.Parameters.AddWithValue("@IsInformed", nextofkin.IsInformed);
                dbCommand.Parameters.AddWithValue("@KinID", nextofkin.NextOfKinID);
                dataReader = dbCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    retVal = Convert.ToInt32(dataReader["ID"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            if (!dataReader.IsClosed)
                dataReader.Close();
            return retVal;

        }

        /// <summary>
        /// Update details of medical examiner decision tab into the database for a particular patient ID
        /// </summary>
        /// <param name="isMCCDissue">bool</param>
        /// <param name="isCoronerReferral">bool</param>
        /// <param name="isHospitalPostMortem">bool</param>
        /// <param name="isDeathCertificate">bool</param>
        /// <param name="isCornerReferralComplete">bool</param>
        /// <param name="isCoronerDecisionInquest">bool</param>
        /// <param name="isCoronerDecisionPostMortem">bool</param>
        /// <param name="isCoronerDecision100A">bool</param>
        /// <param name="isCoronerDecisionGPissue">bool</param>
        /// <param name="ReasonID">int</param>
        /// <param name="CauseOfDeath1">string</param>
        /// <param name="CauseOfDeath2">string</param>
        /// <param name="CauseOfDeath3">string</param>
        /// <param name="CauseOfDeath4">string</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateMedicalExaminerDecision(bool isMCCDissue, bool isCoronerReferral, bool isHospitalPostMortem, bool isDeathCertificate, bool isCornerReferralComplete, bool isCoronerDecisionInquest, bool isCoronerDecisionPostMortem,
            bool isCoronerDecision100A, bool isCoronerDecisionGPissue, string Reason, string CauseOfDeath1, string CauseOfDeath2, string CauseOfDeath3, 
            string CauseOfDeath4, DateTime? DeathCertificateDate, string DeathCertificateTime, string TimeType,string CauseID, int id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpsertMedExaminerDecision", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@isMCCDissue", isMCCDissue);
                dbCommand.Parameters.AddWithValue("@isCoronerReferral", isCoronerReferral);
                dbCommand.Parameters.AddWithValue("@isHospitalPostMortem", isHospitalPostMortem);
                dbCommand.Parameters.AddWithValue("@isDeathCertificate", isDeathCertificate);
                dbCommand.Parameters.AddWithValue("@isCornerReferralComplete", isCornerReferralComplete);
                dbCommand.Parameters.AddWithValue("@isCoronerDecisionInquest", isCoronerDecisionInquest);
                dbCommand.Parameters.AddWithValue("@isCoronerDecisionPostMortem", isCoronerDecisionPostMortem);
                dbCommand.Parameters.AddWithValue("@isCoronerDecision100A", isCoronerDecision100A);
                dbCommand.Parameters.AddWithValue("@isCoronerDecisionGPissue", isCoronerDecisionGPissue);
                dbCommand.Parameters.AddWithValue("@Reason", Reason);
                dbCommand.Parameters.AddWithValue("@CauseOfDeath1", CauseOfDeath1);
                dbCommand.Parameters.AddWithValue("@CauseOfDeath2", CauseOfDeath2);
                dbCommand.Parameters.AddWithValue("@CauseOfDeath3", CauseOfDeath3);
                dbCommand.Parameters.AddWithValue("@CauseOfDeath4", CauseOfDeath4);
                dbCommand.Parameters.AddWithValue("@DeathCertificateDate", DeathCertificateDate ?? (object)DBNull.Value);
                dbCommand.Parameters.AddWithValue("@DeathCertificateTime", DeathCertificateTime);
                dbCommand.Parameters.AddWithValue("@TimeType", TimeType);
                dbCommand.Parameters.AddWithValue("@CauseID", Convert.ToInt32(CauseID));
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Get distinct discharge speciality names for the filter drop down.
        /// </summary>
        /// <returns>List<DischargeSpecialityNames></returns>
        public List<DischargeSpecialityNames> GetSpecialities()
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<DischargeSpecialityNames> dischargeSpecialityNames = new List<DischargeSpecialityNames>();

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSpecialityNames", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    DischargeSpecialityNames dischargeSpeciality = new DischargeSpecialityNames();
                    dischargeSpeciality.DischargeSpecialityCode = Convert.ToString(dataReader["DischargeSpecialityCode"]);
                    dischargeSpeciality.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    dischargeSpecialityNames.Add(dischargeSpeciality);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return dischargeSpecialityNames;
        }

        public List<clsDataManagement> GetDataSets()
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<clsDataManagement> datasets = new List<clsDataManagement>();

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_DataManagementDetails", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    clsDataManagement dataset = new clsDataManagement();
                    dataset.SourceSystem = Convert.ToString(dataReader["SourceSystem"]);
                    dataset.DataSet = Convert.ToString(dataReader["DataSet"]);
                    dataset.DQRag = Convert.ToInt32(dataReader["DQRag"]);
                    dataset.UpdateDate = Convert.ToDateTime(dataReader["UpdateDate"]).ToString("dd-MMM-yyyy");
                    dataset.UpdateTime = Convert.ToDateTime(dataReader["UpdateTime"].ToString()).ToString("HH:mm");
                    datasets.Add(dataset);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return datasets;
        }

        /// <summary>
        /// Get positive feedback form details for particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsFeedBackModel</returns>
        public clsFeedBackModel GetFeedback(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<clsFeedBackModel> lstFBM = new List<clsFeedBackModel>();
            clsFeedBackModel feedback = new clsFeedBackModel();
            FeedBackComments fbcomments = new FeedBackComments();

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetFeedbackData", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    
                    feedback.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    feedback.FormCompleted = Convert.ToBoolean(dataReader["FormCompleted"]);
                    feedback.ComplementsFedBack = Convert.ToBoolean(dataReader["ComplementsFedBack"]);
                    //feedback.Comments = Convert.ToString(dataReader["Comments"]);
                    //feedback.FBTypeID = Convert.ToInt32(dataReader["FBTypeID"]);
                    if (!string.IsNullOrEmpty(dataReader["MedTriage"].ToString()))
                        feedback.MedTriage = Convert.ToInt32(dataReader["MedTriage"]);
                    else
                        feedback.MedTriage = 2;
                     
                }
                if (dataReader.NextResult())
                {
                    while (dataReader.Read())
                    {
                        
                        if (string.IsNullOrEmpty(dataReader["FeedBackCommentID"].ToString()))
                            fbcomments.FeedBackCommentID = 0;
                        else
                            fbcomments.FeedBackCommentID = Convert.ToInt32(dataReader["FeedBackCommentID"]);

                        if (string.IsNullOrEmpty(dataReader["Patient_ID"].ToString()))
                            fbcomments.Patient_ID = 0;
                        else
                            fbcomments.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);

                        if (string.IsNullOrEmpty(dataReader["Comments"].ToString()))
                            fbcomments.Comments = "";
                        else
                            fbcomments.Comments = Convert.ToString(dataReader["Comments"]);

                         
                            fbcomments.CreatedDate = Convert.ToDateTime(dataReader["CreatedDate"]);

                        if (string.IsNullOrEmpty(dataReader["FBTypeID"].ToString()))
                            fbcomments.FBTypeID = 0;
                        else
                            fbcomments.FBTypeID = Convert.ToInt32(dataReader["FBTypeID"]);

                        if (string.IsNullOrEmpty(dataReader["name"].ToString()))
                            fbcomments.Name = "";
                        else
                            fbcomments.Name = Convert.ToString(dataReader["name"]);

                        if (string.IsNullOrEmpty(dataReader["role"].ToString()))
                            fbcomments.Role = "";
                        else
                            fbcomments.Role = Convert.ToString(dataReader["role"]);

                        feedback.lstFBComments.Add(fbcomments);
                    }
                }
                //if (dataReader.NextResult())
                //{
                //    while (dataReader.Read())
                //    {
                //        fbcomments = new FeedBackComments();
                //        if (string.IsNullOrEmpty(dataReader["FeedBackCommentID"].ToString()))
                //            fbcomments.FeedBackCommentID = 0;
                //        else
                //            fbcomments.FeedBackCommentID = Convert.ToInt32(dataReader["FeedBackCommentID"]);

                //        if (string.IsNullOrEmpty(dataReader["Patient_ID"].ToString()))
                //            fbcomments.Patient_ID = 0;
                //        else
                //            fbcomments.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);

                       

                //        feedback.lstFBComments.Add(fbcomments);
                //    }
                //}
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            DateTime dt = System.DateTime.Now.Date;
            //if (feedback.Patient_ID == 0) feedback.Patient_ID = Convert.ToInt32(id);
           return feedback;
        }
       

        public int GetRatingIDByName(string name)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            int ratingID = 0;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetRatingIDByName", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@Name", name);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    ratingID = Convert.ToInt32(dataReader["CareRatingID"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return ratingID;
        }

        /// <summary>
        /// Get SJR1 Form step 1 details based on patientID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsSJRFormInitial</returns>
        public clsSJRFormInitial GetSJRFormInitial(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsSJRFormInitial sjrFormInitial = new clsSJRFormInitial();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSJRFormInitial", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    sjrFormInitial.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    sjrFormInitial.PatientID = Convert.ToString(dataReader["PatientID"]);
                    string InitialManagement = "";
                    if (dataReader["InitialManagement"] != null) InitialManagement = Convert.ToString(dataReader["InitialManagement"]);
                    sjrFormInitial.InitialManagement = InitialManagement;
                    int InitialManagementCareRatingID = 0;
                    if(dataReader["InitialManagementCareRatingID"] != null) InitialManagementCareRatingID = Convert.ToInt32(dataReader["InitialManagementCareRatingID"]);
                    sjrFormInitial.InitialManagementCareRatingID = InitialManagementCareRatingID;
                    string OngoingCare = "";
                    if (dataReader["OngoingCare"] != null) OngoingCare = Convert.ToString(dataReader["OngoingCare"]);
                    sjrFormInitial.OngoingCare = OngoingCare;
                    int OngoingCareRatingID = 0;
                    if (dataReader["OngoingCareRatingID"] != null) OngoingCareRatingID = Convert.ToInt32(dataReader["OngoingCareRatingID"]);
                    sjrFormInitial.OngoingCareRatingID = OngoingCareRatingID;
                    string CareDuringProcedure = "";
                    if (dataReader["CareDuringProcedure"] != null) CareDuringProcedure = Convert.ToString(dataReader["CareDuringProcedure"]);
                    sjrFormInitial.CareDuringProcedure = CareDuringProcedure;
                    int CareDuringProcedureCareRatingID = 0;
                    if (dataReader["CareDuringProcedureCareRatingID"] != null) CareDuringProcedureCareRatingID = Convert.ToInt32(dataReader["CareDuringProcedureCareRatingID"]);
                    sjrFormInitial.CareDuringProcedureCareRatingID = CareDuringProcedureCareRatingID;
                    string EndLifeCare = "";
                    if (dataReader["EndLifeCare"] != null) EndLifeCare = Convert.ToString(dataReader["EndLifeCare"]);
                    sjrFormInitial.EndLifeCare = EndLifeCare;
                    int EndLifeCareRatingID = 0;
                    if (dataReader["EndLifeCareRatingID"] != null) EndLifeCareRatingID = Convert.ToInt32(dataReader["EndLifeCareRatingID"]);
                    sjrFormInitial.EndLifeCareRatingID = EndLifeCareRatingID;
                    string OverAllAssessment = "";
                    if (dataReader["OverAllAssessment"] != null) OverAllAssessment = Convert.ToString(dataReader["OverAllAssessment"]);
                    sjrFormInitial.OverAllAssessment = OverAllAssessment;
                    int OverAllAssessmentCareRatingID = 0;
                    if (dataReader["OverAllAssessmentCareRatingID"] != null) OverAllAssessmentCareRatingID = Convert.ToInt32(dataReader["OverAllAssessmentCareRatingID"]);
                    sjrFormInitial.OverAllAssessmentCareRatingID = OverAllAssessmentCareRatingID;
                    int QualityDocumentation = 0;
                    if (dataReader["QualityDocumentation"] != null) QualityDocumentation = Convert.ToInt32(dataReader["QualityDocumentation"]);
                    sjrFormInitial.QualityDocumentation = Convert.ToInt32(dataReader["QualityDocumentation"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return sjrFormInitial;
        }

        public clsSJRFormInitial GetSJR2FormInitial(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsSJRFormInitial sjrFormInitial = new clsSJRFormInitial();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSJR2FormInitial", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    sjrFormInitial.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    sjrFormInitial.PatientID = Convert.ToString(dataReader["PatientID"]);
                    string InitialManagement = "";
                    if (dataReader["InitialManagement"] != null) InitialManagement = Convert.ToString(dataReader["InitialManagement"]);
                    sjrFormInitial.InitialManagement = InitialManagement;
                    int InitialManagementCareRatingID = 0;
                    if (dataReader["InitialManagementCareRatingID"] != null) InitialManagementCareRatingID = Convert.ToInt32(dataReader["InitialManagementCareRatingID"]);
                    sjrFormInitial.InitialManagementCareRatingID = InitialManagementCareRatingID;
                    string OngoingCare = "";
                    if (dataReader["OngoingCare"] != null) OngoingCare = Convert.ToString(dataReader["OngoingCare"]);
                    sjrFormInitial.OngoingCare = OngoingCare;
                    int OngoingCareRatingID = 0;
                    if (dataReader["OngoingCareRatingID"] != null) OngoingCareRatingID = Convert.ToInt32(dataReader["OngoingCareRatingID"]);
                    sjrFormInitial.OngoingCareRatingID = OngoingCareRatingID;
                    string CareDuringProcedure = "";
                    if (dataReader["CareDuringProcedure"] != null) CareDuringProcedure = Convert.ToString(dataReader["CareDuringProcedure"]);
                    sjrFormInitial.CareDuringProcedure = CareDuringProcedure;
                    int CareDuringProcedureCareRatingID = 0;
                    if (dataReader["CareDuringProcedureCareRatingID"] != null) CareDuringProcedureCareRatingID = Convert.ToInt32(dataReader["CareDuringProcedureCareRatingID"]);
                    sjrFormInitial.CareDuringProcedureCareRatingID = CareDuringProcedureCareRatingID;
                    string EndLifeCare = "";
                    if (dataReader["EndLifeCare"] != null) EndLifeCare = Convert.ToString(dataReader["EndLifeCare"]);
                    sjrFormInitial.EndLifeCare = EndLifeCare;
                    int EndLifeCareRatingID = 0;
                    if (dataReader["EndLifeCareRatingID"] != null) EndLifeCareRatingID = Convert.ToInt32(dataReader["EndLifeCareRatingID"]);
                    sjrFormInitial.EndLifeCareRatingID = EndLifeCareRatingID;
                    string OverAllAssessment = "";
                    if (dataReader["OverAllAssessment"] != null) OverAllAssessment = Convert.ToString(dataReader["OverAllAssessment"]);
                    sjrFormInitial.OverAllAssessment = OverAllAssessment;
                    int OverAllAssessmentCareRatingID = 0;
                    if (dataReader["OverAllAssessmentCareRatingID"] != null) OverAllAssessmentCareRatingID = Convert.ToInt32(dataReader["OverAllAssessmentCareRatingID"]);
                    sjrFormInitial.OverAllAssessmentCareRatingID = OverAllAssessmentCareRatingID;
                    int QualityDocumentation = 0;
                    if (dataReader["QualityDocumentation"] != null) QualityDocumentation = Convert.ToInt32(dataReader["QualityDocumentation"]);
                    sjrFormInitial.QualityDocumentation = Convert.ToInt32(dataReader["QualityDocumentation"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return sjrFormInitial;
        }

        /// <summary>
        /// Get all sjr outcome form details for particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsSJROutcome</returns>
        public clsSJROutcome GetSJROutcome(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsSJROutcome sjrOutcome = new clsSJROutcome();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSJROutcome", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    sjrOutcome.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    sjrOutcome.PatientID = Convert.ToString(dataReader["PatientID"]);
                    sjrOutcome.Stage2SJRRequired = Convert.ToBoolean(dataReader["Stage2SJRRequired"]);
                    sjrOutcome.Stage2SJRDateSent = Convert.ToString(dataReader["Stage2SJRDateSent"]);
                    sjrOutcome.Stage2SJRSentTo = Convert.ToString(dataReader["Stage2SJRSentTo"]);
                    sjrOutcome.ReferenceNumber = Convert.ToString(dataReader["ReferenceNumber"]);
                    sjrOutcome.DateReceived = Convert.ToString(dataReader["DateReceived"]);
                    sjrOutcome.AvoidabilityScoreID = Convert.ToInt32(dataReader["AvoidabilityScoreID"]);
                    sjrOutcome.MSGRequired = Convert.ToBoolean(dataReader["MSGRequired"]);
                    sjrOutcome.MSGDiscussionDate = Convert.ToString(dataReader["MSGDiscussionDate"]);
                    sjrOutcome.Comments = Convert.ToString(dataReader["Comments"]);
                    sjrOutcome.SIRIComments = Convert.ToString(dataReader["SIRIComments"]);
                    sjrOutcome.FeedbackToNoK = Convert.ToString(dataReader["FeedbackToNoK"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return sjrOutcome;
        }

        /// <summary>
        /// Get all details for SJR1 step 2 for particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsSJRFormProblemType</returns>
        public clsSJRFormProblemType GetSJRProblemType(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsSJRFormProblemType sjrProblemType = new clsSJRFormProblemType();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSJRProblemType", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    sjrProblemType.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    sjrProblemType.PatientID = Convert.ToString(dataReader["PatientID"]);
                    sjrProblemType.ProblemOccured = Convert.ToBoolean(dataReader["ProblemOccured"]);
                    sjrProblemType.AssessmentResponseID = Convert.ToInt32(dataReader["AssessmentResponseID"]);
                    sjrProblemType.AssessmentCarePhaseID = Convert.ToInt32(dataReader["AssessmentCarePhaseID"]);
                    sjrProblemType.MedicationResponseID = Convert.ToInt32(dataReader["MedicationResponseID"]);
                    sjrProblemType.MedicationCarePhaseID = Convert.ToInt32(dataReader["MedicationCarePhaseID"]);
                    sjrProblemType.TreatmentResponseID = Convert.ToInt32(dataReader["TreatmentResponseID"]);
                    sjrProblemType.TreatmentCarePhaseID = Convert.ToInt32(dataReader["TreatmentCarePhaseID"]);
                    sjrProblemType.InfectionResponseID = Convert.ToInt32(dataReader["InfectionResponseID"]);
                    sjrProblemType.InfectionCarePhaseID = Convert.ToInt32(dataReader["InfectionCarePhaseID"]);
                    sjrProblemType.ProcedureResponseID = Convert.ToInt32(dataReader["ProcedureResponseID"]);
                    sjrProblemType.ProcedureCarePhaseID = Convert.ToInt32(dataReader["ProcedureCarePhaseID"]);
                    sjrProblemType.MonitoringResponseID = Convert.ToInt32(dataReader["MonitoringResponseID"]);
                    sjrProblemType.ResuscitationResponseID = Convert.ToInt32(dataReader["ResuscitationResponseID"]);
                    sjrProblemType.OthertypeResponseID = Convert.ToInt32(dataReader["OthertypeResponseID"]);
                    sjrProblemType.OthertypeCarePhaseID = Convert.ToInt32(dataReader["OthertypeCarePhaseID"]);
                    sjrProblemType.AvoidabilityScoreID = Convert.ToInt32(dataReader["AvoidabilityScoreID"]);
                    sjrProblemType.Comments = Convert.ToString(dataReader["Comments"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return sjrProblemType;
        }

        public clsSJRFormProblemType GetSJR2ProblemType(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsSJRFormProblemType sjrProblemType = new clsSJRFormProblemType();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSJR2ProblemType", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    sjrProblemType.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    sjrProblemType.PatientID = Convert.ToString(dataReader["PatientID"]);
                    sjrProblemType.ProblemOccured = Convert.ToBoolean(dataReader["ProblemOccured"]);
                    sjrProblemType.AssessmentResponseID = Convert.ToInt32(dataReader["AssessmentResponseID"]);
                    sjrProblemType.AssessmentCarePhaseID = Convert.ToInt32(dataReader["AssessmentCarePhaseID"]);
                    sjrProblemType.MedicationResponseID = Convert.ToInt32(dataReader["MedicationResponseID"]);
                    sjrProblemType.MedicationCarePhaseID = Convert.ToInt32(dataReader["MedicationCarePhaseID"]);
                    sjrProblemType.TreatmentResponseID = Convert.ToInt32(dataReader["TreatmentResponseID"]);
                    sjrProblemType.TreatmentCarePhaseID = Convert.ToInt32(dataReader["TreatmentCarePhaseID"]);
                    sjrProblemType.InfectionResponseID = Convert.ToInt32(dataReader["InfectionResponseID"]);
                    sjrProblemType.InfectionCarePhaseID = Convert.ToInt32(dataReader["InfectionCarePhaseID"]);
                    sjrProblemType.ProcedureResponseID = Convert.ToInt32(dataReader["ProcedureResponseID"]);
                    sjrProblemType.ProcedureCarePhaseID = Convert.ToInt32(dataReader["ProcedureCarePhaseID"]);
                    sjrProblemType.MonitoringResponseID = Convert.ToInt32(dataReader["MonitoringResponseID"]);
                    sjrProblemType.ResuscitationResponseID = Convert.ToInt32(dataReader["ResuscitationResponseID"]);
                    sjrProblemType.OthertypeResponseID = Convert.ToInt32(dataReader["OthertypeResponseID"]);
                    sjrProblemType.OthertypeCarePhaseID = Convert.ToInt32(dataReader["OthertypeCarePhaseID"]);
                    sjrProblemType.AvoidabilityScoreID = Convert.ToInt32(dataReader["AvoidabilityScoreID"]);
                    sjrProblemType.Comments = Convert.ToString(dataReader["Comments"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return sjrProblemType;
        }

        /// <summary>
        /// Get distinct discharge consultant names for the filter drop down.
        /// </summary>
        /// <returns>List<DischargeConsultants></returns>
        public List<DischargeConsultants> GetConsultants()
        {
            var connection = GetConnection();
            List<DischargeConsultants> dischargeConsultants = new List<DischargeConsultants>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetConsultants", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    DischargeConsultants dischargeConsultant = new DischargeConsultants();
                    dischargeConsultant.DischargeConsultantCode = Convert.ToString(dataReader["DischargeConsultantCode"]);
                    dischargeConsultant.DischargeConsultantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    dischargeConsultants.Add(dischargeConsultant);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return dischargeConsultants;
        }

        public List<PatientTypes> GetPatientTypes()
        {
            var connection = GetConnection();
            List<PatientTypes> patienttypes = new List<PatientTypes>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetPatientTypes", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    PatientTypes patienttype = new PatientTypes();
                    patienttype.PatientTypeLongText = Convert.ToString(dataReader["PatientTypeLongText"]);
                    patienttype.PatientType = Convert.ToString(dataReader["PatientType"]);
                    patienttypes.Add(patienttype);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return patienttypes;
        }


        public List<Specialities> GetSpecialitiesForDropDown()
        {
            var connection = GetConnection();
            List<Specialities> specialities = new List<Specialities>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetSpecialities", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Specialities speciality = new Specialities();
                    speciality.SpecialityName = Convert.ToString(dataReader["SpecialityName"]);
                    speciality.SpecialityID = Convert.ToInt32(dataReader["SpecialityID"]);
                    specialities.Add(speciality);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return specialities;
        }

        /// <summary>
        /// Get distinct ward of death names for the filter drop down.
        /// </summary>
        /// <returns>List<WardOfDeaths></returns>
        public List<WardOfDeaths> GetWardOfDeaths()
        {
            var connection = GetConnection();
            List<WardOfDeaths> wardOfDeaths = new List<WardOfDeaths>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetWardOfDeaths", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    WardOfDeaths wardOfDeath = new WardOfDeaths();
                    wardOfDeath.WardOfDeath = Convert.ToString(dataReader["WardOfDeath"]);
                    wardOfDeaths.Add(wardOfDeath);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return wardOfDeaths;
        }

        /// <summary>
        /// This method brings in all patient lists or brings in a specific patient information based on the
        /// nhs number.
        /// </summary>
        /// <param name="nhsNumber">string</param>
        /// <returns>List<clsPatientDetails>Patient Details List</returns>
        public List<clsPatientDetails> GetFilteredPatientDetails(DateTime startDate, DateTime endDate, string dischargeConsultantCode, string wardOfDeath, string dischargeSpecialityCode, string patientType)
        {
            LogException("In db engine method", this.ToString(), "ValidateUser", System.DateTime.Now);
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            List<clsPatientDetails> lstPatientDetails = new List<clsPatientDetails>();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetFilteredPatientDetails", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                if (startDate != null)
                    dbCommand.Parameters.AddWithValue("@StartDate", startDate);
                else
                    dbCommand.Parameters.AddWithValue("@StartDate", "");
                if (endDate != null)
                    dbCommand.Parameters.AddWithValue("@EndDate", endDate);
                else
                    dbCommand.Parameters.AddWithValue("@EndDate", "");
                if (dischargeConsultantCode != null)
                    dbCommand.Parameters.AddWithValue("@DischargeConsultantCode", dischargeConsultantCode);
                else
                    dbCommand.Parameters.AddWithValue("@DischargeConsultantCode", "");
                if (wardOfDeath != null)
                    dbCommand.Parameters.AddWithValue("@WardOfDeath", wardOfDeath);
                else
                    dbCommand.Parameters.AddWithValue("@WardOfDeath", "");
                if (dischargeSpecialityCode != null)
                    dbCommand.Parameters.AddWithValue("@DischargeSpecialityCode", dischargeSpecialityCode);
                else
                    dbCommand.Parameters.AddWithValue("@DischargeSpecialityCode", "");
                if (patientType != null)
                    dbCommand.Parameters.AddWithValue("@PatientType", patientType);
                else
                    dbCommand.Parameters.AddWithValue("@PatientType", "");
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    clsPatientDetails patientDashboard = new clsPatientDetails();
                    if (string.IsNullOrEmpty(dataReader["ID"].ToString()))
                        patientDashboard.ID = 0;
                    else
                        patientDashboard.ID = Convert.ToInt32(dataReader["ID"]);
                    if (string.IsNullOrEmpty(dataReader["PatientId"].ToString()))
                        patientDashboard.PatientId = "";
                    else
                        patientDashboard.PatientId = Convert.ToString(dataReader["PatientId"]);
                    if (string.IsNullOrEmpty(dataReader["SpellNumber"].ToString()))
                        patientDashboard.SpellNumber = 0;
                    else
                        patientDashboard.SpellNumber = Convert.ToInt32(dataReader["SpellNumber"]);
                    if (string.IsNullOrEmpty(dataReader["NHSNumber"].ToString()))
                        patientDashboard.NHSNumber = "";
                    else
                        patientDashboard.NHSNumber = Convert.ToString(dataReader["NHSNumber"]);
                    if (string.IsNullOrEmpty(dataReader["PatientName"].ToString()))
                        patientDashboard.PatientName = "";
                    else
                        patientDashboard.PatientName = Convert.ToString(dataReader["PatientName"]);
                    if (string.IsNullOrEmpty(dataReader["DOB"].ToString()))
                        patientDashboard.DOB = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DOB = Convert.ToDateTime(dataReader["DOB"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfAdmission"].ToString()))
                        patientDashboard.DateofAdmission = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofAdmission = Convert.ToDateTime(dataReader["DateOfAdmission"]);
                    if (string.IsNullOrEmpty(dataReader["DateOfDeath"].ToString()))
                        patientDashboard.DateofDeath = Convert.ToDateTime("01/01/0001");
                    else
                        patientDashboard.DateofDeath = Convert.ToDateTime(dataReader["DateOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["WardOfDeath"].ToString()))
                        patientDashboard.WardofDeath = "0";
                    else
                        patientDashboard.WardofDeath = Convert.ToString(dataReader["WardOfDeath"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantName"].ToString()))
                        patientDashboard.DischargeConsutantName = "";
                    else
                        patientDashboard.DischargeConsutantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dataReader["AdmissionType"].ToString()))
                        patientDashboard.AdmissionType = "";
                    else
                        patientDashboard.AdmissionType = Convert.ToString(dataReader["AdmissionType"]);
                    if (string.IsNullOrEmpty(dataReader["MedTriage"].ToString()))
                        patientDashboard.MedTriage = 2;
                    else
                        patientDashboard.MedTriage = Convert.ToInt32(dataReader["MedTriage"]);
                    if (string.IsNullOrEmpty(dataReader["SJR1"].ToString()))
                        patientDashboard.SJR1 = 0;
                    else
                        patientDashboard.SJR1 = Convert.ToInt32(dataReader["SJR1"]);
                    if (string.IsNullOrEmpty(dataReader["SJR2"].ToString()))
                        patientDashboard.SJR2 = 0;
                    else
                        patientDashboard.SJR2 = Convert.ToInt32(dataReader["SJR2"]);
                    if (string.IsNullOrEmpty(dataReader["SJROutcome"].ToString()))
                        patientDashboard.SJROutcome = 0;
                    else
                        patientDashboard.SJROutcome = Convert.ToInt32(dataReader["SJROutcome"]);
                    if (string.IsNullOrEmpty(dataReader["QAPReview"].ToString()))
                        patientDashboard.QAPReview = 2;
                    else
                        patientDashboard.QAPReview = Convert.ToInt32(dataReader["QAPReview"]);
                    if (string.IsNullOrEmpty(dataReader["CodingReview"].ToString()))
                        patientDashboard.CodingReview = 2;
                    else
                        patientDashboard.CodingReview = Convert.ToInt32(dataReader["CodingReview"]);
                    if (string.IsNullOrEmpty(dataReader["Age"].ToString()))
                        patientDashboard.Age = 0;
                    else
                        patientDashboard.Age = Convert.ToInt32(dataReader["Age"]);
                    if (string.IsNullOrEmpty(dataReader["Gender"].ToString()))
                        patientDashboard.Gender = "";
                    else
                        patientDashboard.Gender = Convert.ToString(dataReader["Gender"]);
                    if (string.IsNullOrEmpty(dataReader["TimeofAdmission"].ToString()))
                        patientDashboard.TimeofAdmission = "";
                    else
                        patientDashboard.TimeofAdmission = Convert.ToDateTime(dataReader["TimeofAdmission"].ToString()).ToString("HH:mm");
                    if (!string.IsNullOrEmpty(dataReader["TimeOfDeath"].ToString()))
                        patientDashboard.TimeofDeath = Convert.ToDateTime(dataReader["TimeOfDeath"].ToString()).ToString("HH:mm");
                    else
                        patientDashboard.TimeofDeath = "";
                    if (string.IsNullOrEmpty(dataReader["DischargeWard"].ToString()))
                        patientDashboard.DischargeWard = "0";
                    else
                        patientDashboard.DischargeWard = Convert.ToString(dataReader["DischargeWard"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantCode"].ToString()))
                        patientDashboard.DischargeConsultantCode = "0";
                    else
                        patientDashboard.DischargeConsultantCode = Convert.ToString(dataReader["DischargeConsultantCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpecialityCode"].ToString()))
                        patientDashboard.DischargeSpecialtyCode = "0";
                    else
                        patientDashboard.DischargeSpecialtyCode = Convert.ToString(dataReader["DischargeSpecialityCode"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpeciality"].ToString()))
                        patientDashboard.DischargeSpeciality = "";
                    else
                        patientDashboard.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dataReader["Caregroup"].ToString()))
                        patientDashboard.Caregroup = "";
                    else
                        patientDashboard.Caregroup = Convert.ToString(dataReader["Caregroup"]);
                    if (string.IsNullOrEmpty(dataReader["ComorbiditiesCount"].ToString()))
                        patientDashboard.ComorbiditiesCount = 0;
                    else
                        patientDashboard.ComorbiditiesCount = Convert.ToInt32(dataReader["ComorbiditiesCount"]);
                    if (string.IsNullOrEmpty(dataReader["IsFullSJRRequired"].ToString()))
                        patientDashboard.IsFullSJRRequired = false;
                    else
                        patientDashboard.IsFullSJRRequired = Convert.ToBoolean(dataReader["IsFullSJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["Stage2SJRRequired"].ToString()))
                        patientDashboard.Stage2SJRRequired = false;
                    else
                        patientDashboard.Stage2SJRRequired = Convert.ToBoolean(dataReader["Stage2SJRRequired"]);
                    if (string.IsNullOrEmpty(dataReader["PatientType"].ToString()))
                        patientDashboard.PatientType = "AAPC";
                    else
                        patientDashboard.PatientType = Convert.ToString(dataReader["PatientType"]);
                    if (string.IsNullOrEmpty(dataReader["PatientTypeLongText"].ToString()))
                        patientDashboard.PatientTypeLongText = "Adult Inpatients";
                    else
                        patientDashboard.PatientTypeLongText = Convert.ToString(dataReader["PatientTypeLongText"]);
                    if (string.IsNullOrEmpty(dataReader["QAPCount"].ToString()))
                        patientDashboard.QAPCount = 0;
                    else
                        patientDashboard.QAPCount = Convert.ToInt32(dataReader["QAPCount"]);
                    if (string.IsNullOrEmpty(dataReader["MedCount"].ToString()))
                        patientDashboard.MedCount = 0;
                    else
                        patientDashboard.MedCount = Convert.ToInt32(dataReader["MedCount"]);
                    lstPatientDetails.Add(patientDashboard);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return lstPatientDetails;
        }

        /// <summary>
        /// Get diagnosis details based on nhs number
        /// </summary>
        /// <returns>List<DischargeConsultants></returns>
        public List<Diagnosis> GetDiagnosisDetails(int? id)
        {
            var connection = GetConnection();
            List<Diagnosis> diagnoses = new List<Diagnosis>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetDiagnosisByPatientID", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Diagnosis diagnosis = new Diagnosis();
                    if (string.IsNullOrEmpty(dataReader["FCENumber"].ToString()))
                        diagnosis.FCENumber = 0;
                    else
                        diagnosis.FCENumber = Convert.ToInt32(dataReader["FCENumber"]);
                   
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantName"].ToString()))
                        diagnosis.DischargeConsultantName = "";
                    else
                        diagnosis.DischargeConsultantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpeciality"].ToString()))
                        diagnosis.DischargeSpeciality = "";
                    else
                        diagnosis.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dataReader["EpisodeStart"].ToString()))
                        diagnosis.EpisodeStart = "";
                    else
                        diagnosis.EpisodeStart = Convert.ToDateTime(dataReader["EpisodeStart"]).ToString("dd/MM/yyyy-hh:mm tt");
                    if (string.IsNullOrEmpty(dataReader["EpisodeEnd"].ToString()))
                        diagnosis.EpisodeEnd = "";
                    else
                        diagnosis.EpisodeEnd = Convert.ToDateTime(dataReader["EpisodeEnd"]).ToString("dd/MM/yyyy-hh:mm tt");
                    if (string.IsNullOrEmpty(dataReader["LOSEpisode"].ToString()))
                        diagnosis.LOSEpisode = "";
                    else
                        diagnosis.LOSEpisode = Convert.ToString(dataReader["LOSEpisode"]) + " days";
                    if (string.IsNullOrEmpty(dataReader["ComorbidityFlag"].ToString()))
                        diagnosis.ComorbidityFlag = 0;
                    else
                        diagnosis.ComorbidityFlag = Convert.ToInt32(dataReader["ComorbidityFlag"]);
                    if (string.IsNullOrEmpty(dataReader["PrimaryInt"].ToString()))
                        diagnosis.PrimaryInt = 0;
                    else
                        diagnosis.PrimaryInt = Convert.ToInt32(dataReader["PrimaryInt"]);
                    if (string.IsNullOrEmpty(dataReader["DiagnosisDescription"].ToString()))
                        diagnosis.DiagnosisDescription = "";
                    else
                        diagnosis.DiagnosisDescription = Convert.ToString(dataReader["DiagnosisDescription"]);                    
                    diagnoses.Add(diagnosis);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return diagnoses;
        }

        /// <summary>
        /// Get procedure details based on nhs number
        /// </summary>
        /// <returns>List<DischargeConsultants></returns>
        public List<Procedures> GetProcedureDetails(int? id)
        {
            var connection = GetConnection();
            List<Procedures> procedures = new List<Procedures>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetProcedureByPatientID", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    Procedures procedure = new Procedures();
                    if (string.IsNullOrEmpty(dataReader["FCENumber"].ToString()))
                        procedure.FCENumber = 0;
                    else
                        procedure.FCENumber = Convert.ToInt32(dataReader["FCENumber"]);
                    if (string.IsNullOrEmpty(dataReader["Position"].ToString()))
                        procedure.Position = "";
                    else
                        procedure.Position = Convert.ToString(dataReader["Position"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeConsultantName"].ToString()))
                        procedure.DischargeConsultantName = "";
                    else
                        procedure.DischargeConsultantName = Convert.ToString(dataReader["DischargeConsultantName"]);
                    if (string.IsNullOrEmpty(dataReader["DischargeSpeciality"].ToString()))
                        procedure.DischargeSpeciality = "";
                    else
                        procedure.DischargeSpeciality = Convert.ToString(dataReader["DischargeSpeciality"]);
                    if (string.IsNullOrEmpty(dataReader["EpisodeStart"].ToString()))
                        procedure.EpisodeStart = "";
                    else
                        procedure.EpisodeStart = Convert.ToDateTime(dataReader["EpisodeStart"]).ToString("dd/MM/yyyy-hh:mm tt");
                    if (string.IsNullOrEmpty(dataReader["EpisodeEnd"].ToString()))
                        procedure.EpisodeEnd = "";
                    else
                        procedure.EpisodeEnd = Convert.ToDateTime(dataReader["EpisodeEnd"]).ToString("dd/MM/yyyy-hh:mm tt");
                    if (string.IsNullOrEmpty(dataReader["LOSEpisode"].ToString()))
                        procedure.LOSEpisode = "";
                    else
                        procedure.LOSEpisode = Convert.ToString(dataReader["LOSEpisode"]) + " days";
                    if (string.IsNullOrEmpty(dataReader["ProcedureDescription"].ToString()))
                        procedure.ProcedureDescription = "";
                    else
                        procedure.ProcedureDescription = Convert.ToString(dataReader["ProcedureDescription"]);
                    procedures.Add(procedure);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return procedures;
        }

        public List<FeedbackType> GetFeedbackType()
        {
            var connection = GetConnection();
            List<FeedbackType> lstFeedbackType = new List<FeedbackType>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetFeedbackType", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    FeedbackType feedbackType = new FeedbackType();
                    feedbackType.FeedbackTypeID = Convert.ToInt32(dataReader["FeedbackTypeID"]);
                    feedbackType.FBType = Convert.ToString(dataReader["FBType"]);

                    lstFeedbackType.Add(feedbackType);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return lstFeedbackType;
        }

        public List<CommentType> GetCommentType()
        {
            var connection = GetConnection();
            List<CommentType> lstCommentType = new List<CommentType>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetCommentType", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    CommentType commentType = new CommentType();
                    commentType.CommonTypeID = Convert.ToInt32(dataReader["CommonTypeID"]);
                    commentType.Type = Convert.ToString(dataReader["Type"]);

                    lstCommentType.Add(commentType);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return lstCommentType;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public List<CommentHistory> GetComments(int? id)
        {
            var connection = GetConnection();
            List<CommentHistory> comments = new List<CommentHistory>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetComments", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    CommentHistory comment = new CommentHistory();
                    if (!string.IsNullOrEmpty(dataReader["UserID"].ToString()))
                        comment.UserID = Convert.ToInt32(dataReader["UserID"]);
                    else
                        comment.UserID = 0;                    
                    if (!string.IsNullOrEmpty(dataReader["Name"].ToString()))
                        comment.Name = Convert.ToString(dataReader["Name"]);
                    else
                        comment.Name = "";
                    if (!string.IsNullOrEmpty(dataReader["Comments"].ToString()))
                        comment.Comments = Convert.ToString(dataReader["Comments"]);
                    else
                        comment.Comments = "";
                    if (!string.IsNullOrEmpty(dataReader["CreatedDate"].ToString()))
                        comment.CreatedDate = Convert.ToDateTime(dataReader["CreatedDate"]).ToString("dd/MM/yyyy");
                    else
                        comment.CreatedDate = "";
                    if (!string.IsNullOrEmpty(dataReader["CreatedDate"].ToString()))
                        comment.CreatedTime = Convert.ToDateTime(dataReader["CreatedDate"]).TimeOfDay.ToString().Substring(0,5);
                    else
                        comment.CreatedTime = "";
                    if (!string.IsNullOrEmpty(dataReader["CommentTypeID"].ToString()))
                        comment.CommentTypeID = Convert.ToInt32(dataReader["CommentTypeID"]);
                    else
                        comment.CommentTypeID = 0;
                    if (!string.IsNullOrEmpty(dataReader["Role"].ToString()))
                        comment.Role = Convert.ToString(dataReader["Role"]);
                    else
                        comment.Role = "";
                    comments.Add(comment); 
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "GetComments", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return comments;
        }

        public clsQAPReview GetQAPReview(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dataReader = null;
            clsQAPReview qapreview = new clsQAPReview();
            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetQAPReview", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientID", id);

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    if (!string.IsNullOrEmpty(dataReader["Patient_ID"].ToString()))
                        qapreview.Patient_ID = Convert.ToInt32(dataReader["Patient_ID"]);
                    else
                        qapreview.Patient_ID = 0;
                    if (!string.IsNullOrEmpty(dataReader["Synopsis"].ToString()))
                        qapreview.Synopsis = Convert.ToString(dataReader["Synopsis"]);
                    else
                        qapreview.Synopsis = "";
                    if (!string.IsNullOrEmpty(dataReader["MCCD"].ToString()))
                        qapreview.MCCD = Convert.ToBoolean(dataReader["MCCD"]);
                    else
                        qapreview.MCCD = false;
                    if (!string.IsNullOrEmpty(dataReader["Referral"].ToString()))
                        qapreview.Referral = Convert.ToBoolean(dataReader["Referral"]);
                    else
                        qapreview.Referral = false;
                    if (!string.IsNullOrEmpty(dataReader["CreatedDate"].ToString()))
                        qapreview.CreatedDate = Convert.ToDateTime(dataReader["CreatedDate"]).ToString("dd/MM/yyyy");
                    else
                        qapreview.CreatedDate = "";
                    if (!string.IsNullOrEmpty(dataReader["FullName"].ToString()))
                        qapreview.FullName = Convert.ToString(dataReader["FullName"]);
                    else
                        qapreview.FullName = "";
                    if (!string.IsNullOrEmpty(dataReader["GMCNo"].ToString()))
                        qapreview.GMCNo = Convert.ToString(dataReader["GMCNo"]);
                    else
                        qapreview.GMCNo = "";
                    if (!string.IsNullOrEmpty(dataReader["Location"].ToString()))
                        qapreview.Location = Convert.ToString(dataReader["Location"]);
                    else
                        qapreview.Location = "";
                    if (!string.IsNullOrEmpty(dataReader["Phone"].ToString()))
                        qapreview.Phone = Convert.ToString(dataReader["Phone"]);
                    else
                        qapreview.Phone = "";
                    if (!string.IsNullOrEmpty(dataReader["AlternatePhone"].ToString()))
                        qapreview.AlternatePhone = Convert.ToString(dataReader["AlternatePhone"]);
                    else
                        qapreview.AlternatePhone = "";
                    if (!string.IsNullOrEmpty(dataReader["CreatedBy"].ToString()))
                        qapreview.CreatedBy = Convert.ToString(dataReader["CreatedBy"]);
                    else
                        qapreview.CreatedBy = "";
                    if (!string.IsNullOrEmpty(dataReader["CreatedDate"].ToString()))
                        qapreview.CreatedDate = Convert.ToString(dataReader["CreatedDate"]);
                    else
                        qapreview.CreatedDate = "";
                    if (!string.IsNullOrEmpty(dataReader["Concern"].ToString()))
                        qapreview.Concern = Convert.ToBoolean(dataReader["Concern"]);
                    else
                        qapreview.Concern = false;
                    if (!string.IsNullOrEmpty(dataReader["Reason1a"].ToString()))
                        qapreview.Reason1a = Convert.ToString(dataReader["Reason1a"]);
                    else
                        qapreview.Reason1a = "";
                    if (!string.IsNullOrEmpty(dataReader["Reason1b"].ToString()))
                        qapreview.Reason1b = Convert.ToString(dataReader["Reason1b"]);
                    else
                        qapreview.Reason1b = "";
                    if (!string.IsNullOrEmpty(dataReader["Reason1c"].ToString()))
                        qapreview.Reason1c = Convert.ToString(dataReader["Reason1c"]);
                    else
                        qapreview.Reason1c = "";
                    if (!string.IsNullOrEmpty(dataReader["Reason2"].ToString()))
                        qapreview.Reason2 = Convert.ToString(dataReader["Reason2"]);
                    else
                        qapreview.Reason2 = "";
                    if (!string.IsNullOrEmpty(dataReader["Interval1"].ToString()))
                        qapreview.Interval1 = Convert.ToString(dataReader["Interval1"]);
                    else
                        qapreview.Interval1 = "";
                    if (!string.IsNullOrEmpty(dataReader["Interval2"].ToString()))
                        qapreview.Interval2 = Convert.ToString(dataReader["Interval2"]);
                    else
                        qapreview.Interval2 = "";
                    if (!string.IsNullOrEmpty(dataReader["Interval3"].ToString()))
                        qapreview.Interval3 = Convert.ToString(dataReader["Interval3"]);
                    else
                        qapreview.Interval3 = "";
                    if (!string.IsNullOrEmpty(dataReader["Interval4"].ToString()))
                        qapreview.Interval4 = Convert.ToString(dataReader["Interval4"]);
                    else
                        qapreview.Interval4 = "";
                    if (!string.IsNullOrEmpty(dataReader["Reason"].ToString()))
                        qapreview.Reason = Convert.ToString(dataReader["Reason"]);
                    else
                        qapreview.Reason = "";
                    if (!string.IsNullOrEmpty(dataReader["QAPReview"].ToString()))
                        qapreview.QAPReview = Convert.ToInt32(dataReader["QAPReview"]);
                    else
                        qapreview.QAPReview = 0;
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "GetComments", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return qapreview;
        }

        /// <summary>
        /// Update patient details first tab details.
        /// </summary>
        /// <param name="isCodingIssueIdentified">bool</param>
        /// <param name="comments">string</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdatePatientDetails(bool isDataQualityIssuesIdentified, string dataqualitycomments, bool isCodingIssueIdentified, string comments, string occupation, bool isUrgentMEReview, 
            string UrgentMEReviewComments, string RelativeName, string RelativeTelNo, string Relationship, string GPSurgery, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdatePatientDetails", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@IsDataQualityIssuesIdentified", isDataQualityIssuesIdentified);
                dbCommand.Parameters.AddWithValue("@IsCodingIssueIdentified", isCodingIssueIdentified);
                dbCommand.Parameters.AddWithValue("@DataQualityComments", dataqualitycomments);
                dbCommand.Parameters.AddWithValue("@Comments", comments);
                dbCommand.Parameters.AddWithValue("@Occupation", occupation);
                dbCommand.Parameters.AddWithValue("@UrgentMEReview", isUrgentMEReview);
                dbCommand.Parameters.AddWithValue("@UrgentMEReviewComment", UrgentMEReviewComments);
                dbCommand.Parameters.AddWithValue("@RelativeName", RelativeName);
                dbCommand.Parameters.AddWithValue("@RelativeTelNo", RelativeTelNo);
                dbCommand.Parameters.AddWithValue("@Relationship", Relationship);
                dbCommand.Parameters.AddWithValue("@GPSurgery", GPSurgery);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Insert/Update medical examiner review details for a particular patient ID.
        /// </summary>
        /// <param name="isQAP_Discussion"></param>
        /// <param name="isNotes_Review"></param>
        /// <param name="isNok_Discussion"></param>
        /// <param name="med_id"></param>
        /// <param name="qapname"></param>
        /// <param name="comments"></param>
        /// <param name="id"></param>
        /// <returns></returns>
        public int UpdateMedicalExaminerReview(bool isQAP_Discussion, bool isNotes_Review, bool isNok_Discussion, int med_id, string qapname, string comments, int? id, int userID, int commentTypeID)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateMedicalExaminerReview", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@QAPDiscussion", isQAP_Discussion);
                dbCommand.Parameters.AddWithValue("@NotesReview", isNotes_Review);
                dbCommand.Parameters.AddWithValue("@NoKDiscussion", isNok_Discussion);
                dbCommand.Parameters.AddWithValue("@MedID", med_id);
                dbCommand.Parameters.AddWithValue("@QAPName", "");
                dbCommand.Parameters.AddWithValue("@Comments", comments);
                dbCommand.Parameters.AddWithValue("@CommentTypeID", commentTypeID);
                dbCommand.Parameters.AddWithValue("@UserID", userID);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update SJR 1 step 1 details to database based on patientID
        /// </summary>
        /// <param name="initialManagement">string</param>
        /// <param name="initialManagementRating">int</param>
        /// <param name="ongoingCare">string</param>
        /// <param name="ongoingCareRating">int</param>
        /// <param name="careduringProcedure">string</param>
        /// <param name="careduringProcedureRating">int</param>
        /// <param name="endlifeCare">string</param>
        /// <param name="endlifecareRating">int</param>
        /// <param name="overallAssessment">string</param>
        /// <param name="overallAssessmentRating">int</param>
        /// <param name="qualitOfDocumentation">int</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateSJRFormInitial(string initialManagement, string initialManagementRating, string ongoingCare, string ongoingCareRating,
            string careduringProcedure, string careduringProcedureRating, string endlifeCare, string endlifecareRating, string overallAssessment,
            string overallAssessmentRating, string qualitOfDocumentation, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJRFormInitial", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@InitialManagement", initialManagement);
                dbCommand.Parameters.AddWithValue("@InitialManagementRating", initialManagementRating);
                dbCommand.Parameters.AddWithValue("@OngoingCare", ongoingCare);
                dbCommand.Parameters.AddWithValue("@OngoingCareRating", ongoingCareRating);
                dbCommand.Parameters.AddWithValue("@CareduringProcedure", careduringProcedure);
                dbCommand.Parameters.AddWithValue("@CareduringProcedureRating", careduringProcedureRating);
                dbCommand.Parameters.AddWithValue("@EndlifeCare", endlifeCare);
                dbCommand.Parameters.AddWithValue("@EndlifecareRating", endlifecareRating);
                dbCommand.Parameters.AddWithValue("@OverallAssessment", overallAssessment);
                dbCommand.Parameters.AddWithValue("@OverallAssessmentRating", overallAssessmentRating);
                dbCommand.Parameters.AddWithValue("@QualitOfDocumentation", qualitOfDocumentation);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        public int UpdateSJR2FormInitial(string initialManagement, string initialManagementRating, string ongoingCare, string ongoingCareRating,
            string careduringProcedure, string careduringProcedureRating, string endlifeCare, string endlifecareRating, string overallAssessment,
            string overallAssessmentRating, string qualitOfDocumentation, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJR2FormInitial", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@InitialManagement", initialManagement);
                dbCommand.Parameters.AddWithValue("@InitialManagementRating", initialManagementRating);
                dbCommand.Parameters.AddWithValue("@OngoingCare", ongoingCare);
                dbCommand.Parameters.AddWithValue("@OngoingCareRating", ongoingCareRating);
                dbCommand.Parameters.AddWithValue("@CareduringProcedure", careduringProcedure);
                dbCommand.Parameters.AddWithValue("@CareduringProcedureRating", careduringProcedureRating);
                dbCommand.Parameters.AddWithValue("@EndlifeCare", endlifeCare);
                dbCommand.Parameters.AddWithValue("@EndlifecareRating", endlifecareRating);
                dbCommand.Parameters.AddWithValue("@OverallAssessment", overallAssessment);
                dbCommand.Parameters.AddWithValue("@OverallAssessmentRating", overallAssessmentRating);
                dbCommand.Parameters.AddWithValue("@QualitOfDocumentation", qualitOfDocumentation);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update SJR Outcome details for a particular patient ID
        /// </summary>
        /// <param name="SJR2Required">bool</param>
        /// <param name="Stage2SJRDateSent">DateTime</param>
        /// <param name="Stage2SJRSentTo">string</param>
        /// <param name="ReferenceNumber">string</param>
        /// <param name="DateReceived">DateTime</param>
        /// <param name="SIRIComments">string</param>
        /// <param name="MSGRequired">bool</param>
        /// <param name="MSGDiscussionDate">DateTime</param>
        /// <param name="AvoidabilityScoreID">int</param>
        /// <param name="Comments">string</param>
        /// <param name="FeedbackToNoK">string</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateSJROutcome(bool SJR2Required, string Stage2SJRDateSent, string Stage2SJRSentTo, string ReferenceNumber,
            string DateReceived, string SIRIComments, bool MSGRequired, string MSGDiscussionDate, int AvoidabilityScoreID,
            string Comments, string FeedbackToNoK, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJROutcome", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@SJR2Required", SJR2Required);
                dbCommand.Parameters.AddWithValue("@Stage2SJRDateSent", Stage2SJRDateSent);
                dbCommand.Parameters.AddWithValue("@Stage2SJRSentTo", Stage2SJRSentTo);
                dbCommand.Parameters.AddWithValue("@ReferenceNumber", ReferenceNumber);
                dbCommand.Parameters.AddWithValue("@DateReceived", DateReceived);
                dbCommand.Parameters.AddWithValue("@SIRIComments", SIRIComments);
                dbCommand.Parameters.AddWithValue("@MSGRequired", MSGRequired);
                dbCommand.Parameters.AddWithValue("@MSGDiscussionDate", MSGDiscussionDate);
                dbCommand.Parameters.AddWithValue("@AvoidabilityScoreID", AvoidabilityScoreID);
                dbCommand.Parameters.AddWithValue("@Comments", Comments);
                dbCommand.Parameters.AddWithValue("@FeedbackToNoK", FeedbackToNoK);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update coding review.
        /// </summary>
        /// <param name="codingIssue">bool</param>
        /// <param name="Comments">string</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateCodingReview(bool codingIssue, string Comments, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateCodingReview", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@CodingIssue", codingIssue);
                dbCommand.Parameters.AddWithValue("@Comments", Comments);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update QAP review.
        /// </summary>
        /// <param name="mccd">bool</param>
        /// <param name="referral">bool</param>
        /// <param name="synopsis">string</param>
        /// <param name="reason">string</param>
        /// <param name="fullname">string</param>
        /// <param name="gmcno">string</param>
        /// <param name="location">string</param>
        /// <param name="phone">string</param>
        /// <param name="altphone">string</param>
        /// <param name="createdby">string</param>
        /// <param name="createddate">string</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateQAPReview(bool mccd, bool referral, string synopsis, string reason, string fullname, string gmcno, string location, string phone, string altphone, string createdby,
            string createddate, bool concern, string reason1a, string interval1, string reason1b, string interval2, string reason1c, string interval3, string reason2, string interval4, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateQAPReview", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@MCCD", mccd);
                dbCommand.Parameters.AddWithValue("@Referral", referral);
                dbCommand.Parameters.AddWithValue("@Synopsis", synopsis);
                dbCommand.Parameters.AddWithValue("@Reason", reason);
                dbCommand.Parameters.AddWithValue("@FullName", fullname);
                dbCommand.Parameters.AddWithValue("@GMCNo", gmcno);
                dbCommand.Parameters.AddWithValue("@Location", location);
                dbCommand.Parameters.AddWithValue("@Phone", phone);
                dbCommand.Parameters.AddWithValue("@AltPhone", altphone);
                dbCommand.Parameters.AddWithValue("@CreatedBy", createdby);
                dbCommand.Parameters.AddWithValue("@CreatedDate", createddate);
                dbCommand.Parameters.AddWithValue("@Concern", concern);
                dbCommand.Parameters.AddWithValue("@Reason1a", reason1a);
                dbCommand.Parameters.AddWithValue("@Reason1b", reason1b);
                dbCommand.Parameters.AddWithValue("@Reason1c", reason1c);
                dbCommand.Parameters.AddWithValue("@Reason2", reason2);
                dbCommand.Parameters.AddWithValue("@Interval1", interval1);
                dbCommand.Parameters.AddWithValue("@Interval2", interval2);
                dbCommand.Parameters.AddWithValue("@Interval3", interval3);
                dbCommand.Parameters.AddWithValue("@Interval4", interval4);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        public int UpdateSJR1ProblemType(int AssessmentResponseID, int AssessmentCarePhaseID, int MedicationResponseID, int MedicationCarePhaseID,
            int TreatmentResponseID, int TreatmentCarePhaseID, int InfectionResponseID, int InfectionCarePhaseID, int ProcedureResponseID,
            int ProcedureCarePhaseID, int MonitoringResponseID, int ResuscitationResponseID, int OthertypeResponseID, int OthertypeCarePhaseID, int AvoidabilityScoreID, 
            string Comments, string SIRIComments, bool ProblemOccured, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJR1ProblemType", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@AssessmentResponseID", AssessmentResponseID);
                dbCommand.Parameters.AddWithValue("@AssessmentCarePhaseID", AssessmentCarePhaseID);
                dbCommand.Parameters.AddWithValue("@MedicationResponseID", MedicationResponseID);
                dbCommand.Parameters.AddWithValue("@MedicationCarePhaseID", MedicationCarePhaseID);
                dbCommand.Parameters.AddWithValue("@TreatmentResponseID", TreatmentResponseID);
                dbCommand.Parameters.AddWithValue("@TreatmentCarePhaseID", TreatmentCarePhaseID);
                dbCommand.Parameters.AddWithValue("@InfectionResponseID", InfectionResponseID);
                dbCommand.Parameters.AddWithValue("@InfectionCarePhaseID", InfectionCarePhaseID);
                dbCommand.Parameters.AddWithValue("@ProcedureResponseID", ProcedureResponseID);
                dbCommand.Parameters.AddWithValue("@ProcedureCarePhaseID", ProcedureCarePhaseID);
                dbCommand.Parameters.AddWithValue("@MonitoringResponseID", MonitoringResponseID);
                dbCommand.Parameters.AddWithValue("@ResuscitationResponseID", ResuscitationResponseID);
                dbCommand.Parameters.AddWithValue("@OthertypeResponseID", OthertypeResponseID);
                dbCommand.Parameters.AddWithValue("@OthertypeCarePhaseID", OthertypeCarePhaseID);
                dbCommand.Parameters.AddWithValue("@AvoidabilityScoreID", AvoidabilityScoreID);
                dbCommand.Parameters.AddWithValue("@Comments", Comments);
                dbCommand.Parameters.AddWithValue("@ProblemOccured", ProblemOccured);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        public int UpdateSJR2ProblemType(int AssessmentResponseID, int AssessmentCarePhaseID, int MedicationResponseID, int MedicationCarePhaseID,
            int TreatmentResponseID, int TreatmentCarePhaseID, int InfectionResponseID, int InfectionCarePhaseID, int ProcedureResponseID,
            int ProcedureCarePhaseID, int MonitoringResponseID, int ResuscitationResponseID, int OthertypeResponseID, int OthertypeCarePhaseID, int AvoidabilityScoreID,
            string Comments, string SIRIComments, bool ProblemOccured, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJR2ProblemType", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@AssessmentResponseID", AssessmentResponseID);
                dbCommand.Parameters.AddWithValue("@AssessmentCarePhaseID", AssessmentCarePhaseID);
                dbCommand.Parameters.AddWithValue("@MedicationResponseID", MedicationResponseID);
                dbCommand.Parameters.AddWithValue("@MedicationCarePhaseID", MedicationCarePhaseID);
                dbCommand.Parameters.AddWithValue("@TreatmentResponseID", TreatmentResponseID);
                dbCommand.Parameters.AddWithValue("@TreatmentCarePhaseID", TreatmentCarePhaseID);
                dbCommand.Parameters.AddWithValue("@InfectionResponseID", InfectionResponseID);
                dbCommand.Parameters.AddWithValue("@InfectionCarePhaseID", InfectionCarePhaseID);
                dbCommand.Parameters.AddWithValue("@ProcedureResponseID", ProcedureResponseID);
                dbCommand.Parameters.AddWithValue("@ProcedureCarePhaseID", ProcedureCarePhaseID);
                dbCommand.Parameters.AddWithValue("@MonitoringResponseID", MonitoringResponseID);
                dbCommand.Parameters.AddWithValue("@ResuscitationResponseID", ResuscitationResponseID);
                dbCommand.Parameters.AddWithValue("@OthertypeResponseID", OthertypeResponseID);
                dbCommand.Parameters.AddWithValue("@OthertypeCarePhaseID", OthertypeCarePhaseID);
                dbCommand.Parameters.AddWithValue("@AvoidabilityScoreID", AvoidabilityScoreID);
                dbCommand.Parameters.AddWithValue("@Comments", Comments);
                dbCommand.Parameters.AddWithValue("@ProblemOccured", ProblemOccured);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        public int UpdatePositiveFeedback(bool isFormCompleted, bool isComplementsFedBack, string Comments, int FBTypeID, int? id,int Userid)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdatePositiveFeedbackData", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@FormCompleted", isFormCompleted);
                dbCommand.Parameters.AddWithValue("@ComplementsFedBack", isComplementsFedBack);
                dbCommand.Parameters.AddWithValue("@Comments", Comments);
                dbCommand.Parameters.AddWithValue("@ID", id);
                dbCommand.Parameters.AddWithValue("@FBTypeID", FBTypeID);
                dbCommand.Parameters.AddWithValue("@UserId", Userid);
                
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update SJR Assessment Triage Details for a particular patient ID
        /// </summary>
        /// <param name="isPaediatricPatient">bool</param>
        /// <param name="isLearningDisabilityPatient">bool</param>
        /// <param name="isMentalillnessPatient">bool</param>
        /// <param name="isElectiveAdmission">bool</param>
        /// <param name="isNoKConcernsDeath">bool</param>
        /// <param name="isOtherConcern">bool</param>
        /// <param name="isFullSJRRequired">bool</param>
        /// <param name="otherConcernDetails">string</param>
        /// <param name="specialityID">int</param>
        /// <param name="id">int</param>
        /// <returns>int</returns>
        public int UpdateSJRAssessmentTriage(bool isPaediatricPatient, bool isLearningDisabilityPatient, bool isMentalillnessPatient, bool isElectiveAdmission, bool isNoKConcernsDeath, bool isOtherConcern,
            bool isFullSJRRequired, string otherConcernDetails, int specialityID, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateSJRAssessmentTriage", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PaediatricPatient", isPaediatricPatient);
                dbCommand.Parameters.AddWithValue("@LearningDisabilityPatient", isLearningDisabilityPatient);
                dbCommand.Parameters.AddWithValue("@MentalillnessPatient", isMentalillnessPatient);
                dbCommand.Parameters.AddWithValue("@ElectiveAdmission", isElectiveAdmission);
                dbCommand.Parameters.AddWithValue("@NoKConcernsDeath", isNoKConcernsDeath);
                dbCommand.Parameters.AddWithValue("@OtherConcern", isOtherConcern);
                dbCommand.Parameters.AddWithValue("@FullSJRRequired", isFullSJRRequired);
                dbCommand.Parameters.AddWithValue("@otherConcernDetails", otherConcernDetails);
                dbCommand.Parameters.AddWithValue("@specialityID", specialityID);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Update other referrals based on particular patient ID
        /// </summary>
        /// <param name="isPatientSafetySIRI">bool</param>
        /// <param name="isChildDeathCoordinator">bool</param>
        /// <param name="isLearningDisabilityNurse">bool</param>
        /// <param name="isHeadOfCompliance">bool</param>
        /// <param name="isPALsComplaints">bool</param>
        /// <param name="isWardTeam">bool</param>
        /// <param name="isOther">bool</param>
        /// <param name="PatientSafetySIRIReason">string</param>
        /// <param name="HeadOfComplianceReason">string</param>
        /// <param name="PALsComplaintsReason">string</param>
        /// <param name="WardTeamReason">string</param>
        /// <param name="OtherReason">string</param>
        /// <param name="specialityID">int</param>
        /// <param name="id">int</param>
        /// <returns></returns>
        public int UpdateOtherReferrals(bool isPatientSafetySIRI, bool isChildDeathCoordinator, bool isLearningDisabilityNurse, bool isHeadOfCompliance, bool isPALsComplaints, bool isWardTeam,
            bool isOther, string PatientSafetySIRIReason, string HeadOfComplianceReason, string PALsComplaintsReason, string WardTeamReason, string OtherReason, bool isSafeGuard, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateOtherReferrals", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@PatientSafetySIRI", isPatientSafetySIRI);
                dbCommand.Parameters.AddWithValue("@ChildDeathCoordinator", isChildDeathCoordinator);
                dbCommand.Parameters.AddWithValue("@LearningDisabilityNurse", isLearningDisabilityNurse);
                dbCommand.Parameters.AddWithValue("@HeadOfCompliance", isHeadOfCompliance);
                dbCommand.Parameters.AddWithValue("@PALsComplaints", isPALsComplaints);
                dbCommand.Parameters.AddWithValue("@WardTeam", isWardTeam);
                dbCommand.Parameters.AddWithValue("@Other", isOther);
                dbCommand.Parameters.AddWithValue("@PatientSafetySIRIReason", PatientSafetySIRIReason);
                dbCommand.Parameters.AddWithValue("@HeadOfComplianceReason", HeadOfComplianceReason);
                dbCommand.Parameters.AddWithValue("@PALsComplaintsReason", PALsComplaintsReason);
                dbCommand.Parameters.AddWithValue("@WardTeamReason", WardTeamReason);
                dbCommand.Parameters.AddWithValue("@OtherReason", OtherReason);
                dbCommand.Parameters.AddWithValue("@SafeGuard", isSafeGuard);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        public int UpdateDeclaration(bool isDeclaration, string CreatedBy, string CreatedDate, string Office, int? id)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_UpdateDeclaration", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@Declaration", isDeclaration);
                dbCommand.Parameters.AddWithValue("@CreatedBy", CreatedBy);
                dbCommand.Parameters.AddWithValue("@CreatedDate", CreatedDate);
                dbCommand.Parameters.AddWithValue("@Office", Office);
                dbCommand.Parameters.AddWithValue("@ID", id);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            return retVal;
        }

        /// <summary>
        /// Get Other referral tab details for a particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsOtherReferralModel</returns>
        public clsOtherReferralModel GetOtherReferrals(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            clsOtherReferralModel otherReferralModel = new clsOtherReferralModel();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetOtherReferrals", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    otherReferralModel.Patient_ID = Convert.ToInt32(dbReader["Patient_ID"]);
                    otherReferralModel.PatientID = Convert.ToString(dbReader["PatientID"]);
                    otherReferralModel.PatientSafetySIRI = Convert.ToBoolean(dbReader["PatientSafetySIRI"]);
                    otherReferralModel.PatientSafetySIRIReason = Convert.ToString(dbReader["PatientSafetySIRIReason"]);
                    otherReferralModel.ChildDeathCoordinator = Convert.ToBoolean(dbReader["ChildDeathCoordinator"]);
                    otherReferralModel.LearningDisabilityNurse = Convert.ToBoolean(dbReader["LearningDisabilityNurse"]);
                    otherReferralModel.HeadOfCompliance = Convert.ToBoolean(dbReader["HeadOfCompliance"]);
                    otherReferralModel.HeadOfComplianceReason = Convert.ToString(dbReader["HeadOfComplianceReason"]);
                    otherReferralModel.PALsComplaints = Convert.ToBoolean(dbReader["PALsComplaints"]);
                    otherReferralModel.PALsComplaintsReason = Convert.ToString(dbReader["PALsComplaintsReason"]);
                    otherReferralModel.WardTeam = Convert.ToBoolean(dbReader["WardTeam"]);
                    otherReferralModel.WardTeamReason = Convert.ToString(dbReader["WardTeamReason"]);
                    otherReferralModel.Other = Convert.ToBoolean(dbReader["Other"]);
                    otherReferralModel.OtherReason = Convert.ToString(dbReader["OtherReason"]);
                    otherReferralModel.SafeGuardTeamNotified = Convert.ToBoolean(dbReader["SafeGuard"]);
                    if (!string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        otherReferralModel.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    else
                        otherReferralModel.MedTriage = 2;
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (otherReferralModel.Patient_ID == 0 || otherReferralModel.Patient_ID == null) otherReferralModel.Patient_ID = Convert.ToInt32(id);
            return otherReferralModel;
        }

        /// <summary>
        /// Get Other referral tab details for a particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsOtherReferralModel</returns>
        public clsDeclarationModel GetDeclaration(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            clsDeclarationModel declaration = new clsDeclarationModel();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetMEDeclaration", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    declaration.Patient_ID = Convert.ToInt32(dbReader["Patient_ID"]);
                    if (string.IsNullOrEmpty(dbReader["Declaration"].ToString()))
                        declaration.Declaration = false;
                    else
                        declaration.Declaration = Convert.ToBoolean(dbReader["Declaration"]);
                    if (string.IsNullOrEmpty(dbReader["CreatedBy"].ToString()))
                        declaration.CreatedBy = "";
                    else
                        declaration.CreatedBy = Convert.ToString(dbReader["CreatedBy"]);
                    if (string.IsNullOrEmpty(dbReader["CreatedDate"].ToString()))
                        declaration.CreatedDate = "";
                    else
                        declaration.CreatedDate = Convert.ToDateTime(dbReader["CreatedDate"]).ToString("dd/MM/yyyy");
                    if (!string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        declaration.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    else
                        declaration.MedTriage = 2;
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (declaration.Patient_ID == 0 || declaration.Patient_ID == null) declaration.Patient_ID = Convert.ToInt32(id);
            return declaration;
        }

        /// <summary>
        /// Get medical examiner decision tab details for a particular ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsMedicalExaminerDecision</returns>
        public clsMedicalExaminerDecision GetMedicalExaminerDecision(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            clsMedicalExaminerDecision medicalExaminerDecision = new clsMedicalExaminerDecision();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetMedicalExaminerDecision", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {                    
                    medicalExaminerDecision.ID = Convert.ToInt32(dbReader["Patient_ID"]);
                    medicalExaminerDecision.PatientID = Convert.ToString(dbReader["PatientID"]);
                    medicalExaminerDecision.MCCDissue = Convert.ToBoolean(dbReader["MCCDissue"]);
                    medicalExaminerDecision.CoronerReferral = Convert.ToBoolean(dbReader["CoronerReferral"]);
                    medicalExaminerDecision.HospitalPostMortem = Convert.ToBoolean(dbReader["HospitalPostMortem"]);
                    medicalExaminerDecision.CoronerReferralReason = Convert.ToString(dbReader["ReferralReason"]);
                    medicalExaminerDecision.CauseOfDeath1 = Convert.ToString(dbReader["CauseOfDeath1"]);
                    medicalExaminerDecision.CauseOfDeath2 = Convert.ToString(dbReader["CauseOfDeath2"]);
                    medicalExaminerDecision.CauseOfDeath3 = Convert.ToString(dbReader["CauseOfDeath3"]);
                    medicalExaminerDecision.CauseOfDeath4 = Convert.ToString(dbReader["CauseOfDeath4"]);
                    medicalExaminerDecision.DeathCertificate = Convert.ToBoolean(dbReader["DeathCertificate"]);
                    medicalExaminerDecision.CornerReferralComplete = Convert.ToBoolean(dbReader["CornerReferralComplete"]);
                    medicalExaminerDecision.CoronerDecisionInquest = Convert.ToBoolean(dbReader["CoronerDecisionInquest"]);
                    medicalExaminerDecision.CoronerDecision100A = Convert.ToBoolean(dbReader["CoronerDecision100A"]);
                    medicalExaminerDecision.CoronerDecisionGPissue = Convert.ToBoolean(dbReader["CoronerDecisionGPissue"]);
                    medicalExaminerDecision.CoronerDecisionPostMortem = Convert.ToBoolean(dbReader["CoronerDecisionPostMortem"]);
                    if (!string.IsNullOrEmpty(dbReader["CauseID"].ToString()))
                        medicalExaminerDecision.CauseID = Convert.ToInt32(dbReader["CauseID"]);
                    else
                        medicalExaminerDecision.CauseID = 0;
                    if (string.IsNullOrEmpty(dbReader["DeathCertificateDate"].ToString()))
                        medicalExaminerDecision.DeathCertificateDate = "";
                    else
                        medicalExaminerDecision.DeathCertificateDate = Convert.ToDateTime(dbReader["DeathCertificateDate"]).ToString("dd/MM/yyyy");
                    medicalExaminerDecision.DeathCertificateTime = Convert.ToString(dbReader["DeathCertificateTime"]);
                    medicalExaminerDecision.TimeType = Convert.ToString(dbReader["TimeType"]);
                    if (!string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        medicalExaminerDecision.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    else
                        medicalExaminerDecision.MedTriage = 2;
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (medicalExaminerDecision.ID == 0 || medicalExaminerDecision.ID == null)
                medicalExaminerDecision.ID = Convert.ToInt32(id);
            return medicalExaminerDecision;
        }

        /// <summary>
        /// Get SJR assesment triage details for a particular patient ID
        /// </summary>
        /// <param name="id">int</param>
        /// <returns>clsSJRReview</returns>
        public clsSJRReview GetSJRAssesmentTraige(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            clsSJRReview sJRReview = new clsSJRReview();
            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetSJRAssessmentTriage", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    sJRReview.Patient_ID = Convert.ToInt32(dbReader["Patient_ID"]);
                    sJRReview.PatientID = Convert.ToString(dbReader["PatientID"]);
                    sJRReview.PaediatricPatient = Convert.ToBoolean(dbReader["PaediatricPatient"]);
                    sJRReview.LearningDisabilityPatient = Convert.ToBoolean(dbReader["LearningDisabilityPatient"]);
                    sJRReview.MentalillnessPatient = Convert.ToBoolean(dbReader["MentalillnessPatient"]);
                    sJRReview.ElectiveAdmission = Convert.ToBoolean(dbReader["ElectiveAdmission"]);
                    sJRReview.NoKConcernsDeath = Convert.ToBoolean(dbReader["NoKConcernsDeath"]);
                    sJRReview.OtherConcern = Convert.ToBoolean(dbReader["OtherConcern"]);
                    sJRReview.OtherConcernDetails = Convert.ToString(dbReader["OtherConcernDetails"]);
                    sJRReview.FullSJRRequired = Convert.ToBoolean(dbReader["FullSJRRequired"]);
                    sJRReview.SpecialityID = Convert.ToInt32(dbReader["SpecialityID"]);
                    if (!string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        sJRReview.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    else
                        sJRReview.MedTriage = 2;
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (sJRReview.Patient_ID == 0) sJRReview.Patient_ID = Convert.ToInt32(id);
            return sJRReview;
        }

        /// <summary>
        /// Get medical examiner review details for patient ID
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public clsMedicalExaminerReview GetMedicalExaminerReview(int? id)
        {
            var connection = GetConnection();
            SqlDataReader dbReader = null;
            clsMedicalExaminerReview medicalExaminerReview = new clsMedicalExaminerReview();

            try
            {
                SqlCommand dbCmd = new SqlCommand("usp_GetMedicalExamierReview", connection);
                dbCmd.CommandType = CommandType.StoredProcedure;
                if (id != null)
                    dbCmd.Parameters.AddWithValue("@PatientID", id);
                else
                    dbCmd.Parameters.AddWithValue("@PatientID", null);

                dbReader = dbCmd.ExecuteReader();

                while (dbReader.Read())
                {
                    medicalExaminerReview.Patient_ID = Convert.ToInt32(dbReader["Patient_ID"]);
                    medicalExaminerReview.PatientID = Convert.ToString(dbReader["PatientID"]);
                    medicalExaminerReview.ME_ID = Convert.ToInt32(dbReader["ME_ID"]);
                    medicalExaminerReview.QAP_Discussion = Convert.ToBoolean(dbReader["QAP_Discussion"]);
                    medicalExaminerReview.Notes_Review = Convert.ToBoolean(dbReader["Notes_Review"]);
                    medicalExaminerReview.Nok_Discussion = Convert.ToBoolean(dbReader["Nok_Discussion"]);
                    if (string.IsNullOrEmpty(dbReader["QAPName"].ToString()))
                        medicalExaminerReview.QAPName = "";
                    else
                        medicalExaminerReview.QAPName = Convert.ToString(dbReader["QAPName"]);
                    if (!string.IsNullOrEmpty(dbReader["CommentCount"].ToString()))
                        medicalExaminerReview.CommentCount = Convert.ToInt32(dbReader["CommentCount"]);
                    else
                        medicalExaminerReview.CommentCount = 0;
                    if (!string.IsNullOrEmpty(dbReader["MedTriage"].ToString()))
                        medicalExaminerReview.MedTriage = Convert.ToInt32(dbReader["MedTriage"]);
                    else
                        medicalExaminerReview.MedTriage = 2;
                    medicalExaminerReview.Comments = "";
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dbReader.IsClosed)
                    dbReader.Close();
            }
            if (medicalExaminerReview.Patient_ID == 0) medicalExaminerReview.Patient_ID = Convert.ToInt32(id);
            return medicalExaminerReview;
        }

        /// <summary>
        /// Get list of users in the system who are in Medical Examiner role.
        /// </summary>
        /// <returns>List<clsMedicalExaminers></returns>
        public List<clsMedicalExaminers> GetMedicalExaminers()
        {
            var connection = GetConnection();
            List<clsMedicalExaminers> medicalExaminers = new List<clsMedicalExaminers>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetMedicalExaminers", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    clsMedicalExaminers medicalExaminer = new clsMedicalExaminers();
                    medicalExaminer.ID = Convert.ToInt32(dataReader["ID"]);
                    medicalExaminer.Email = Convert.ToString(dataReader["Email"]);
                    medicalExaminer.Code = Convert.ToString(dataReader["Code"]);
                    medicalExaminer.Name = Convert.ToString(dataReader["Name"]);
                    medicalExaminer.UserID = Convert.ToString(dataReader["UserID"]);
                    medicalExaminer.Speciality = Convert.ToString(dataReader["Speciality"]);
                    medicalExaminer.Role = Convert.ToString(dataReader["Role"]);
                    medicalExaminers.Add(medicalExaminer);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return medicalExaminers;
        }

        /// <summary>
        /// Get All coroner referral reasons from the database
        /// </summary>
        /// <returns>List<clsCoronerReferralReason></returns>
        public List<ReasonGroups> GetReasonGroups()
        {
            var connection = GetConnection();
            List<ReasonGroups> reasonGroups = new List<ReasonGroups>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_ReasonGroups", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;

                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    ReasonGroups reasonGroup = new ReasonGroups();
                    reasonGroup.GroupID = Convert.ToInt32(dataReader["GroupID"]);
                    reasonGroup.GroupName = Convert.ToString(dataReader["GroupName"]);
                    reasonGroups.Add(reasonGroup);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return reasonGroups;
        }

        /// <summary>
        /// Get all referral reasons based on reason group ID
        /// </summary>
        /// <param name="groupid">int</param>
        /// <returns>List<clsCoronerReferralReason></returns>
        public List<clsCoronerReferralReason> GetCoronerReferralReasons(int? groupid)
        {
            var connection = GetConnection();
            List<clsCoronerReferralReason> reasonNames = new List<clsCoronerReferralReason>();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_GetCoronerReferrals", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                if (groupid != null)
                    dbCommand.Parameters.AddWithValue("@GroupID", groupid);
                else
                    dbCommand.Parameters.AddWithValue("@GroupID", 0);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    clsCoronerReferralReason reasonName = new clsCoronerReferralReason();
                    reasonName.Reason_ID = Convert.ToInt32(dataReader["Reason_ID"]);
                    reasonName.ReasonName = Convert.ToString(dataReader["ReasonName"]);
                    reasonNames.Add(reasonName);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return reasonNames;
        }
        
        /// <summary>
        /// Checks if the user exists
        /// </summary>
        /// <param name="UserName">user alias</param>
        /// <returns>0 if user does not exit , 1 if user exists</returns>
        public AppUsers ValidateUser(string userName, string password)
        {
            var connection = GetConnection();
            AppUsers user = new AppUsers();
            SqlDataReader dataReader = null;

            try
            {
                SqlCommand dbCommand = new SqlCommand("usp_ValidateUser", connection);
                dbCommand.CommandType = CommandType.StoredProcedure;
                if (userName != null)
                    dbCommand.Parameters.AddWithValue("@UserID", userName);
                else
                    dbCommand.Parameters.AddWithValue("@UserID", "");
                dbCommand.Parameters.AddWithValue("@Password", password);
                dataReader = dbCommand.ExecuteReader();

                while (dataReader.Read())
                {
                    user.IsFound = Convert.ToBoolean(dataReader["IsFound"]);
                    user.FirstName = Convert.ToString(dataReader["FirstName"]);
                    user.LastName = Convert.ToString(dataReader["LastName"]);
                    user.ID = Convert.ToInt32(dataReader["ID"]);
                    user.Role = Convert.ToString(dataReader["Role"]);
                }
            }
            catch (Exception ex)
            {
                LogException(ex.Message, this.ToString(), "ValidateUser", System.DateTime.Now);
            }
            finally
            {
                if (!dataReader.IsClosed)
                    dataReader.Close();
            }
            return user;
        }

        /// <summary>
        /// Log exception to exceptionlog table
        /// </summary>
        /// <param name="message">string</param>
        /// <param name="className">string</param>
        /// <param name="methodName">string</param>
        /// <param name="createdDate">DateTime</param>
        public void LogException(string message, string className, string methodName, DateTime createdDate)
        {
            var connection = GetConnection();
            int retVal = 0;
            SqlCommand dbCommand = new SqlCommand("usp_InsertLogException", connection);
            try
            {
                dbCommand.CommandType = CommandType.StoredProcedure;
                dbCommand.Parameters.AddWithValue("@Message", message);
                dbCommand.Parameters.AddWithValue("@ClassName", className);
                dbCommand.Parameters.AddWithValue("@MethodName", methodName);
                dbCommand.Parameters.AddWithValue("@CreatedDate", createdDate);
                retVal = dbCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
            }
        }        
    }
}
