using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Models;

namespace HR_Portal.Data.Repositories
{
    public class ApplicantTestRepo: IApplicantRepository
    {
        private static List<Applicant> _applicants;

        public ApplicantTestRepo()
        {
            if (_applicants == null)
            {
                _applicants = new List<Applicant>();
            }    
        }

        public List<Applicant>  GetAll()
        {
            return _applicants;
        }

        

        public void AddApplicant(Applicant applicant)
        {
            //applicant.ApplicantID = _applicants.Max(a => a.ApplicantID) + 1;
            _applicants.Add(applicant);
        }

        public void DeleteApplicant(Applicant applicant)
        {
            _applicants.RemoveAll(a => a.ApplicantID == applicant.ApplicantID);
        }

        public void EditApplicant(Applicant applicant, Applicant selectedApplicant)
        {
           _applicants.Add(selectedApplicant);
            _applicants.Remove(applicant);
            

        }

        public Applicant ViewApplicant(int ApplicantID)
        {
            return _applicants.FirstOrDefault(a => a.ApplicantID == ApplicantID);

        }

        public int GetApplicantID()
        {
            bool notFirstApplicant = _applicants.Count != 0;
            if (notFirstApplicant)
            {
                return _applicants.Max(a => a.ApplicantID) + 1;
            }
            else
            {
                return 1;
            }
        }

    }
}
