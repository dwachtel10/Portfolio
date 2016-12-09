using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Flooring.Models;

namespace Flooring.Data.ProdRepos
{
    class StateProdRespository : IStateRepository

    {
        //Dictionary<string, State> states = new Dictionary<string, State>();

        public Dictionary<string, State> ListState()
        {

            var fileName = @"C:\_repos\douglas-wachtel-individual-work\Mastery\Masteryv2\DataFiles\States.txt";

            Dictionary<string, State> ListState = new Dictionary<string, State>();

            if (File.Exists(fileName))
            {
                using (StreamReader sr = File.OpenText(fileName))
                {
                    sr.ReadLine();

                    string inputLine = "";
                    while ((inputLine = sr.ReadLine()) != null)
                    {
                        string[] inputParts = inputLine.Split(',');
                        State newState = new State()
                        {
                            StateAbbreviation = inputParts[0],
                            StateName = inputParts[1],
                            TaxRate = decimal.Parse(inputParts[2])

                        };
                        ListState.Add(newState.StateName, newState);

                    }
                    
                    
                }
                
            }
            return ListState;

        }

        public State GetState(string StateName)
        {

            return ListState()[StateName];
        }
    }
}
