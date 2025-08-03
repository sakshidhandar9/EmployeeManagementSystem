using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MontCrestEmployeeProject.Models
{
    public class Employee
    {
            [Key]
            public int EmployeeId { get; set; }
            [Required]
            public string EmployeeName { get; set; }
            [Required]
            public string Address { get; set; }
            [Required]
            public string Email { get; set; }

            [Required(ErrorMessage = "Mobile number is required")]
            [StringLength(10, MinimumLength = 10, ErrorMessage = "Mobile number must be 10 digits")]
            [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Enter a valid 10-digit Indian mobile number starting with 6, 7, 8, or 9")]
            public string PhoneNo { get; set; }
            public string Photo { get; set; }

        public List<Qualification> Qualifications { get; set; } = new List<Qualification>();
    }

    }

