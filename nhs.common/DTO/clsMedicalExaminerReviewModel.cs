using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
//using System.ComponentModel.DataAnnotations;
//using System.Web.Mvc;

namespace NHS.Common
{
    public class clsMedicalExaminerReviewModel
    {
        public clsMedicalExaminer objclsMedicalExaminer { get; set; }
        public clsMedicalExaminerReview objclsMedicalExaminerReview { get; set; }
    }

    public class CommentType
    {
        public int CommonTypeID { get; set; }
        public string Type { get; set; }
    }

    public class clsMedicalExaminer
    {
        public int ME_ID { get; set; }

        public string ME_FirstName { get; set; }
        public string ME_MiddleName { get; set; }
        public string ME_LastName { get; set; }
        
        public string CreatedBy { get; set; }
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public Nullable<System.DateTime> UpdatedDate { get; set; }
    }

    public class clsMedicalExaminerReview
    {
        public int MEReviewId { get; set; }
        public int Patient_ID { get; set; }
        public string PatientID { get; set; }
        public int ME_ID { get; set; }
        public bool QAP_Discussion { get; set; }
        public bool Notes_Review { get; set; }
        public bool Nok_Discussion { get; set; }
        public string Comments { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreateDate { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime UpdatedDate { get; set; }
        //[Display(Name = "Name of QAP")]
        public string QAPName { get; set; }

        public int CommentCount { get; set; }

        public int MedTriage { get; set; }

        public string PatientId { get; set; }
        public string DOB { get; set; }
        public string PatientName { get; set; }

    }
}