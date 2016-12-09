using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Portal.Models
{
    public class Applicant
    {
        public int ApplicantID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public int PhoneNumber { get; set; }
        public EmploymentHistory EmploymentHistory { get; set; }

    }
}
