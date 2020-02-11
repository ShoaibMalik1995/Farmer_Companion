using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace FarmerCompanion.Users
{
    public class User
    {
        public int Id { get; set; }

        [MaxLength(25)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Email { get; set; }

        [MaxLength(555)]
        [Column(TypeName = "varchar")]
        public string Industory { get; set; }

        [MaxLength(100)]
        [Column(TypeName = "varchar")]
        public string Location { get; set; }
    }
}
