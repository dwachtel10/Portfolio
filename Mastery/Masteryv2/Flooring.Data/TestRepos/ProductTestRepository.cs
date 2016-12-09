using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.Data.TestRepos
{
    public class ProductTestRepository : IProductRepository
    {
        Dictionary<string, Product> products = new Dictionary<string, Product>();

        public ProductTestRepository()
        {
            Product carpet = new Product()
            {
                ProductType = "Carpet",
                CostPerSquareFoot = 2.25M,
                LaborPerSquareFoot = 2.10M
            };

            Product laminate = new Product()
            {
                ProductType = "Laminate",
                CostPerSquareFoot = 1.75M,
                LaborPerSquareFoot = 2.10M
            };

            Product tile = new Product()
            {
                ProductType = "Tile",
                CostPerSquareFoot = 3.50M,
                LaborPerSquareFoot = 4.15M
            };

            Product wood = new Product()
            {
                ProductType = "Wood",
                CostPerSquareFoot = 5.15M,
                LaborPerSquareFoot = 4.75M
            };

            products.Add("Carpet", carpet);
            products.Add("Laminate", laminate);
            products.Add("Tile", tile);
            products.Add("Wood", wood);
        }

        public Dictionary<string, Product> ListProducts()
        {
            return products;

        }

        public Product GetProduct(string ProductType)
        {
            Product value = products[ProductType];
            return value;
        }
    }
}
