using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FarmerCompanionDBContext.Users;
using System.ComponentModel;

namespace FarmerCompanionDBContext.FarmerSurvey
{
    public class FarmerSurveys
    {
        public int Id { get; set; }

        [Column("User_Id")]
        public int UserId { get; set; }
        [Required]
        public virtual User Users { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string AnswerQA { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string AnswerQB { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string AnswerQC { get; set; }

        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string Recommendations { get; set; }

        [Column(TypeName="DateTime")]
        public DateTime SurveyDate { get; set; }
    }
}
