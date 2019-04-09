using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NHS.Common
{
    public class clsCodingReviewModel
    {

    }

    public class clsCodingReview
    {
        public int? PatientId { get; set; }
        public Nullable<int> METriage { get; set; }
        public Nullable<int> SJR1 { get; set; }
        public Nullable<int> SJR2 { get; set; }
        public Nullable<int> SJRoutcome { get; set; }
        //public string PName { get; set; }
        //public string PDOB { get; set; }
        public string PatientName { get; set; }
        public DateTime DOB { get; set; }
        public Nullable<bool> FullSJRRequired { get; set; }
    }
}