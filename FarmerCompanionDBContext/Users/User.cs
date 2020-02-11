using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmerCompanionDBContext.Users
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(25)]
        [Column(TypeName = "nvarchar")]
        public string UserName { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Email { get; set; }

        [Required]
        [MaxLength(555)]
        [Column(TypeName = "nvarchar")]
        public string Industry { get; set; }

        [Required]
        [MaxLength(100)]
        [Column(TypeName = "nvarchar")]
        public string Location { get; set; }

        [Required]
        [MaxLength(50)]
        [Column(TypeName="nvarchar")]
        public string Password { get; set; }
    }
}
