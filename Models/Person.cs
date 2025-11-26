using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gabanete_FirstLabExam.Models
{
    public  abstract class Person
    {
     public int IDNumber {get; set;}
    public string LastName { get; set; }
    public string FirstName { get; set; }

    public DateTime BirthDate { get; set; }

    public string Gender { get; set; }
    public string Address { get; set; }

     public string GetFullName()
        {
            return $"{LastName}, {FirstName}";
        }       

    }
}
