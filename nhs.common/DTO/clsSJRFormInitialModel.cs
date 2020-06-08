using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace NHS.Common
{
    public class clsSJRFormInitialModel
    {
        public clsCareRatingInitialManagementRating clsInitialManagementCareRating { get; set; }
        public clsCareRatingOnGoingCareRating clsOnGoingCareRating { get; set; }
        public clsCareRatingCareDuringProcedureCareRating clsCareDuringProcedureCareRating { get; set; }
        public clsCareRatingEndLifeCareRating clsEndLifeCareRating { get; set; }
        public clsCareRatingOverAllAssessmentCareRating clsOverAllAssessmentCareRating { get; set; }
        public clsQualityDocumentation clsQualityDocumentationCareRating { get; set; }

        public clsSJRFormInitial clsSjrFormInitial { get; set; }
    }
    public class clsCareRatingInitialManagementRating
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsCareRatingOnGoingCareRating
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsCareRatingCareDuringProcedureCareRating
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsCareRatingEndLifeCareRating
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsCareRatingOverAllAssessmentCareRating
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsQualityDocumentation
    {
        public int CareRatingID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsSJRFormInitial
    {
        public int SJRFormInitial_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }

        public string PatientID { get; set; }
        public string InitialManagement { get; set; }        
        public Nullable<int> InitialManagementCareRatingID { get; set; }
        public string OngoingCare { get; set; }
        public Nullable<int> OngoingCareRatingID { get; set; }
        public string CareDuringProcedure { get; set; }
        public Nullable<int> CareDuringProcedureCareRatingID { get; set; }
        public string EndLifeCare { get; set; }
        public Nullable<int> EndLifeCareRatingID { get; set; }
        public string OverAllAssessment { get; set; }
        public Nullable<int> OverAllAssessmentCareRatingID { get; set; }
        public Nullable<int> Stage { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public Nullable<int> QualityDocumentation { get; set; }

        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

        public int SJR1 { get; set; }

        public int SJR2 { get; set; }
    }
}