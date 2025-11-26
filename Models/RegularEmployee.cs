using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabanete_FirstLabExam.Models
{
    public class RegularEmployee : Employee
    {
        public decimal MonthlySalary { get; set; }
        public List<string> Benefits { get; set; }

        public int VacationDays { get; set; }
        

        public override decimal CalculateSalary()
        {
            return MonthlySalary;
        }


    }
}
