using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models.Interfaces
{
    public interface IProductRepository
    {
        List<Product> ListProduct(string ProductName);
        Product GetProduct(string ProductName);
    }
}
