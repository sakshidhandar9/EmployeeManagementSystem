using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MontCrestEmployeeProject.Models
{
    public class Qualification
    {
        [Key]
        public int QualificationId { get; set; }

        [ForeignKey("Employee")]
        public int EmployeeId { get; set; }

        [Required]
        public string Degree { get; set; }

        
        public float Percentage { get; set; }

        public int Year { get; set; } 

        [Required]
        public string Grade { get; set; }

        public Employee Employee { get; set; } 


    }
}
