using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using FarmerCompanion.Users;

namespace FarmerCompanion.FarmerSurvey
{
    public class FarmerSurveys
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string QuestionA { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string QuestionB { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string QuectionC { get; set; }

        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string Recommendations { get; set; }

        [Column("userId")]
        public int userId { get; set; }
        [Required]
        public virtual User Users { get; set; }
    }
}
