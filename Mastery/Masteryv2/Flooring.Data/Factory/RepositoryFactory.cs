using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Data.ProdRepos;
using Flooring.Data.TestRepos;
using Flooring.Models;


namespace Flooring.Data.Factory
{
    public static class RepositoryFactory
    {
        public static IOrderRepository CreateOrderRepo()
        {
            IOrderRepository repo;
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":

                    repo = new OrderTestRepository();
                    break;
                case "Prod":
                    repo = new OrderProdRepository();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not Valid.");


            }
            return repo;
        }
        public static IProductRepository CreateProductRepo()
        {
            IProductRepository repo;
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":
                    repo = new ProductTestRepository();
                    break;
                case "Prod":
                    repo = new ProductProdRepository();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not Valid.");
            }
            return repo;
        }
        public static IStateRepository CreateStateRepo()
        {
            IStateRepository repo;
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":
                    repo = new StateTestRepository();
                    break;
                case "Prod":
                    repo = new StateProdRespository();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not Valid.");
            }
            return repo;
        }


    }
}
