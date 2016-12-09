using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Models;

namespace HR_Portal.Data
{
    public interface IApplicantRepository
    {
        List<Applicant> GetAll();
        void AddApplicant(Applicant applicant);
        void DeleteApplicant(Applicant applicant);
        void EditApplicant(Applicant applicant, Applicant editedApplicant);
        Applicant ViewApplicant(int ApplicantID);
        int GetApplicantID();

    }
}
