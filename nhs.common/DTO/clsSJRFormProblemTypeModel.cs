using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHS.Common
{
    public class clsSJRFormProblemTypeModel
    {
        public clsCarePhase objclsCarePhase { get; set; }
        public clsAvoidabilityScore objclsAvoidabilityScore { get; set; }
        public clsResponsePT objclsResponsePT { get; set; }
        public clsSJRFormProblemType objclsSJRFormProblemType { get; set; }
    }

    public class clsCarePhase
    {
        public int CarePhaseID { get; set; }
        public string PhaseName { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
    public class clsAvoidabilityScore
    {
        public int AvoidabilityScoreID { get; set; }
        public string Name { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsResponsePT
    {
        public int ResponseID { get; set; }
        public string Response { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsSJRFormProblemType
    {
        public int SJRFormProblemType_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }

        public string PatientID { get; set; }
        public Nullable<int> AssessmentResponseID { get; set; }
        public Nullable<int> AssessmentCarePhaseID { get; set; }
        public Nullable<int> MedicationResponseID { get; set; }
        public Nullable<int> MedicationCarePhaseID { get; set; }
        public Nullable<int> TreatmentResponseID { get; set; }
        public Nullable<int> TreatmentCarePhaseID { get; set; }
        public Nullable<int> InfectionResponseID { get; set; }
        public Nullable<int> InfectionCarePhaseID { get; set; }
        public Nullable<int> ProcedureResponseID { get; set; }
        public Nullable<int> ProcedureCarePhaseID { get; set; }
        public Nullable<int> MonitoringResponseID { get; set; }
        public Nullable<int> ResuscitationResponseID { get; set; }
        public Nullable<int> OthertypeResponseID { get; set; }
        public Nullable<int> OthertypeCarePhaseID { get; set; }
        public Nullable<int> AvoidabilityScoreID { get; set; }
        public string Comments { get; set; }
        public Nullable<int> Stage { get; set; }
        public string CreatedBy { get; set; }
        public string CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public string UpdatedDate { get; set; }

        public bool ProblemOccured { get; set; }
        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

        public int SJR1 { get; set; }
        public int SJR2 { get; set; }

        public bool ReviewCompleted { get; set; }

        public int SpecialityID { get; set; }
    }
}