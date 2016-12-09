using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Portal.Models
{
    public class Address
    {
        public string Street1 { get; set; }
        public string Street2 { get; set; }
        public string StateName { get; set; }
        public string StateAbbreviation { get; set; }
        public int ZipCode { get; set; }
    }
}
