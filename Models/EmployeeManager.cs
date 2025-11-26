using Gabanete_FirstLabExam.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabanete_FirstLabExam.Models
{
    public class EmployeeManager 
    {
        private IEmployeeRepository _repo { get; set; }

        public EmployeeManager(IEmployeeRepository repo)
        {
            _repo = repo;
        }

        public void AddEmployee(object emp)
        {
            
        }
    } 
}
