using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Data.Repositories;

namespace HR_Portal.Data
{
    public static class RepoFactory
    {
        public static IApplicantRepository CreateApplicantRepository()
        {
            IApplicantRepository repo;
            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":
                    repo = new ApplicantTestRepo();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not Valid.");
            }
            return repo;
        }

        public static IOpeningRepository CreateOpeningRepository()
        {
            IOpeningRepository repo;

            string mode = ConfigurationManager.AppSettings["Mode"].ToString();
            switch (mode)
            {
                case "Test":
                    repo = new OpeningTestRepo();
                    break;
                default:
                    throw new Exception("Mode Value in App Config is not Valid.");
            }
            return repo;
        }

    }
}
