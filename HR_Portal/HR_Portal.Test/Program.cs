using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.BLL;
using HR_Portal.Models;
using NUnit.Framework;

namespace HR_Portal.Test
{
    class Program
    {
        [TestFixture]
        public class Tests
        {
            [Test]
            public void CanDisplayAndAddOpening()
            {
                Manager manager = new Manager();
                Opening newOpening = new Opening
                {
                    JobId = 1,
                    JobTitle = "TestJob",
                    JobLocation = "TestLocation",
                    JobDescription = "Test Description",
                };
                manager.AddOpening(newOpening);
                var testResponse = manager.ListOpenings();
                Assert.IsTrue(testResponse.openings.Count != 0);
            }

            [Test]
            public void CanDisplayAndAddApplicant()
            {
                Manager manager = new Manager();
                DateTime date = new DateTime();
                Applicant newApplicant = new Applicant
                
                {
                    ApplicantID = 1,
                    FirstName = "Test",
                    LastName = "Testman",
                    PhoneNumber = 1234567,
                    Address = new Address
                    {
                        Street1 = "1234 Test Street",
                        Street2 = "Apt. 5",
                        StateAbbreviation = "OH",
                        StateName = "Ohio",
                        ZipCode = 12345
                    },
                    EmploymentHistory = new EmploymentHistory
                    {
                        CompanyAddress = new Address
                        {
                            Street1 = "4545 Test Street",
                            Street2 = "Suite 9",
                            StateAbbreviation = "OH",
                            StateName = "Ohio",
                            ZipCode = 12345
                        },
                        CompanyName = "TestCo.",
                        StartDate = date,
                        EndDate = DateTime.Today,
                        JobTitle = "Tester",
                        

                    }

                };
                manager.AddApplicant(newApplicant);
                var testResponse = manager.ListApplicants();
                Assert.IsTrue(testResponse.applicants.Count != 0);
            }
        }
    }
}
