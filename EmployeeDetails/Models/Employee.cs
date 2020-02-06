using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeDetails.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }

        public string Name { get; set; }
        [Display(Name ="Employee Number")]
        public string empNumber { get; set; }
        [Display(Name ="Employee Position")]
        public string position { get; set; }
        [Display(Name ="Employee Wage per Hour")]
        public double WagePerHour { get; set; }
        [Display(Name ="Employee Hours Worked")]
        public double HoursWorked { get; set; }
        [Display(Name ="Employee Salary")]
        public double TotalSalary { get; set; }

        public double Salary()//here is a simple method to calculate the total wage.
        {
            TotalSalary = WagePerHour * HoursWorked;
            return TotalSalary;
        }
    }
}
