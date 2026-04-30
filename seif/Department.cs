using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace seif
{
    class Department
    {
        [Key]
        public int DE_Id{get;set;}
       
        [Required]

        public string DE_Name{get;set;}
       public List<Employee> Employees{get;set;}
    }
}