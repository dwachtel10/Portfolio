using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_Portal.Models.Responses
{
    public class ListOpeningResponses : Response
    {
        public List<Opening> openings { get; set; }
    }
}
