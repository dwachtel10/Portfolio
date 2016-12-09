using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Portal.Models
{
    public class EmploymentHistory
    {
        public string CompanyName { get; set; }
        public Address CompanyAddress { get; set; }
        public string JobTitle { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

        
    }
}
