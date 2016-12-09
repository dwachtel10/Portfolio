using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Models;

namespace HR_Portal.Data.Repositories
{
    public class OpeningTestRepo : IOpeningRepository
    {

        
            private static List<Opening> _openings;

        public OpeningTestRepo()
        {
            if (_openings == null)
            {
                _openings = new List<Opening>
                {
                    new Opening()
                    {
                        JobId = 1,
                        JobTitle = "Admin. Assistant",
                        JobLocation = "Hudson, OH",
                        JobDescription = "Filler text"
                    }
                };

            }
        }

        public  List<Opening> GetAll()
            {
                return _openings;
            }

            public void AddOpening(Opening opening)
            {

                
            
                opening.JobId = _openings.Max(a => a.JobId) + 1;
                _openings.Add(opening);
            }

            public void DeleteOpening(Opening opening)
            {
                _openings.RemoveAll(a => a.JobId == opening.JobId);
            }


        

        public void EditOpening(Opening opening)
        {
            var selectedOpening = _openings.First(c => c.JobId == opening.JobId);

            selectedOpening.JobTitle = opening.JobTitle;
            selectedOpening.JobLocation = opening.JobLocation;
            selectedOpening.JobDescription = opening.JobDescription;

        }

            public Opening GetById(int OpeningID)
            {
                return _openings.FirstOrDefault(a => a.JobId == OpeningID);

            }

            public int GetOpeningId()
            {
                bool notFirstOpening = _openings.Count != 0;
                if (notFirstOpening)
                {
                    return _openings.Max(a => a.JobId) + 1;
                }
                else
                {
                    return 1;
                }
            }

        }
    }

