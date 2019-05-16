﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHS.Common.DTO
{
    public class clsDeclarationModel
    {
        public int Patient_ID { get; set; }
        public bool Declaration { get; set; }

        public string CreatedBy { get; set; }

        public string CreatedDate { get; set; }

        public int MedTriage { get; set; }

        public DateTime DOB { get; set; }
        public string PatientName { get; set; }
    }
}
