using System;
using System.Collections.Generic;
//using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace NHS.Common
{
    public class clsPatientDetailsModel
    {

        public clsPatientDetails objclPatientDetails { get; set; }
        public List<clsClinicalCoding> CilinicalCoding { get; set; }
    }

    public class clPatientDetailsDashbord
    {
        public List<clsPatientDetailsDashbord> PatientDtls { get; set; }
        //public List<clsClinicalCoding> clinicalCoding { get; set; }
        //public List<clsBindPatientDetailsSJRReview> PatientDtlsAndSJRReview { get; set; }
    }

    public class DischargeSpecialityNames
    {
        public string DischargeSpecialityCode { get; set; }
        public string DischargeSpeciality { get; set; }
    }

    public class WardOfDeaths
    {
        public string WardOfDeath { get; set; }
    }

    public class Specialities
    {
        public int SpecialityID { get; set; }
        public string SpecialityName { get; set; }
    }

    public class DischargeConsultants
    { 
        public string DischargeConsultantCode { get; set; }
        public string DischargeConsultantName { get; set; }
    }

    public class PatientTypes
    {
        public int ID { get; set; }
        public string PatientType { get; set; }
        public string PatientTypeLongText { get; set; }
    }

    public class clsQualityReview
    {
        public int QualityR_ID          {get;set;}
        public string  sourceReview 	{get;set;}
        public DateTime ReviewDate 		{get;set;}
        public string ReviewerName 		{get;set;}
        public string Spell 			{get;set;}
        public string Summary 			{get;set;}
        public string isCodingIssue 	{get;set;}
        public string isTimingIssue 	{get;set;}
        public string isDataSysIssue 	{get;set;}
        public string isClinicalReview 	{get;set;}
        public string isProcessReview 	{get;set;}
        public string Recom 			{get;set;}
        public bool isReviewCompleted { get; set; }
        public int Patient_ID { get; set; }
        
    }

        public class clsQAPReview
    {
        public int Patient_ID { get; set; }

        public string Synopsis { get; set; }

        public bool MCCD { get; set; }

        public bool Referral { get; set; }

        public string Reason { get; set; }

        public string FullName { get; set; }

        public string GMCNo { get; set; }

        public string Location { get; set; }

        public string Phone { get; set; }

        public string AlternatePhone { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public bool Concern { get; set; }

        public string Reason1a { get; set; }

        public string Reason1b { get; set; }

        public string Reason1c { get; set; }

        public string Reason2 { get; set; }

        public string Interval1 { get; set; }

        public string Interval2 { get; set; }

        public string Interval3 { get; set; }

        public string Interval4 { get; set; }

        public int QAPReview { get; set; }

        public bool ReviewCompleted { get; set; }

    }

    public class clsPatientDetails
    {
        public int ID { get; set; }
        public string PatientId { get; set; }
        public string SpellNumber { get; set; }
        //[Display(Name = "Patient Name")]
        public string PatientName { get; set; }
        //[Display(Name = "MRN")]
        public string NHSNumber { get; set; }
        //[Display(Name = "Gender")]
        public string Gender { get; set; }
        //[Display(Name = "Patient age at time of death")]
        public Nullable<int> Age { get; set; }
        public string DOB { get; set; }
        //[Display(Name = "Day/ Date of Admission")]
        public DateTime DateofAdmission { get; set; }
        //[Display(Name = "Time of arrival")]
        public string TimeofAdmission { get; set; }
        //[Display(Name = "Ward (on discharge)")]
        public string DischargeWard { get; set; }
        //[Display(Name = "Day/ Date of Death")]
        public DateTime DateofDeath { get; set; }
        //[Display(Name = "Time of death")]
        public string TimeofDeath { get; set; }
        public string WardofDeath { get; set; }
        public string DischargeConsultantCode { get; set; }
        public string DischargeConsutantName { get; set; }
        public string DischargeSpecialtyCode { get; set; }
        public string DischargeSpeciality { get; set; }
        public string Caregroup { get; set; }
        //[Display(Name = "Emergency / Planned Admission")]
        public string PrimaryDiagnosis { get; set; }
        public string PrimaryProcedure { get; set; }
        public string AdmissionType { get; set; }
        public int MedTriage { get; set; }
        public int SJR1 { get; set; }
        public int SJR2 { get; set; }
        public int SJROutcome { get; set; }
        public bool IsFullSJRRequired { get; set; }
        public int ProcedureCount { get; set; }
        public int DiagnosisCount { get; set; }
        //[Display(Name = "Primary Diagnosis")]
        public Nullable<int> ComorbiditiesCount { get; set; }
        public string SHMIGroup { get; set; }
        public bool CodingIssueIdentified { get; set; }
        //[Display(Name = "Comments on coding")]
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public bool Stage2SJRRequired { get; set; }

        public int CodingReview { get; set; }

        public int QAPReview { get; set; }

        public string Occupation { get; set; }

        public bool CodingIssue { get; set; }

        public string UserRole { get; set; }

        public string PatientType { get; set; }

        public string PatientTypeLongText { get; set; }

        public bool DataQualityIssuesIdentified { get; set; }

        public string DataQualityIssueComments { get; set; }

        public int QAPCount { get; set; }

        public int MedCount { get; set; }

        public bool UrgentMEReview { get; set; }

        public string UrgentMEReviewComment { get; set; }

        public string RelativeName { get; set; }

        public string RelativeTelNo { get; set; }

        public string Relationship { get; set; }

        public string GPSurgery { get; set; }

        public bool PresentAtDeath { get; set; }

        public bool IsInformed { get; set; }

        public int KinId1 { get; set; }
        public string RelativeName1 { get; set; }

        public string RelativeTelNo1 { get; set; }

        public string Relationship1 { get; set; }

        public bool PresentAtDeath1 { get; set; }

        public bool IsInformed1 { get; set; }
        public int KinId { get; set; }
        public int KinId2 { get; set; }
        public string RelativeName2 { get; set; }

        public string RelativeTelNo2 { get; set; }

        public string Relationship2 { get; set; }

        public bool PresentAtDeath2 { get; set; }

        public bool IsInformed2 { get; set; }
        public List<NextOfKin> lstNEXTKin { get; set; }
        public string TypeOfPatient { get; set; }

        public int AgeAtDeath { get; set; }

        public int PatientTypeActual { get; set; }
    }

    public class NextOfKin
    {
        public int NextOfKinID { get; set; }
        public string PatientID { get; set; }

        public string RelativeName { get; set; }
        public string RelativeTelNo { get; set; }
        public string Relationship { get; set; }
        public bool PresentAtDeath { get; set; }
        public bool IsInformed { get; set; }
    }

    public class Diagnosis
    {
        public int FCENumber { get; set; }
        public int ComorbidityFlag { get; set; }
        public string Position { get; set; }

        public string DischargeConsultantName { get; set; }

        public string DischargeSpeciality { get; set; }

        public string EpisodeStart { get; set; }

        public string EpisodeEnd { get; set; }

        public string LOSEpisode { get; set; }

        public string DiagnosisDescription { get; set; }

        public int PrimaryInt { get; set; }
    }

    public class Procedures
    {
        public int FCENumber { get; set; }
        public string Position { get; set; }
        public string DischargeConsultantName { get; set; }

        public string DischargeSpeciality { get; set; }

        public string EpisodeStart { get; set; }

        public string EpisodeEnd { get; set; }

        public string LOSEpisode { get; set; }

        public string ProcedureDescription { get; set; }
    }

    public class CommentHistory
    {
        public int UserID { get; set; }

        public string Name { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedTime { get; set; }

        public string Comments { get; set; }
        public int CommentTypeID { get; set; }
        public string CommentType { get; set; }
        public string Role { get; set; }
    }

    public class clsMedicalExaminers
    {
        public int ID { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string UserID { get; set; }
        public string Speciality { get; set; }
    }

    public class clsPatientDetailsDashbord
    {
        public int ID { get; set; }
        public string PatientId { get; set; }
        public Nullable<int> SpellNumber { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> NHSNumber { get; set; }
        public string Gender { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<System.DateTime> DOB { get; set; }
        public Nullable<System.DateTime> DateofAdmission { get; set; }
        public Nullable<System.TimeSpan> TimeofAdmission { get; set; }
        public string DischargeWard { get; set; }
        public Nullable<System.DateTime> DateofDeath { get; set; }
        public Nullable<System.TimeSpan> TimeofDeath { get; set; }
        public string WardofDeath { get; set; }
        public string DischargeConsultantCode { get; set; }
        public string DischargeConsutantName { get; set; }
        public string DischargeSpecialtyCode { get; set; }
        public string DischargeSpeciality { get; set; }
        public string Caregroup { get; set; }
        public string AdmissionType { get; set; }
        public string PrimaryDiagnosis { get; set; }
        public string PrimaryProcedure { get; set; }
        public Nullable<int> ComorbiditiesCount { get; set; }
        public string SHMIGroup { get; set; }
        public bool CodingIssueIdentified { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        

        public Nullable<int> PatientID { get; set; }
        public string Spellnumber { get; set; }
        public Nullable<int> METriage { get; set; }
        public Nullable<int> SJR1 { get; set; }
        public Nullable<int> SJR2 { get; set; }
        public Nullable<int> SJRoutcome { get; set; }
        public string MortalityReview { get; set; }
        public string CodingReview { get; set; }

       
        public Nullable<bool> FullSJRRequired { get; set; }
    }


    //public class clsBindPatientDetailsSJRReview
    //{
    //    public int PatientId { get; set; }
    //    [Display(Name = "Patient Name")]
    //    public string PatientName { get; set; }
    //    [Display(Name = "MRN")]
    //    public string MRN { get; set; }
    //    [Display(Name = "Patient age at time of death")]
    //    public Nullable<int> Age { get; set; }
    //    [Display(Name = "Day/ Date of Admission")]
    //    public Nullable<System.DateTime> DateofAdmission { get; set; }
    //    [Display(Name = "Ward (on discharge)")]
    //    public string DischargeWard { get; set; }
    //    public int DischargeConsultantCode { get; set; }
    //    [Display(Name = "Emergency / Planned Admission")]
    //    public string EmergencyAdmission { get; set; }
    //    [Display(Name = "Time of arrival")]
    //    public Nullable<System.TimeSpan> TimeofAdmission { get; set; }
    //    [Display(Name = "Day/ Date of Death")]
    //    public Nullable<System.DateTime> DateofDeath { get; set; }
    //    [Display(Name = "Time of death")]
    //    public Nullable<System.TimeSpan> TimeofDeath { get; set; }
    //    [Display(Name = "Consultant (on discharge)")]
    //    public string DischargeConsultantName { get; set; }
    //    public int SJRReviewSpecialityID { get; set; }
    //    public string Name { get; set; }
    //}


    public class clsClinicalCoding
    {
        public int ClinicalCodingID { get; set; }
        public Nullable<int> PatienitID { get; set; }
        public Nullable<int> SpellNumber { get; set; }
        public Nullable<int> FCENumber { get; set; }
        public Nullable<int> Position { get; set; }
        public string Diagnosiscode { get; set; }
        public string DiagnosisDescription { get; set; }
        public Nullable<int> ComorbidityFlag { get; set; }
        public string ProcedureCode { get; set; }
        public string ProcedureDescription { get; set; }
    }

    public enum Gender
    {
        Male,
        Female
    }
}