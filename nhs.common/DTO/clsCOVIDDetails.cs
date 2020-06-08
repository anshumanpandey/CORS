using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS.Common.DTO
{
    public class clsCOVIDDetails
    {
        public int ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string SpellNumber { get; set; }

        public string NHSNumber { get; set; }

        public string Gender { get; set; }

        public string Age { get; set; }

        public string DOB { get; set; }

        public string PatientType { get; set; }

        public string AdmissionStatus { get; set; }

        public string AdmissionDateTime { get; set; }

        public string DischargeDateTime { get; set; }

        public string DischargeMethodCode { get; set; }

        public string DischargeMethod { get; set; }

        public string OrderDateTime { get; set; }

        public string OrderedBy { get; set; }

        public int NumberOfTests { get; set; }

        public string TestStatus { get; set; }

        public string TestResult { get; set; }

        public int TestDuration { get; set; }

        public string BreathingStatus { get; set; }

        public string BreathingStatusFullText { get; set; }

        public string TestOrderLocation { get; set; }

        public string LastPatientLocation { get; set; }

        public string BedType { get; set; }

        public string BedTypeFullText { get; set; }

        public string DQ { get; set; }

        public string DateofDeath { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string AdmittingWard { get; set; }

        public string DischargeWard { get; set; }

        public string CareGroup { get; set; }

        public int ComorbitiesCount { get; set; }

        public string DAComments { get; set; }

        public bool IsDisabled { get; set; }

        public string LastUpdatedBreathingDate { get; set; }

        public string LastUpdatedBreathingBy { get; set; }

        public string LastUpdatedBedTypeDate { get; set; }

        public string LastUpdatedBedTypeBy { get; set; }

        public int BedTypeUpdated { get; set; }

        public int BreathingStatusUpdated { get; set; }

        public int TotalTestsOrdered { get; set; }

        public int PositiveTestCases { get; set; }

        public int NegativeTestCases { get; set; }

        public int PendingTestCases { get; set; }

        public int PendingTestsOver2days { get; set; }

        public int AdmissionCount { get; set; }

        public int DeathCount { get; set; }

        public int NotNotifiedPositiveCount { get; set; }

        public int NotNotifiedNegativeCount { get; set; }

        public int NotNotifiedPendingCount { get; set; }

        public int NotNotifiedAdmissionCount { get; set; }

        public int NotNotifiedDeathCount { get; set; }

        public int TotalTestsOrderedLast24hrs { get; set; }

        public int PostivePatientDiagnosisLast24hrs { get; set; }

        public int PositiveInpatientDiagnosisLast24hrs { get; set; }

        public int NegativeLast24hours { get; set; }

        public int DeathsLast24hrs { get; set; }

        public int DischargesLast24hrs { get; set; }

        public int NotNotifiedPostivePatientDiagnosisLast24hrs { get; set; }

        public int NotNotifiedInPatientDiagnosisLast24hrs { get; set; }

        public int NotNotifiedNegativeLast24hours { get; set; }

        public int NotNotifiedDeathLast24hours { get; set; }

        public int NotNotifiedDischargesLast24hours { get; set; }

        public bool IsPositiveWardContacted { get; set; }
        public bool IsPositivePatientContacted { get; set; }

        public bool IsNegativeLetterSent { get; set; }

        public int Notified { get; set; }

        public int TotalRecords { get; set; }
        public string TestResultDateTime { get; set; }
    }

    public class BreathingSupportTracker
    {
        public int TotalRecords { get; set; }
        public string LastPatientLocation { get; set; }

        public int TotalCurrentIPCount { get; set; }

        public int TotalNotUpdatedLast20HoursCount { get; set; }

        public int TotalNotUpdatedLast12HoursCount { get; set; }

        public int TotalUpdatedLast12Hours { get; set; }

        public int Oxygen { get; set; }

        public int NoOxygen { get; set; }

        public int NonInvasiveVentilation { get; set; }

        public int MechanicalVentilation { get; set; }

        public int NotUpdatedAtAll { get; set; }

        public int CurrentIPCount { get; set; }

        public int NotUpdatedLast20HoursCount { get; set; }

        public int NotUpdatedLast12HoursCount { get; set; }

        public int UpdatedLast12HoursCount { get; set; }
    }

    public class BreathingSupportReport
    {
        public int TotalCurrentIP { get; set; }

        public decimal NotUpdatedLast20HoursPercentage { get; set; }

        public decimal NotUpdatedLast12HoursPercentage { get; set; }

        public decimal UpdatedLast12HoursPercentage { get; set; }

        public decimal TotalIsOxygenPercentage { get; set; }

        public decimal TotalIsNoOxygenPercentage { get; set; }

        public decimal TotalIsNonEvasiveVentilationPercentage { get; set; }

        public decimal TotalIsMechanicalVentilationPercentage { get; set; }

        public decimal TotalBreathingNotUpdatedPercentage { get; set; }

        public List<BreathingSupportTracker> BreathingTracker { get; set; }
    }

    public class clsCOVIDPatientList
    {
        public int Test_ID { get; set; }

        public int TotalRecords { get; set; }

        public int Age { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string NHSNumber { get; set; }

        public string Gender { get; set; }

        public string TestResultDateTime { get; set; }

        public string TestResult { get; set; }

        public int ComorbitiesCount { get; set; }

        public string AdmissionStatus { get; set; }

        public int LOSDays { get; set; }

        public string AdmissionDateTime { get; set; }

        public string BedNumber { get; set; }

        public string DischargeDateTime { get; set; }

        public string DateofDeath { get; set; }

        public string LastPatientLocation { get; set; }

        public string DischargeConsultantName { get; set; }

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }
    }

    public class clsCOVIDPatientDetails
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string TestID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public int BedTypeUpdated { get; set; }

        public int BreathingStatusUpdated { get; set; }

        public string SpellNumber { get; set; }

        public string NHSNumber { get; set; }

        public string Gender { get; set; }

        public string LastUpdatedBreathingDate { get; set; }

        public string LastUpdatedBreathingBy { get; set; }

        public string LastUpdatedBedTypeDate { get; set; }

        public string LastUpdatedBedTypeBy { get; set; }

        public string Age { get; set; }

        public string DOB { get; set; }

        public string PatientType { get; set; }

        public string AdmissionStatus { get; set; }

        public string AdmissionDateTime { get; set; }

        public string DischargeDateTime { get; set; }

        public string DischargeMethodCode { get; set; }

        public string DischargeMethod { get; set; }

        public string OrderDateTime { get; set; }

        public string OrderedBy { get; set; }

        public int NumberOfTests { get; set; }

        public string TestStatus { get; set; }

        public string TestResult { get; set; }

        public int TestDuration { get; set; }

        public string BreathingStatus { get; set; }

        public string BreathingStatusFullText { get; set; }

        public string TestOrderLocation { get; set; }

        public string LastPatientLocation { get; set; }

        public string BedType { get; set; }

        public string BedTypeFullText { get; set; }

        public string DateofDeath { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string AdmittingWard { get; set; }

        public string DischargeWard { get; set; }

        public string CareGroup { get; set; }

        public int ComorbitiesCount { get; set; }

        public bool IsDisabled { get; set; }

        public int TotalTestsOrdered { get; set; }

        public int TotalTestsOrderedInPatient { get; set; }

        public int PositiveTestCases { get; set; }

        public decimal PositiveRatePercentage { get; set; }

        public int PositiveTestCasesICU { get; set; }

        public decimal PositiveICURatePercentage { get; set; }

        public int NegativeTestCases { get; set; }

        public decimal NegativeRatePercentage { get; set; }

        public int PositiveDischarges { get; set; }

        public int PositiveDeaths { get; set; }

        public int PositiveInPatient { get; set; }

        public int PendingInPatient { get; set; }

        public int PositiveInPatientICU { get; set;}

        public int PendingICUInPatient { get; set; }

        public int PositiveInPatientLast24hours { get; set; }

        public int NegativeInPatientLast24hours { get; set; }

        public int PositiveDischargeCountLast24hours { get; set; }

        public int PositiveDeathCountLast24hours { get; set; }

        public int LOSDays { get; set; }

        public string Discharge_Destination_Code { get; set; }

        public string Discharge_Destination { get; set; }

        public string Age_Group { get; set; }

        public int RNK { get; set; }

        public int ME_Test { get; set; }

        public int ME_Orderd_Yest { get; set; }

        public int ME_TestComplted { get; set; }

        public int ME_Positive { get; set; }

        public int ReadmissionFlag { get; set; }

        public string DischargeConsultantCode { get; set; }

        public string DischargeConsultantName { get; set; }

        public int InICU { get; set; }

        public string BedNumber { get; set; }

        public int TotalRecords { get; set; }
        public string TestResultDateTime { get; set; }

        public int NoOfAdmissions { get; set; }
    }

    public class COVIDDefaultDate
    {
        public string StartDate { get; set; }

        public string EndDate { get; set; }
    }

    public class COVIDExternalCommsComplexDTO
    {
        public string PatientID { get; set; }

        public COVIDCHESSComms CovidChessComms { get; set; }

        public COVIDLevelOfCareComms CovidChessLOCComms { get; set; }

        public List<COVIDLOCCommsAuditTrail> CovidLOCCommsAuditTrail { get; set; }

        public COVIDDischargeDeathComms CovidDischargeDeathComms { get; set; }

        public COVIDCPNSComms CovidCpnsComms { get; set; }
    }

    public class COVIDReviewCycle
    {
        public int ID { get; set; }
        public int Test_ID { get; set; }

        public int DQ { get; set; }

        public int Notified { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string TestResult { get; set; }

        public string SpellNumber { get; set; }

        public bool IsTestResultsCompleted { get; set; }

        public int LevelCareUpdated { get; set; }

        public int BreathingUpdated { get; set; }

        public bool IsDataAssuranceCompleted { get; set; }

        public bool IsCommsCompleted { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDComms
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }
        public string SpellNumber { get; set; }

        public string TestResult { get; set; }

        public bool IsNone { get; set; }

        public bool IsPositiveWardContacted { get; set; }

        public bool IsPositivePatientContacted { get; set; }

        public bool IsNegativeLetterSent { get; set; }

        public string Comments { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDCPNSComms
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string DateofDeath { get; set; }
        public string SpellNumber { get; set; }

        public string AdmissionStatus { get; set; }

        public string TestResult { get; set; }

        public bool IsCPNSContacted { get; set; }

        public string CPNSComments { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public int ME_COVID_DEATH { get; set; }
    }

    public class COVIDLOCCommsAuditTrail
    {
        public string LevelOfCareUpdated { get; set; }

        public string LOCComments { get; set; }
        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }
    }

    public class COVIDExternalCommsReport
    {
        public string BacklogDate { get; set; }
        
        public string LiveDate { get; set; } 
        public int CHESSNewPositiveYTD { get; set; }

        public int CHESSNewPositiveYTDPending { get; set; }

        public int CHESSICUHDUStepUpYTD { get; set; }

        public int CHESSICUHDUStepUpYTDPending { get; set; }

        public int CHESSICUHDUStepDownYTD { get; set; }

        public int CHESSICUHDUStepDownYTDPending { get; set; }

        public int CHESSDischargeDeathYTD { get; set; }

        public int CHESSDischargeDeathYTDPending { get; set; }

        public int CHESSDischargesYTD { get; set; }

        public int CHESSDischargesYTDPending { get; set; }

        public int CHESSPositiveDeathsYTD { get; set; }

        public int CHESSPositiveDeathsYTDPending { get; set; }

        public int CPNSDeathYTD { get; set; }

        public int CPNSDeathYTDPending { get; set; }

        public int CPNSDeathDetected { get; set; }

        public int CPNSDeathDetectedPending { get; set; }

        public int CPNSDeathDiagnosed { get; set; }

        public int CPNSDeathDiagnosedPending { get; set; }

        public int CPNSDeathReAdmission { get; set; }

        public int CPNSDeathReAdmissionPending { get; set; }
    }

    public class COVIDDischargeDeathComms
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }
        public string DateofDeath { get; set; }
        public string SpellNumber { get; set; }

        public string AdmissionStatus { get; set; }

        public string TestResult { get; set; }

        public bool IsDichargeDeathContacted { get; set; }

        public string DischargeDeathComments { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDLevelOfCareComms
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }
        public string DateofDeath { get; set; }
        public string SpellNumber { get; set; }

        public string AdmissionStatus { get; set; }

        public string TestResult { get; set; }

        public bool IsLevelOfCareUpdated { get; set; }

        public string LOCComments { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDCHESSComms
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }
        public string DateofDeath { get; set; }

        public string PatientName { get; set; }
        public string SpellNumber { get; set; }

        public string AdmissionStatus { get; set; }

        public string TestResult { get; set; }

        public bool IsCHESSContacted { get; set; }

        public string CHESSComments { get; set; }

        public string UpdatedDate { get; set; }

        public string UpdatedBy { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDLevelOfCare
    {
        public int ID { get; set; }

        public string TestResult { get;set;}

        public int Test_ID { get; set; }

        public string SpellNumber { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public bool ITULevel1 { get; set; }

        public bool ITULevel2 { get; set; }

        public bool ITULevel3 { get; set; }

        public bool InfectionDiseaseUnitBed { get; set; }

        public bool OtherBeds { get; set; }

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDTestHistory
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string Clinical_Display_Line { get; set; }

        public string SpellNumber { get; set; }

        public string Encounter_Type_Des { get; set; }

        public int DQ { get; set; }

        public int Notified { get; set; }

        public string COVID_Diagnosis { get; set; }

        public string COVID_Problem { get; set; }

        public string OrderDateTime { get; set; }

        public string TestStatus { get; set; }

        public string TestResult { get; set; }

        public string TestResultDateTime { get; set; }

        public int TestDuration { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public bool IsDisabled { get; set; }
    }

    public class COVIDTestResults
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string SpellNumber { get; set; }

        public string TestResult { get; set; }

        public bool COVIDStatusKnown { get; set; }

        public string OrderDateTime { get; set; }

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }

        public string Comments { get; set; }
    }

    public class COVIDTestResultsComplexDTO
    {
        public List<COVIDTestHistory> LstTestHistory { get; set; }

        public COVIDTestResults TestResults { get; set; }
    }

    public class COVIDBreathingSupport
    {
        public int ID { get; set; }

        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string SpellNumber { get; set; }

        public string TestResult { get; set; }

        public bool IsOxygen { get; set; }

        public bool IsNoOxygen { get; set; }

        public bool IsNonEvasiveVentilation { get; set; }

        public bool IsMechanicalVentilation { get; set; }

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }

    public class COVIDDataAssurance
    {
        public int Test_ID { get; set; }

        public string PatientID { get; set; }

        public string PatientName { get; set; }

        public string TestResult { get; set; }

        public string SpellNumber { get; set; }

        public bool IsDisabled { get; set; }

        public string DAComments { get; set; }

        public string UpdatedBy { get; set; }

        public string UpdatedDate { get; set; }

        public string Age { get; set; }

        public string Gender { get; set; }
    }
}
