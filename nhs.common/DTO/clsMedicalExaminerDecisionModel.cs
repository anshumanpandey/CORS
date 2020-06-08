using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace NHS.Common
{
    public class clsMedicalExaminerDecisionModel
    {
        public clsCoronerReferralReason objclsCoronerReferralReason { get; set; }
        public clsMedicalExaminerDecision objclsMedicalExaminerDecision { get; set; }
    }

    public class clsCoronerReferralReason
    {
        public int Reason_ID { get; set; }
        //[Display(Name = "Reason for coroner referral")]
        public string ReasonName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
    public class clsMedicalExaminerDecision
    {
        public int MED_ID { get; set; }
        public int ID { get; set; }
        public string PatientID { get; set; }
        public bool MCCDissue { get; set; }
        public bool CoronerReferral { get; set; }
        public bool HospitalPostMortem { get; set; }
        public int ReasonGroupID { get; set; }
        public Nullable<int> CoronerReferralReasonID { get; set; }
        //[Display(Name = "Cause of Death")]
        public string CauseOfDeath1 { get; set; }
        public string CauseOfDeath2 { get; set; }
        public string CauseOfDeath3 { get; set; }
        public string CauseOfDeath4 { get; set; }
        public string CauseOfDeath1Final { get; set; }
        public string CauseOfDeath2Final { get; set; }
        public string CauseOfDeath3Final { get; set; }
        public string CauseOfDeath4Final { get; set; }

        public bool DeathCertificate { get; set; }
        public bool CornerReferralComplete { get; set; }

        public string DeathCertificateDate { get; set; }

        public string DeathCertificateTime { get; set; }

        public string TimeType { get; set; }

        public bool CoronerDecisionInquest { get; set; }
        public bool CoronerDecision100A { get; set; }
        public bool CoronerDecisionPostMortem { get; set; }
        public bool CoronerDecisionForensicPM { get; set; }
        public bool CoronerDecisionGPissue { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string a {get; set;}
        public string b { get; set; }
        public string c { get; set; }

        public string d { get; set; }
        public string CoronerReferralReason { get; set; }
        public int CauseID { get; set; }

        public int MedTriage { get; set; }
        public bool NoFurtherAction { get; set; }


        public string Patient_Id { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

        public string UserRole { get; set; }

        public bool MEOReviewCompleted { get; set; }

        public string MEOReviewCreatedBy { get; set; }

        public string MEOReviewCreatedDate { get; set; }

        public int MEOSpecialityID { get; set; }

        public bool IsCremated { get; set; }

        public bool IsBuried { get; set; }

        public bool IsBypassedMESystem { get; set; }

        public int FuneralArrangement { get; set; }
    }
    public class ReasonGroups
    {
        public int GroupID { get; set; }
        public string GroupName { get; set; }
    }
}