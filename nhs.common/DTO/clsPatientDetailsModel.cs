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

    public class CareGroups
    {
        public string CareGroup { get; set; }
    }

    public class MENames
    {
        public string MEName { get; set; }
        public int ID { get; set; }

        public string MEUserName { get; set; }
    }

    public class SJRTracking
    {
        public int AdultDeathCount { get; set; }

        public int LearningDisabilityCount { get; set; }

        public decimal SJR1RequiredPercentage { get; set; }

        public int SJR1Required { get; set; }

        public int SJR1NotRequired { get; set; }

        public int SJR1Completed { get; set; }

        public int SJR1Outstanding { get; set; }

        public int SJROutcomeGrade0Count { get; set; }
        public int SJROutcomeGrade1Count { get; set; }

        public int SJROutcomeGrade2Count { get; set; }

        public int SJROutcomeGrade3Count { get; set; }

        public int SJRCareVeryPoorCount { get; set; }
        public int SJRCarePoorCount { get; set; }
        public int SJRCareAdequateCount { get; set; }
        public int SJRCareGoodCount { get; set; }

        public int SJRCareVeryGoodCount { get; set; }

        public int SJR2Required { get; set; }

        public int SJR2NotRequired { get; set; }

        public int SJR2Completed { get; set; }

        public int SJR2Outstanding { get; set; }

        public int SJR2OutcomeGrade0Count { get; set; }
        public int SJR2OutcomeGrade1Count { get; set; }

        public int SJR2OutcomeGrade2Count { get; set; }

        public int SJR2OutcomeGrade3Count { get; set; }

        public int SJR2CareVeryPoorCount { get; set; }
        public int SJR2CarePoorCount { get; set; }
        public int SJR2CareAdequateCount { get; set; }
        public int SJR2CareGoodCount { get; set; }

        public int SJR2CareVeryGoodCount { get; set; }
    }

    public class CodingIssueSummary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string IssueDate { get; set; }

        public string IssuedBy { get; set; }
    }

    public class DQIssueSummary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string IssueDate { get; set; }

        public string IssuedBy { get; set; }

        public string Comments { get; set; }
    }

    public class UrgentMESummary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string IssueDate { get; set; }

        public string IssuedBy { get; set; }

        public string Comments { get; set; }
    }

    public class FullSJR2Summary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string RequestedDate { get; set; }

        public string RequestedBy { get; set; }
    }

    public class FullSJRSummary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string RequestedDate { get; set; }

        public string RequestedBy { get; set; }

        public string ReviewSpeciality { get; set; }
    }

    public class OtherReferralSummary
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateOfDeath { get; set; }

        public string ReferralType { get; set; }

        public string ReferralDate { get; set; }

        public string ReferredBy { get; set; }

        public string ReferralReason { get; set; }
    }

    public class MROutcomeDashbaord
    {
        public int TotalDeaths { get; set; }

        public int AandEDeathCount { get; set; }

        public int AdultDeathCount { get; set; }

        public int QAPCompleted { get; set; }

        public int QAPOutstanding { get; set; }

        public int CareQualityCount { get; set; }

        public int RecommendReferralCoronerCount { get; set; }

        public int MEReviewCompleted { get; set; }

        public int MEReviewOutstanding { get; set; }

        public int ExpectedDeathCount { get; set; }

        public int UnexpectedDeathCount { get; set; }

        public int SuddenNotUnexpectedDeathCount { get; set; }

        public int IndividualEndOfLifeDeathCount { get; set; }

        public int MCCDIssuedCount { get; set; }

        public int CoronerReferralCount { get; set; }

        public int HospitalPortMortemCount { get; set; }

        public int SIRIScopingCount { get; set; }

        public int SafeGuardingCount { get; set; }

        public int LearningDisabilityCount { get; set; }

        public int ChildDeathCount { get; set; }

        public int WardTeamCount { get; set; }

        public int HeadComplianceCount { get; set; }

        public int PALSComplaintsCount { get; set; }

        public int OtherCount { get; set; }

        public int SJRRequired { get; set; }

        public int SJRNotRequired { get; set; }

        public decimal SJRequestedPercentage { get; set; }

        public int PaediatricPatientCount { get; set; }

        public int SJRLearningDisabilityCount { get; set; }

        public int MentalIllnessPatientCount { get; set; }

        public int ElectiveAdmissionCount { get; set; }

        public int NOKConcernsCount { get; set; }

        public int DeathChemoCount { get; set; }

        public int OtherConcernCount { get; set; }

        public int SJR1Completed { get; set; }

        public int SJR1Outstanding { get; set; }

        public int ProblemWithCareCount { get; set; }

        public int KeyLearningsCount { get; set; }

        public int ConsultantReviewGrade0Count { get; set; }

        public int ConsultantReviewGrade2Count { get; set; }

        public int ConsultantReviewGrade3Count { get; set; }

        public int MSGReviewGrade0Count { get; set; }

        public int MSGReviewGrade2Count { get; set; }

        public int MSGReviewGrade3Count { get; set; }

        public int SJR2Required { get; set; }

        public int SJR2Completed { get; set; }

        public int CoronerDecisionNoFurtherActionCount { get; set; }

        public int CorononerDecisionPostMortemCount { get; set; }

        public int CoronerDecisionForensicPMCount { get; set; }

        public int CoronerDecisionGPIssueCount { get; set; }

        public int CoronerDecisionInquestCount { get; set; }

        public int CoronerDecision100ACount { get; set; }

        public int AboveandBeyondCount { get; set; }

        public List<FeedbackType> FeedbackTypes { get; set; }
    }

    public class Wards
    {
        public int WardID { get; set; }

        public string WardCode { get; set; }

        public string WardName { get; set; }
    }

    public class NotificationSettings
    {
        public int ID { get; set; }
        public int NotificationID { get; set; }

        public string NotificationTrigger { get; set; }

        public int RoleID { get; set; }

        public string RoleName { get; set; }

        public string EmailTemplate { get; set; }
    }

    public class PatientNotification
    {
        public int PatientID { get; set; }

        public string NotificationTrigger { get; set; }
    }

    public class NotificationTriggers
    {
        public int ID { get; set; }

        public string NotificationTrigger { get; set; }
    }

    public class RolePermission
    {
        public int ID { get; set; }
        public int ModuleID { get; set; }

        public int RoleID { get; set; }

        public string ModuleName { get; set; }

        public string RoleName { get; set; }

        public bool IsFullAccess { get; set; }

        public bool IsReadOnly { get; set; }

        public bool NoAccess { get; set; }

        public int TotalRecords { get; set; }
    }

    public class Modules
    {
        public int ID { get; set; }

        public string ModuleName { get; set; }
    }

    public class NoKFeedback
    {
        public int ID { get; set; }

        public int Patient_ID { get; set; }

        public string PatientName { get; set; }

        public string DOB { get; set; }

        public string PatientID { get; set; }

        public bool NoKConcerns { get; set; }

        public string NokConcernComments { get; set; }

        public string InitialLetterDate { get; set; }

        public string SJRDueDate { get; set; }

        public string SJR1CompletedDate { get; set; }

        public string HoldingLetterDate { get; set; }

        public string HoldingLetterComments { get; set; }

        public bool SuboptimalCareIdentified { get; set; }

        public string FollowUpCallDate { get; set; }

        public string FollowUpLetterSent { get; set; }

        public string FollowLetterComments { get; set; }

        public string CreatedDate { get; set; }

        public string CreatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public bool NokCompleted { get; set; }
    }

    public class Consultant
    {
        public int ConsID { get; set; }

        public string GMCCode { get; set; }

        public string Consultant_Name { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string EmailID { get; set; }
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

        public string SpecialityCode { get; set; }

        public string CareGroup { get; set; }
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

    public class TestStatuses
    {
        public string TestStatus { get; set; }
    }

    public class TestResults
    {
        public string TestResult { get; set; }
    }

    public class TestOrderLocations
    {
        public string TestOrderLocation { get; set; }
    }

    public class LastLocations
    {
        public string LastLocation { get; set; }
    }

    public class AdmissionStatuses
    {
        public string AdmissionStatus { get; set; }
    }

    public class MortalityFilterDDM
    {
        public List<DischargeSpecialityNames> lstSpecialities { get; set; }

        public List<PatientTypes> lstPatientTypes { get; set; }

        public List<WardOfDeaths> lstWardOfDeaths { get; set; }

        public List<DischargeConsultants> lstDischargeConsultants { get; set; }        
    }

    public class PatientExtractFilterDDM
    {
        public List<CareGroups> lstCareGroups { get; set; }

        public List<DischargeSpecialityNames> lstSpecialities { get; set; }

        public List<PatientTypes> lstPatientTypes { get; set; }

        public List<WardOfDeaths> lstWardOfDeaths { get; set; }

        public List<DischargeConsultants> lstDischargeConsultants { get; set; }

        public List<MENames> lstMENames { get; set; }
    }

    public class COVIDFilterDDM
    {
        public List<Notifications> lstNotification { get; set; }

        public List<TestStatuses> lstTestStatus { get; set; }

        public List<TestResults> lstTestResult { get; set; }

        public List<TestOrderLocations> lstTestOrderLocation { get; set; }

        public List<LastLocations> lstLastLocation { get; set; }

        public List<AdmissionStatuses> lstAdmissionStatus { get; set; }

        public clsDataManagement datamanagement { get; set; }
    }

    public class AgeGroup
    {
        public string Age_Group { get; set; }
    }

    public class BreathingStatuses
    {
        public string BreathingStatus { get; set; }
    }

    public class COVIDPatientFilterDDM
    {
        public List<PatientTypes> lstPatientType { get; set; }

        public List<AgeGroup> lstAgeGroup { get; set; }

        public List<TestResults> lstTestResult { get; set; }

        public List<BreathingStatuses> lstBreathingStatuses { get; set; }

        public List<LastLocations> lstLastLocation { get; set; }

        public List<AdmissionStatuses> lstAdmissionStatus { get; set; }

        public clsDataManagement datamanagement { get; set; }
    }

    public class Notifications
    {
        public string Notification { get; set; }
    }

    public class AdmissionTypes
    {
        public string Admission_Method_Code { get; set; }
        public string Admission_Method { get; set; }
    }

    public class Roles
    {
        public int ID { get; set; }
        public string RoleName { get; set; }
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

        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }
        public string UserRole { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public int SpecialityID { get; set; }

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

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }

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

        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

        public string UserRole { get; set; }

        public int SpecialityID { get;set; }

        public string Period1a { get; set; }

        public string Value1a { get; set; }

        public string Period1b { get; set; }

        public string Value1b { get; set; }
        public string Period1c { get; set; }

        public string Value1c { get; set; }
        public string Period2 { get; set; }

        public string Value2 { get; set; }
    }

    public class PatientDetailView
    {
        public int ID { get; set; }

        public string SHMICode { get; set; }

        public string SHMIGroup { get; set; }
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
        public string DateofAdmission { get; set; }
        //[Display(Name = "Time of arrival")]
        public string TimeofAdmission { get; set; }
        //[Display(Name = "Ward (on discharge)")]
        public string DischargeWard { get; set; }
        public string DischargeWardID { get; set; }
        //[Display(Name = "Day/ Date of Death")]
        public string DateofDeath { get; set; }
        //[Display(Name = "Time of death")]
        public string TimeofDeath { get; set; }
        public string WardofDeath { get; set; }
        public string WardofDeathID { get; set; }
        public string DischargeConsultantCode { get; set; }
        public string DischargeConsutantName { get; set; }

        public string DischargeConsutantID { get; set; }
        public string DischargeSpecialtyCode { get; set; }
        public string DischargeSpeciality { get; set; }
        public string DischargeSpecialityID { get; set; }
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
        public int MEOReview { get; set; }
        public string Occupation { get; set; }

        public bool CodingIssue { get; set; }

        public string UserRole { get; set; }

        public string PatientType { get; set; }

        public string PatientTypeLongText { get; set; }

        public bool DataQualityIssuesIdentified { get; set; }

        public string DataQualityIssueComments { get; set; }

        public int QAPCount { get; set; }

        public int MedCount { get; set; }

        public int MEOCount { get; set; }
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

        public int CRCreatedBy { get; set; }

        public string CRCreatedDate { get; set; }

        public string CRCreatedByName { get; set; }

        public bool QAP_Discussion { get; set; }
        public bool Notes_Review { get; set; }
        public bool Nok_Discussion { get; set; }
        //[Display(Name = "Name of QAP")]
        public string QAPName { get; set; }

        public bool MCCDissue { get; set; }

        public bool CoronerReferral { get; set; }

        public string CoronerReferralReason { get; set; }

        public bool HospitalPostMortem { get; set; }

        public string CauseOfDeath1 { get; set; }

        public string CauseOfDeath2 { get; set; }

        public string CauseOfDeath3 { get; set; }

        public string CauseOfDeath4 { get; set; }

        public int CauseID { get; set; }

        public bool CornerReferralComplete { get; set; }

        public bool FullSJRRequired { get; set; }

        public string SpecialityName { get; set; }

        public bool PaediatricPatient { get; set; }

        public bool LearningDisabilityPatient { get; set; }

        public bool MentalillnessPatient { get; set; }

        public bool ElectiveAdmission { get; set; }

        public bool NoKConcernsDeath { get; set; }

        public bool DeathChemo { get; set; }

        public bool OtherConcern { get; set; }

        public string OtherSJRAssessementComments { get; set; }

        public bool PatientSafetySIRI { get; set; }

        public string PatientSafetySIRIReason { get; set; }

        public bool ChildDeathCoordinator { get; set; }

        public bool LearningDisabilityNurse { get; set; }

        public bool HeadOfCompliance { get; set; }

        public string HeadOfComplianceReason { get; set; }

        public bool PALsComplaints { get; set; }

        public bool PALsComplaintsReason { get; set; }

        public bool WardTeam { get; set; }

        public string WardTeamReason { get; set; }

        public bool SafeGuardTeamNotified { get; set; }

        public bool Other { get; set; }
        public string OtherReason { get; set; }

        public bool FormCompleted { get; set; }

        public bool ComplementsFedBack { get; set; }

        public string FeedbackCreatedBy { get; set; }

        public string FeedbackCreatedDate { get; set; }
    }

    public class SJR1Report
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DOB { get; set; }

        public string InitialManagement { get; set; }

        public string InitialManagementRating { get; set; }

        public string OngoingCare { get; set; }

        public string OngoingCareRating { get; set; }

        public string CareDuringProcedure { get; set; }

        public string CareDuringProcedureRating { get; set; }

        public string EndLifeCare { get; set; }

        public string EndLifeCareRating { get; set; }

        public string OverAllAssessment { get; set; }

        public string OverAllAssessmentRating { get; set; }

        public string QualityDocumentationRating { get; set; }

        public bool ProblemOccured { get; set; }

        public int AssessmentResponseID { get; set; }

        public int AssessmentCarePhaseID { get; set; }

        public int MedicationResponseID { get; set; }

        public int MedicationCarePhaseID { get; set; }

        public int TreatmentResponseID { get; set; }

        public int TreatmentCarePhaseID { get; set; }

        public int InfectionResponseID { get; set; }

        public int InfectionCarePhaseID { get; set; }

        public int ProcedureResponseID { get; set; }

        public int ProcedureCarePhaseID { get; set; }

        public int MonitoringResponseID { get; set; }

        public int ResuscitationResponseID { get; set; }

        public int OthertypeResponseID { get; set; }

        public int OthertypeCarePhaseID { get; set; }

        public int AvoidabilityScoreID { get; set; }

        public string LearningComments { get; set; }

        public string SpecialityName { get; set; }

        public string CreatedBy { get; set; }

        public string CreateDate { get; set; }
    }

    public class SJR2Report
    {
        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DOB { get; set; }

        public string InitialManagement { get; set; }

        public string InitialManagementRating { get; set; }

        public string OngoingCare { get; set; }

        public string OngoingCareRating { get; set; }

        public string CareDuringProcedure { get; set; }

        public string CareDuringProcedureRating { get; set; }

        public string EndLifeCare { get; set; }

        public string EndLifeCareRating { get; set; }

        public string OverAllAssessment { get; set; }

        public string OverAllAssessmentRating { get; set; }

        public string QualityDocumentationRating { get; set; }

        public bool ProblemOccured { get; set; }

        public int AssessmentResponseID { get; set; }

        public int AssessmentCarePhaseID { get; set; }

        public int MedicationResponseID { get; set; }

        public int MedicationCarePhaseID { get; set; }

        public int TreatmentResponseID { get; set; }

        public int TreatmentCarePhaseID { get; set; }

        public int InfectionResponseID { get; set; }

        public int InfectionCarePhaseID { get; set; }

        public int ProcedureResponseID { get; set; }

        public int ProcedureCarePhaseID { get; set; }

        public int MonitoringResponseID { get; set; }

        public int ResuscitationResponseID { get; set; }

        public int OthertypeResponseID { get; set; }

        public int OthertypeCarePhaseID { get; set; }

        public int AvoidabilityScoreID { get; set; }

        public string LearningComments { get; set; }

        public string SpecialityName { get; set; }

        public string CreatedBy { get; set; }

        public string CreateDate { get; set; }
    }

    public class clsPatientDetails
    {
        public int ID { get; set; }

        public string SHMICode { get; set; }

        public string SHMIGroup { get; set; }
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
        public string DateofAdmission { get; set; }
        //[Display(Name = "Time of arrival")]
        public string TimeofAdmission { get; set; }
        //[Display(Name = "Ward (on discharge)")]
        public string DischargeWard { get; set; }
        public string DischargeWardID { get; set; }
        //[Display(Name = "Day/ Date of Death")]
        public string DateofDeath { get; set; }
        //[Display(Name = "Time of death")]
        public string TimeofDeath { get; set; }
        public string WardofDeath { get; set; }
        public string WardofDeathID { get; set; }
        public string DischargeConsultantCode { get; set; }
        public string DischargeConsutantName { get; set; }

        public string DischargeConsutantID { get; set; }
        public string DischargeSpecialtyCode { get; set; }
        public string DischargeSpeciality { get; set; }
        public string DischargeSpecialityID { get; set; }
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
        public int MEOReview { get; set; }
        public string Occupation { get; set; }

        public bool CodingIssue { get; set; }

        public string UserRole { get; set; }

        public string PatientType { get; set; }

        public string PatientTypeLongText { get; set; }

        public bool DataQualityIssuesIdentified { get; set; }

        public string DataQualityIssueComments { get; set; }

        public int QAPCount { get; set; }

        public int MedCount { get; set; }

        public int MEOCount { get; set; }
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

        public int CRCreatedBy { get; set; }

        public string CRCreatedDate { get; set; }

        public string CRCreatedByName { get; set; }

        public int CauseID { get; set; }

        public bool MCCDIssue { get; set; }

        public bool CoronerReferral { get; set; }

        public bool HospitalPostMortem { get; set; }

        public bool IsEnabled { get; set; }

        public bool Concern { get; set; }

        public bool Referral { get; set; }

        public bool PatientSIRI { get; set; }

        public bool SafeGuard { get; set; }

        public bool LearningDisability { get; set; }

        public bool ChildDeath { get; set; }

        public bool WardTeam { get; set; }

        public bool HeadOfCompliance { get; set; }

        public bool PALsComplaints { get; set; }

        public bool Other { get; set; }

        public bool ProblemOccured { get; set; }

        public string KeyLearnings { get; set; }

        public int AvoidabilityScoreID { get; set; }
        public int MSGAvoidabilityScoreID { get; set; }

        public bool CoronerDecisionNFAction { get; set; }

        public bool CoronerDecisionPostMortem { get; set; }

        public bool CoronerDecisionForensicPM { get; set; }

        public bool CoronerDecisionGPIssue { get; set; }

        public bool CoronerDecisionInquest { get; set; }

        public bool CoronerDecision100A { get; set; }

        public int FeedbackTypeID { get; set; }

        public bool FormCompleted { get; set; }

        public bool LearningDisabilityPatient { get; set; }

        public bool PaediatricPatient { get; set; }

        public bool MentalillnessPatient { get; set; }

        public bool ElectiveAdmission { get; set; }

        public bool NoKConcernsDeath { get; set; }

        public bool DeathChemo { get; set; }

        public bool OtherConcern { get; set; }

        public int TotalRecords { get; set; }
    }

    public class CORSExtract
    {
        public int ID { get; set; }

        public string PatientID { get; set; }

        public string SpellNumber { get; set; }

        public string PatientName { get; set; }

        public string NHSNumber { get; set; }

        public string Gender { get; set; }

        public int Age { get; set; }

        public string DOB { get; set; }

        public string DateofAdmission { get; set; }

        public string TimeofAdmission { get; set; }

        public string DischargeWard { get; set; }

        public string DateofDeath { get; set; }

        public string Month { get; set; }

        public string QAPReview { get; set; }

        public string MedTriage { get; set; }

        public string MEOReview { get; set; }

        public string SJR1 { get; set; }

        public string SJR2 { get; set; }

        public string SJROutcome { get; set; }

        public string CodingReview { get; set; }

        public string TimeofDeath { get; set; }

        public string WardofDeath { get; set; }

        public string DischargeConsultantCode { get; set; }

        public string DischargeConsultantName { get; set; }

        public string DischargeSpecialityCode { get; set; }

        public string DischargeSpeciality { get; set; }

        public string CareGroup { get; set; }

        public string AdmissionType { get; set; }

        public int AgeAtDeath { get; set; }

        public string PatientTypeActual { get; set; }

        public string PatientType { get; set; }

        public string SHMIGroup { get; set; }

        public string QAP_Synopsis { get; set; }

        public string QAP_Care_Quality_Concern { get; set; }

        public string QAP_Reason1A { get; set; }

        public string QAP_Reason1B { get; set; }

        public string QAP_Reason1C { get; set; }

        public string QAP_Reason2 { get; set; }

        public string QAP_Interval1 { get; set; }

        public string QAP_Interval2 { get; set; }

        public string QAP_Interval3 { get; set; }

        public string QAP_Interval4 { get; set; }

        public int QAP_MCCD { get; set; }

        public int QAP_CoronerReferral_Reqd { get; set; }

        public string QAP_CoronorReferral_Reason { get; set; }

        public string QAP_FullName { get; set; }

        public string QAP_GMCNo { get; set; }

        public string QAP_Location { get; set; }

        public string QAP_Phone { get; set; }

        public string QAP_AlternatePhone { get; set; }

        public string QAP_CreatedBy { get; set; }

        public string QAP_CreatedDate { get; set; }

        public int QAP_ReviewCompleted { get; set; }

        public int QAP_TurnAround_Days { get; set; }

        public string CauseOfDeath1A { get; set; }

        public string CauseOfDeath1B { get; set; }

        public string CauseOfDeath1C { get; set; }

        public string CauseOfDeath2 { get; set; }

        public string CoronerReferral { get; set; }

        public string CoronerDecision { get; set; }

        public int MER_Declaration { get; set; }

        public string MER_Office { get; set; }

        public string MER_CreatedBy { get; set; }

        public string MER_CreatedDate { get; set; }

        public string DeathCertificateDate { get; set; }

        public int MER_TurnAround_Days { get; set; }

        public int PaediatricPatient { get; set; }

        public string LearningDisability { get; set; }

        public int LearningDisabilityPatient { get; set; }

        public int MentalillnessPatient { get; set; }

        public string SJR_RequestDate { get; set; }

        public string SJR_RequestedBy { get; set; }

        public string SJRReviewSpecialityID { get; set; }

        public string SJRReview_Specialty { get; set; }

        public string SJRReview_CareGroup { get; set; }

        public string SJR1_CompletdBy { get; set; }

        public string SJR1_CompletdDate { get; set; }

        public int SJR1_Request_Days { get; set; }

        public int SJR1_TurnAround_Days { get; set; }

        public string SJR2_RequestDate { get; set; }

        public string SJR2_RequestedBy { get; set; }

        public int MSGRequired { get; set; }

        public int AvoidabilityScoreID { get; set; }

        public string SIRI_ReferenceNo { get; set; }

        public string SJR1_AvoidabilityScoreID { get; set; }


        public string SJR1_OverallCareID { get; set; }

        public string SJR1_OverallCare { get; set; }

        public string SJR2_CompletdBy { get; set; }

        public string SJR2_CompletdDate { get; set; }

        public string SJR2_AvoidabilityScoreID { get; set; }

        public string SJR2_Outcome { get; set; }

        public string SJR2_OverallCareID { get; set; }

        public string SJR2_OverallCare { get; set; }

        public int ME_Death { get; set; }

        public int ME_QAPReview_Completed { get; set; }

        public int ME_QAPReview_Outstanding { get; set; }

        public int ME_Quality_Concern { get; set;  }

        public int ME_QAP_Ref_to_Coroner { get; set; }

        public int ME_MEReview_Completed { get; set; }

        public int ME_MEReview_OutStanding { get; set; }

        public int ME_MEO_ReviewCompleted { get; set; }

        public int ME_Expected { get; set; }

        public int ME_Sudden_But_Expected { get; set; }

        public int ME_UnExpected { get; set; }

        public int ME_Ind_End_LifeCare_Plan { get; set; }

        public int ME_Full_SJR_Required { get; set; }

        public int ME_Full_SJR_NotRequired { get; set; }

        public int ME_SJR1_Completed { get; set; }

        public int ME_SJR1_Outstanding { get; set; }

        public int ME_PaediatricPatient { get; set; }

        public int ME_LearningDisability_Death { get; set; }

        public int ME_MentalillnessPatient { get; set; }

        public int ME_ElectiveAdmission { get; set; }

        public int ME_NoKConcernsDeath { get; set; }

        public int ME_OtherConcern { get; set; }

        public int ME_Stage2SJR_Required { get; set; }

        public int ME_Stage2SJR_NotRequired { get; set; }

        public int ME_Stage2SJR_Completed { get; set; }

        public int ME_Stage2SJR_Outstanding { get; set; }

        public int ME_DQ_Issue_Identified { get; set; }

        public int ME_Issue_MCCD { get; set; }

        public int ME_CoronerReferral { get; set; }

        public int ME_Hosp_Post_Mortem { get; set; }

        public int ME_Coroner_Inquest { get; set; }

        public int ME_Coroner_100A { get; set; }

        public int ME_Coroner_PostMortem { get; set; }

        public int ME_Coroner_GPIssue { get; set; }

        public int ME_Coroner_NFAction { get; set; }

        public int ME_Coroner_ForensicPM { get; set; }

        public int ME_REF_PatientSafety_SIRI { get; set; }

        public int ME_REF_ChildDeathCoordinator { get; set; }

        public int ME_REF_LearningDisabilityNurse { get; set; }

        public int ME_REF_HeadOfCompliance { get; set; }

        public int ME_PALsComplaints { get; set; }

        public int ME_REF_WardTeam { get; set; }

        public int ME_SafeGuardTeam_Notified { get; set; }

        public int ME_REF_Other { get; set; }

        public int ME_FormCompleted { get; set; }

        public int ME_Positive_Feedback { get; set; }

        public int ME_AvoidableScore_01 { get; set; }

        public int ME_AvoidableScore_2 { get; set; }

        public int ME_AvoidableScore_3 { get; set; }

        public int ME_Death_Reported_SIRI { get; set; }

        public int ME_Cons_AvoidableScore_01 { get; set; }

        public int ME_Cons_AvoidableScore_2 { get; set; }

        public int ME_Cons_AvoidableScore_3 { get; set; }

        public int ME_SJR1_Problem_with_Care { get; set; }

        public int ME_SJR1_Key_Learnings { get; set; }
    }

    public class WebsiteSetting
    {
        public string EmailID { get; set; }

        public string Password { get; set; }

        public string DomainName { get; set; }

        public string SMTPServer { get; set; }

        public int Port { get; set; }
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