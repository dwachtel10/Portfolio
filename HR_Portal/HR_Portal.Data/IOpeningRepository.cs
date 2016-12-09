using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HR_Portal.Models;

namespace HR_Portal.Data
{
    public interface IOpeningRepository
    {
        List<Opening> GetAll();
        Opening GetById(int id);
        void AddOpening(Opening opening);
        void EditOpening(Opening opening);
        void DeleteOpening(Opening opening);
        int GetOpeningId();

    }
}
