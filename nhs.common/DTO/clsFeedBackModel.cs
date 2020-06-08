using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace NHS.Common
{
    public class clsFeedBackModel
    {
        public clsFeedBackModel()
        {
            lstFBComments = new List<FeedBackComments>();
        }
        public int FeedBack_ID { get; set; }
        public Nullable<int> Patient_ID { get; set; }
        public string PatientID { get; set; }
        //[Display(Name = "Above & Beyond form completed")]
        public bool FormCompleted { get; set; }
        //[Display(Name = "Compliments fed back to clinical team")]
        public bool ComplementsFedBack { get; set; }
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }

        public string Comments { get; set; }

        public int MedTriage { get; set; }
        public List<FeedBackComments> lstFBComments { get; set; }

        
        public string DOB { get; set; }
        public string PatientName { get; set; }
    }
    public class FeedBackComments
    {
        public int FeedBack_ID { get; set; }

        public int FeedBackCommentID { get; set; }
        public int Patient_ID { get; set; }
        public string Comments { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedTime { get; set; }
        public int FBTypeID { get; set; }
        public string FBType { get; set; }
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Role { get; set; }
    }

    public class FeedbackType
    {
        public int FeedbackTypeID { get; set; }

        public string FBType { get; set; }

        public int Count { get; set; }
       
    }
}