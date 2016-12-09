using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public interface IProductRepository
    {
        Dictionary<string, Product> ListProducts();
        Product GetProduct(string ProductType);
    }
}
