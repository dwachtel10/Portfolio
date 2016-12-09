using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Flooring.Models
{
    public interface IStateRepository
    {
        Dictionary<string, State> ListState();
        State GetState(string StateName);
    }
}
