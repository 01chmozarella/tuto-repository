using Gabanete_FirstLabExam.Interface;
using Gabanete_FirstLabExam.Models;
using Gabanete_FirstLabExam.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gabanete_FirstLabExam
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmployeeFullName_Click(object sender, EventArgs e)
        {
            RegularEmployee reg = new RegularEmployee
            {
                FirstName = "Juan",
                LastName = "DelaCruz"
            };
            MessageBox.Show("Hello," + reg.GetFullName());
        }

        private void btnRegularEmployee_Click(object sender, EventArgs e)
        {
            RegularEmployee reg = new RegularEmployee
            {
                FirstName = "Juan",
                LastName = "DelaCruz",
                MonthlySalary = 50000
            };

            MessageBox.Show($"Monthly Salary is {reg.CalculateSalary()}");
            MessageBox.Show("Pait pa sir");
        }

        private void btnContractualEmployee_Click(object sender, EventArgs e)
        {
            ContractualEmployee con = new ContractualEmployee
            {
                FirstName = "Juan",
                LastName = "DelaCruz",
                HourlyRate = 500,
                HoursWorked = 8
            };
            MessageBox.Show($"Total Salary is {con.CalculateSalary()}");
        }

        private void btnMySQL_Click(object sender, EventArgs e)
        {
            IEmployeeRepository repo = new MySqlRepository();
            EmployeeManager manager = new EmployeeManager(repo);

            RegularEmployee reg = new RegularEmployee
            {
                FirstName = "Juan",
                LastName = "DelaCruz"
            };
            manager.AddEmployee(reg);
        }

        private void btnManagerApprove_Click(object sender, EventArgs e)
        {
            Manager manager = new Manager()
            {
                FirstName = "Juan",
                LastName = "DelaCruz"
            };

            manager.ApproveLeave();

        }
    }
}
