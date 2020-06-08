using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHS.Common
{
    public class clsSJROutComeModel
    {
        public clsSJROutcome clsSjrOutCome { get; set; }
        public clsMortalitySurveillance clsMortalitySurveillance { get; set; }
    }

    public class clsSJROutcome
    {
        public int SJROutcome_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public string PatientID { get; set; }
        public bool Stage2SJRRequired { get; set; }
        public string Stage2SJRDateSent { get; set; }
        public int AvoidabilityScoreID { get; set; }
        public bool MSGRequired { get; set; }

        public string MSGDiscussionDate { get; set; }
        public string Stage2SJRSentTo { get; set; }
        public string ReferenceNumber { get; set; }

        public string FeedbackToNoK { get; set; }
        public string DateReceived { get; set; }
        public string Comments { get; set; }
        public string SIRIComments { get; set; }
        public string CreatedBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

        public int SJROutcome { get; set; }

        public int SpecialityID { get; set; }

        public bool ReviewCompleted { get; set; }

        public string DateSJR1Requested { get; set; }

        public string SJR1RequestSentTo { get; set; }

        public bool RandomSampleReview { get; set; }
    }

    public class clsMortalitySurveillance
    {
        public int MortalitySurveillance_ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public bool PresentationToMSG { get; set; }
        public string DiscussedWithMSG { get; set; }
        public Nullable<int> AvoidabilityScoreID { get; set; }
        public string Comments { get; set; }
        public string FeedbackToNoK { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}