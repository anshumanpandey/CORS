using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHS.Common
{
    public class clsSJROutcomesModel
    {
        public int SJROutcome_ID { get; set; }
        public Nullable<int> PatientID { get; set; }
        public Nullable<bool> Stage2SJRRequired { get; set; }
        public string Stage2SJRDateSent { get; set; }
        public string Stage2SJRSentTo { get; set; }
        public string ReferenceNumber { get; set; }
        public Nullable<System.DateTime> DateReceived { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }
}