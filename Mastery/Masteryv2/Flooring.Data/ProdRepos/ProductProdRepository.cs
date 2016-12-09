using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.Data.ProdRepos
{
    class ProductProdRepository : IProductRepository
    {
        public Dictionary<string, Product> ListProducts()
        {
            var fileName = @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\Products.txt";
            Dictionary<string, Product> ListProduct = new Dictionary<string, Product>();
            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    sr.ReadLine();

                    string inputLine = "";
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        string[] inputParts = inputLine.Split(',');
                        Product newProduct = new Product()
                        {
                            ProductType = inputParts[0],
                            CostPerSquareFoot = decimal.Parse(inputParts[1]),
                            LaborPerSquareFoot = decimal.Parse(inputParts[2])
                        };
                        ListProduct.Add(newProduct.ProductType, newProduct);
                        
                    }
                }
            }
            return ListProduct;
        }

        public Product GetProduct(string ProductType)
        {
            return ListProducts()[ProductType];
        }
    }
}
