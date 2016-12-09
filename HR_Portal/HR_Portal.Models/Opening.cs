using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Build.Framework;

namespace HR_Portal.Models
{
    public class Opening
    {
        [Required]
        public int JobId { get; set; }
        
        public string JobTitle { get; set; }
        public string JobLocation { get; set; }
        public string JobDescription { get; set; }
        public string JobPhone { get; set; }
        public string JobEmail { get; set; }
    }
}
