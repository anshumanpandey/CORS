using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;

namespace NHS.Common
{
    public class clsOtherReferralModel
    {
        public int OtherReferral_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public string PatientID { get; set; }
        public bool PatientSafetySIRI { get; set; }
        public string PatientSafetySIRIReason { get; set; }
        public bool ChildDeathCoordinator { get; set; }
        public bool LearningDisabilityNurse { get; set; }
        public bool HeadOfCompliance { get; set; }
        public string HeadOfComplianceReason { get; set; }
        public bool PALsComplaints { get; set; }
        public string PALsComplaintsReason { get; set; }
        public bool WardTeam { get; set; }
        public string WardTeamReason { get; set; }
        public bool Other { get; set; }
        public string OtherReason { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public bool SafeGuardTeamNotified { get; set; }

        public int MedTriage { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }
    }
}