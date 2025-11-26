using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabanete_FirstLabExam.Models
{

    public enum EmployeeStatus {Active, Inactive}

    public abstract class Employee : Person
    {
        public int EmployeeID { get; set; }
        public string Email { get; set; }
        public int PhoneNumber { get; set; }

        public EmployeeStatus status { get; set; }
        public int DepartmentID { get; set; }

        public abstract decimal CalculateSalary();

    }
}
