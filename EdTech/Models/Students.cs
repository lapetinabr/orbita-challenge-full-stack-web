using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EdTech.Models
{
    public class Students
    {
        [Key]
        public int id_student { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email{ get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string RA { get; set; }

        [Column(TypeName = "nvarchar(11)")]
        public string social_identification { get; set; }
        
        [Column(TypeName = "datetime")]
        public DateTime updated_at { get; set; }
        
        [Column(TypeName = "datetime")]
        public DateTime created_at { get; set; }
    }
}
