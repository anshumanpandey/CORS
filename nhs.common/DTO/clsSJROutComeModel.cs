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

    public class clsSurgery
    {
        public int ID { get; set; }

        public bool NotRequired { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }
    
        public int Patient_ID { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public int MRN { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }
        public string NHSNumber { get; set; }

        public bool SurgeryCompleted { get; set; }

        public bool Discharged { get; set; }

        public string DischargeComments { get; set; }

        public string DischargedDate { get; set; }

        public string DischargedBy { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsPostOpDietician
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public bool Discharged { get; set; }

        public bool NotRequired { get; set; }

        public string DischargeComments { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public int Patient_ID { get; set; }
        public string NHSNumber { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public int MRN { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }


        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsPostOpMedical
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public bool Discharged { get; set; }

        public bool NotRequired { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public string DischargeComments { get; set; }

        public int Patient_ID { get; set; }
        public string NHSNumber { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public int MRN { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public bool Discharge { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsSurgicalMDT
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public bool Discharged { get; set; }

        public bool NotRequired { get; set; }

        public string DischargeComments { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public int Patient_ID { get; set; }
        public string NHSNumber { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public int MRN { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public bool BookSurgery { get; set; }

        public bool FurtherSupport { get; set; }

        public bool Discharge { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsVirtualMDT
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }
        public string NHSNumber { get; set; }

        public int PathwayEventID { get; set; }

        public bool Discharged { get; set; }

        public bool NotRequired { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public int Patient_ID { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public int MRN { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public bool SurgicalMDT { get; set; }

        public bool FutureReview { get; set; }

        public bool FutureMedicalReview { get; set; }

        public bool RebookVMMDT { get; set; }

        public string DischargeComments { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsNurseAssessment
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public string NHSNumber { get; set; }

        public bool NotRequired { get; set; }

        public bool Discharged { get; set; }

        public string DischargedDate { get; set; }

        public string DischargedBy { get; set; }

        public string DischargeComments { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public string ClinicName { get; set; }

        public bool AgreementReceived { get; set; }

        public int Patient_ID { get; set; }

        public int MRN { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsMedicalMDT
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public string NHSNumber { get; set; }

        public bool Discharged { get; set; }

        public string DischargeComments { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public bool NotRequired { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public string ClinicName { get; set; }

        public bool PsychologyRefSent { get; set; }

        public bool PsychologyAssessmentReceived { get; set; }

        public string PsychologyComments { get; set; }

        public bool MedicalFollowUp { get; set; }

        public bool ReferToGroupSession { get; set; }

        public string MedicalFollowComments { get; set; }

        public int Patient_ID { get; set; }

        public int MRN { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsPsychologyAssess
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public string NHSNumber { get; set; }

        public bool Discharged { get; set; }

        public string DischargeComments { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public bool NotRequired { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public int Patient_ID { get; set; }

        public int MRN { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsGroupSessions
    {
        public int ID { get; set; }

        public int ActivityStatusID { get; set; }

        public int PathwayEventID { get; set; }

        public string NHSNumber { get; set; }

        public bool Discharged { get; set; }

        public string DischargeComments { get; set; }

        public bool NotRequired { get; set; }

        public string DischargedBy { get; set; }

        public string DischargedDate { get; set; }

        public string PatientName { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string Comments { get; set; }

        public string ClinicName { get; set; }

        public string Group1Comments { get; set; }

        public string Group2Comments { get; set; }

        public string Group3Comments { get; set; }

        public string Group4Comments { get; set; }

        public bool RepeatSession { get; set; }

        public string RepeatSessionName { get; set; }

        public bool VirtualMDTReferral { get; set; }

        public bool IndividualFollowup { get; set; }

        public bool ReferToGroupSession { get; set; }

        public int Patient_ID { get; set; }

        public int MRN { get; set; }

        public List<clsAppointments> PastAppointments { get; set; }
    }

    public class clsAppointments
    {
        public string AppointmentDate { get; set; }

        public string Outcome { get; set; }
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

        public string ComplaintReferenceNumber { get; set; }

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