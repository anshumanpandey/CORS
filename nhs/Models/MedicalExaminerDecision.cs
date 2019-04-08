//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NHS.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class MedicalExaminerDecision
    {
        public int MED_ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<bool> MCCDissue { get; set; }
        public Nullable<bool> CornerReferral { get; set; }
        public Nullable<bool> HospitalPostMortem { get; set; }
        public Nullable<int> CoronerReferralReasonID { get; set; }
        public string CauseOfDeath1 { get; set; }
        public string CauseOfDeath2 { get; set; }
        public string CauseOfDeath3 { get; set; }
        public string CauseOfDeath4 { get; set; }
        public Nullable<bool> DeathCertificate { get; set; }
        public Nullable<bool> CornerReferralComplete { get; set; }
        public Nullable<bool> CoronerDecisionInquest { get; set; }
        public Nullable<bool> CoronerDecision100A { get; set; }
        public Nullable<bool> CoronerDecisionPostMortem { get; set; }
        public Nullable<bool> CoronerDecisionGPissue { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    
        public virtual CoronerReferralReason CoronerReferralReason { get; set; }
        public virtual PatientDetails PatientDetails { get; set; }
    }
}
