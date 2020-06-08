using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NHS.Common
{
    public class clsClinicalCodingModel
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
    
    public class AppUsers
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public bool IsFound { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public int ID { get; set; }

        public string Role { get; set; }

        public int RoleID { get; set; }

        public string EmailID { get; set; }

        public string Code { get; set; }

        public string Speciality { get; set; }

        public bool IsApproved { get; set; }

        public DateTime CreatedDate { get; set; }
    }

    public class CORSUsers
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string UserName { get; set; }

        public string LastLoginDateTime { get; set; }

        public int ID { get; set; }

        public string Role { get; set; }

        public string EmailID { get; set; }

        public string Code { get; set; }

        public string Speciality { get; set; }

        public bool IsApproved { get; set; }

        public string CreatedDate { get; set; }

        public string Action { get; set; }

        public int TotalRecords { get; set; }
    }
}