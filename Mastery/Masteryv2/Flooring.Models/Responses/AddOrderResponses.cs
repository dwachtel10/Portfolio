using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models.Responses;
using Flooring.Models;


namespace Flooring.Models.Responses 
{
    public class AddOrderResponses : Response
    {
       public List<Order> orders { get; set; }
    }
}
