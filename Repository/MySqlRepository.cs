using Gabanete_FirstLabExam.Interface;
using Gabanete_FirstLabExam.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabanete_FirstLabExam.Repository
{
    public class MySqlRepository : IEmployeeRepository
    {
        public void Save(Employee employee)
        {
            MessageBox.Show("Saving to MySQL");
        }
    }

}
