using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.Data.TestRepos
{
    public class StateTestRepository : IStateRepository
    {
        Dictionary<string, State> states = new Dictionary<string, State>();

        public StateTestRepository()
        {
            State ohio = new State()
            {
                StateAbbreviation = "OH",
                StateName = "Ohio",
                TaxRate = 6.25M

            };
            State pennsylvania = new State()

            {
                StateAbbreviation = "PA",
                StateName = "Pennsylvania",
                TaxRate = 6.75M

            };
            State michigan = new State()
            {
                StateAbbreviation = "MI",
                StateName = "Michigan",
                TaxRate = 5.75M
            };
            State indiana = new State()
            {
                StateAbbreviation = "IN",
                StateName = "Indiana",
                TaxRate = 6M
            };
            
            

            states.Add("Ohio", ohio);
            states.Add("Pennsylvania", pennsylvania);
            states.Add("Michigan", michigan);
            states.Add("Indiana", indiana);

        }

        public State GetState(string StateName)
        {
            State value = states[StateName];
            return value;
        }

        public Dictionary<string, State> ListState()
        {
            return states;
        }
    }
}
