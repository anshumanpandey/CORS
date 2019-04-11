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
        public string Role { get; set; }

        public int ID { get; set; }
    }
}