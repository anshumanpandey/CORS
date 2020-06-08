using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace NHS.Common
{
    public class clsSJRReviewModel
    {
        public clsSJRReviewSpeciality objclsSJRReviewSpeciality { get; set; }
        public clsSJRReview objclsSJRReview { get; set; }
    }

    public class clsSJRReviewSpeciality
    {
        public int SJRReviewSpecialityID { get; set; }
        //[Display(Name = "Specialty to complete SJR Review")]
        public string Name { get; set; }       
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

    }
    public class clsSJRReview
    {
        public int SJRReview_ID { get; set; }
        public int Patient_ID { get; set; }
        public string PatientID { get; set; }
        public bool PaediatricPatient { get; set; }
        public bool LearningDisabilityPatient { get; set; }
        public bool MentalillnessPatient { get; set; }
        public bool ElectiveAdmission { get; set; }
        public bool NoKConcernsDeath { get; set; }
        public bool OtherConcern { get; set; }
        public string OtherConcernDetails { get; set; }
        public bool FullSJRRequired { get; set; }
        public Nullable<int> SpecialityID { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string Comments { get; set; }
        public int MedTriage { get; set; }

        public string DOB { get; set; }
        public string PatientName { get; set; }
        public bool IsFormStarted { get; set; }

        public bool DeathChemo { get; set; }
    }
}