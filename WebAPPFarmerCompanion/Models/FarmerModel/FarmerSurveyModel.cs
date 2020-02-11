using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebAPPFarmerCompanion.Models.FarmerModel
{
    public class FarmerSurveyModel
    {
        public int Survey_Id { get; set; }
        public int UserId { get; set; }
        public string Answer_QA { get; set; }
        public string Answer_QB { get; set; }
        public string Answer_QC { get; set; }
        public string Recommendation { get; set; }
        public DateTime Survey_Date { get; set; }
    }
}