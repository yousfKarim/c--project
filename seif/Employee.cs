using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seif
{
    class Employee
    {
        [Key]
        public int Emp_Id { get; set; }

        [Required]
        public string Emp_Name { get; set; }

        [ForeignKey("Department")]
        public int dp_Id { get; set; }

        public Department department { get; set; }
    }
    
}