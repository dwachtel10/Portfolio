using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopsWarmups
{
    public class Loops
    {
        public string StringTimes(string str, int n)
        {
            string multiple = "";
            for (int i = 0; i < n; i++)
            {
                multiple += str;
            }

            return multiple;
        }

        public string FrontTimes(string str, int n)
        {
            string front = str.Substring(0, 3);
            string multiple = "";
            for (int i = 0; i < n; i++)
            {
                multiple += front;
            }
            return multiple;
        }

        public int CountXX(string str)
        {
            int countxx = 0;

            for (int i = 0; i < str.Length - 1; i++)
            {
                if ((str[i] == 'x') && (str[i + 1] == 'x'))
                {
                    countxx++;
                }
            }
            return countxx;
        }

        public bool DoubleX(string str)
        {
            bool isDouble = false;
            for (int i = 0; i < str.Length - 1; i++)
            {
                if (str[i] == 'x')
                {
                    {
                        if (!(str[i + 1] == 'x'))
                        {
                            isDouble = false;
                            break;
                        }
                        else if (str[i + 1] == 'x')
                        {
                            isDouble = true;
                            break;
                        }

                    }
                }
            }
            return isDouble;
        }

        public string EveryOther(string str)
        {
            var result = "";
            for (int i = 0; i < (str.Length); i += 2)
            {
                result += str.Substring(i, 1);
            }
            return result;
        }

        public string StringSplosion(string str)
        {
            var result = "";
            for (int i = 0; i < str.Length; i++)
            {
                result += str.Substring(0, 1 + i);
            }
            return result;
        }

        public int CountLast2(string str)
        {

            char secondLast = str[str.Length - 2];
            char lastChar = str[str.Length - 1];
            int total = 0;

            for (int i = 0; i < str.Length - 3; i++)
            {
                if (str[i] == secondLast && str[i + 1] == lastChar)
                {
                    total++;
                }
            }
            return total;
        }

        public int Count9(int[] numbers)
        {
            int total9s = 0;
            foreach (int n in numbers)
            {
                if (n == 9)
                { total9s++; }
            }
            return total9s;
        }

        public bool ArrayFront9(int[] numbers)
        {
            bool is9 = false;
            for (int i = 0; i < 3; i++)
            {
                if (numbers[i] == 9)
                {
                    is9 = true;
                }

            }
            return is9;


        }

        public bool Array123(int[] numbers)
        {
            bool isTarget = false;
            for (int i = 0; i < numbers.Length - 2; i++)
            {
                if (numbers[i] == 1 && numbers[i + 1] == 2 && numbers[i + 2] == 3)
                { isTarget = true; }

            }
            return isTarget;
        }

        public int SubStringMatch(string a, string b)
        {
            int matches = 0;
            for (int i = 0; i < b.Length - 1; i++)
            //took length of shorter one; consider refactoring once smarter
            {
                if (a[i] == b[i] && a[i + 1] == b[i + 1])
                {
                    matches++;
                }
            }

            return matches;

        }

        public string StringX(string str)
        {
            string firstLetter = str.Substring(0, 1);
            string lastLetter = str.Substring(str.Length - 1, 1);
            string results = "";
            for (int i = 1; i < str.Length - 2; i++)
            {
                results = str.Replace("x", "");
                if (firstLetter == "x" && lastLetter == "x")
                {
                    results = "x" + results + "x";

                }
            }
            return results;
        }

        public string AltPairs(string str)
        {
            string result = "";
            for (int i = 0; i < str.Length && i < 10; i++)
            {
                switch (i)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 5:
                    case 8:
                    case 9:
                        result += str[i];
                        break;
                    default:
                        break;
                }
            }


            return result;
        }

        public string DoNotYak(string str)
        {
            string unYak = "";
            for (int i = 0; i < str.Length-2; i++)
            {
                if (str[i] == 'y' && str[i + 2] == 'k') //is this actually doing anything?
                {

                    unYak = str.Replace("yak", "");
                     
                }
            }
            
            return unYak;
        }

        public int Array667(int[] numbers)
        {
            int doubleSix = 0;
            for (int i = 0; i < numbers.Length-1; i++)
            {
                if ((numbers[i] == 6) && (numbers[i+1] == 6 || numbers[i+1] == 7)){
                    doubleSix++;
            }
                
            }
            return doubleSix;
        }

        public bool NoTriples(int[] numbers)
        {
            bool noTrip = true;
            for (int i = 0; i < numbers.Length -3; i++)
            {
                if ((numbers[i] == numbers[i+1]) & (numbers[i+1] == numbers[i + 2])){
                    noTrip = false;
                }

            }
            return noTrip;
        }

        public bool Pattern51(int[] numbers)
        {
            bool Pat51 = false;
            for (int i = 0; i < numbers.Length-2; i++)
            {
                if ((numbers[i+1] == numbers[i] + 5) & (numbers[i+2] == numbers[i] - 1))
                {
                    Pat51 = true;
                } 
            }
            return Pat51;
        }
    }
}

            

    
  
    

                
              
         
 


              
   

              

            
           
        
        
    

