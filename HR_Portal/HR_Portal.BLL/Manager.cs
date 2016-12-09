using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Data;
using HR_Portal.Models;
using HR_Portal.Models.Responses;

namespace HR_Portal.BLL
{
    public class Manager
    {

        public ListApplicantResponses ListApplicants()
        {
            IApplicantRepository repo = RepoFactory.CreateApplicantRepository();
           ListApplicantResponses response = new ListApplicantResponses();
            var applicants = repo.GetAll();

            if (applicants.Count == 0)
            {
                response.Success = false;
                response.Message = "No applicants found.";
            }
            else
            {
                response.Success = true;
                response.applicants = applicants;
            }

            return response;
        }

        public void AddApplicant(Applicant applicant)
        {
            IApplicantRepository repo = RepoFactory.CreateApplicantRepository();
            
            applicant.ApplicantID = GetApplicantID(repo.GetAll());
            repo.AddApplicant(applicant);

           
        }

        public void EditApplicant(Applicant applicant, Applicant editedApplicant)
        {
            IApplicantRepository repo = RepoFactory.CreateApplicantRepository();
            
            repo.EditApplicant(applicant, editedApplicant);

            
        }

        public void DeleteApplicant(Applicant applicant)
        {
            IApplicantRepository repo = RepoFactory.CreateApplicantRepository();
            repo.DeleteApplicant(applicant);
        }

        public int GetApplicantID(List<Applicant> applicants)
        {
            if (applicants.Count != 0)
            {
                return applicants.Max(a => a.ApplicantID) + 1;
            }
            else
            {
                return 1;
            }
        }

        public ListOpeningResponses ListOpenings()
        {
            IOpeningRepository repo = RepoFactory.CreateOpeningRepository();
            ListOpeningResponses response = new ListOpeningResponses();
            var openings = repo.GetAll();

            if (openings.Count == 0)
            {
                response.Success = false;
                response.Message = "No openings found.";
            }
            else
            {
                response.Success = true;
                response.openings = openings;
            }

            return response;
        }

        public void AddOpening(Opening opening)
        {
           
            IOpeningRepository repo = RepoFactory.CreateOpeningRepository();
            opening.JobId = GetOpeningID(repo.GetAll());
            repo.AddOpening(opening);


        }

        public void EditOpening(Opening opening, Opening editedOpening)
        {
            IOpeningRepository repo = RepoFactory.CreateOpeningRepository();
            opening.JobId = GetOpeningID(repo.GetAll());

            repo.EditOpening(editedOpening);


        }

        public void DeleteOpening(Opening opening)
        {
            IOpeningRepository repo = RepoFactory.CreateOpeningRepository();
            opening.JobId = GetOpeningID(repo.GetAll());
            repo.DeleteOpening(opening);

        }

        public int GetOpeningID(List<Opening> openings)
        {
            if (openings.Count != 0)
            {
                return openings.Max(a => a.JobId) + 1;
            }
            else
            {
                return 1;
            }
        }
    }
}
