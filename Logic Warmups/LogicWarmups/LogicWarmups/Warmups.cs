using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicWarmups
{
    public class Warmups
    {

        public bool GreatParty(int cigars, bool isWeekend)
        {
            if (cigars >= 40)
            {
                return (cigars <= 60 || isWeekend);
            }
            else
            {
                return false;
            }
        }

        public int CanHazTable(int yourStyle, int dateStyle)
        {
            if (yourStyle <= 2 || dateStyle <= 2)
            {
                return 0;
            }
            else if (yourStyle >= 8 || dateStyle >= 8)
            {
                return 2;
            }
            else
            {
                return 1;
            }
        }

        public bool PlayOutside(int temp, bool isSummer)
        {
            return ((temp >= 60 & (temp <= 90 & !(isSummer)) || (temp >= 60 && temp <= 100  && isSummer)));
        }

        public int CaughtSpeeding(int speed, bool isBirthday)
        {
            if (isBirthday == true)
            {
                if (speed >= 66 && speed <= 85)
                {
                    return 1;
                }
                else if (speed > 85)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
            else
            {
                if (speed >= 61 && speed <= 80)
                {
                    return 1;
                }
                else if (speed > 80)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }

        }

        public int SkipSum(int a, int b)
        {
            if (a + b <= 19 && a + b >= 10)
            {
                return 20;
            }
            else
            {
                return a + b;
            }
        }
            
        

        public string AlarmClock(int day, bool vacation)
        {
            if (vacation)
            {
                if ((day == 0) || (day == 6))
                {
                    return "off";
                }
                else
                {
                    return "10:00";
                }
            }
            else
            {
                if ((day == 0) || (day == 6))
                {
                    return "10:00";
                }
                else
                {
                    return "7:00";
                }
            }

        }

        public bool LoveSix(int a, int b)
        {
            int diff = Math.Abs(a - b);
            int diff2 = Math.Abs(b - a);
            int sum = a + b;
            if (a == 6 || b == 6)
            {
                return true;
            }
            else if (sum == 6 || diff == 6 || diff2 == 6)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool InRange(int n, bool outsideMode)
        {
            if (outsideMode)
            {
                if (n >= 1 && n <= 10)
                {
                    return false;
                }

                else
                {
                    return true;
                }
            }

            else
            {
                if (n >= 1 && n <= 10)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        public bool SpecialEleven(int n)
        {
            if (n % 11 == 0 || (n-1) % 11 ==0 )
            {
                return true;
            }

            else
            {
                return false;
            }
        }
        
        public bool Mod20(int n)
        {
            if ((n - 1) % 20 == 0 || (n - 2) % 20 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool Mod35(int n)
        {
            if (n % 3 == 0 && n % 5 == 0)
            {
                return false;
            }

            else if (n % 3 == 0 || n % 5 == 0)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool AnswerCell(bool isMorning, bool isMom, bool isAsleep)
        {
            if (isAsleep)
            {
                return false;
            }

            else if (isMorning)
            {
               if (isMom)
                {
                    return true;
                }
               else
                {
                    return false;
                }
            }
            else
            {
                return true;
            }
        }

        public bool TwoIsOne(int a, int b, int c)
        {
            if ((a + b == c) || (b + c == a) || (c + a == b))
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public bool AreInOrder(int a, int b, int c, bool bOk)
        {
            if (!bOk)
            {
                if (c > b && b > a)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return (c > a);
            } 

        }

        public bool InOrderEqual(int a, int b, int c, bool equalOk)
        {
            if (!equalOk)
            {
                return (a < b && b < c);
            }

            else
            {
                return ((a < b && b < c) || ((a == b) && (b < c)) || ((a < b) && (b == c)));
            }
        }

        public bool LastDigit(int a, int b, int c)
        {
            //this is horribly inefficient.  I was tired.
            string aString = a.ToString();
            string bString = b.ToString();
            string cString = c.ToString();
            string aLast = aString.Substring(aString.Length - 1);
            string bLast = bString.Substring(bString.Length - 1);
            string cLast = cString.Substring(cString.Length - 1);
            return (aLast == bLast || bLast == cLast || aLast == cLast);

        }

        public int RollDice(int die1, int die2, bool noDoubles)
        {
            if (!noDoubles)
            {
                return (die1 + die2);
            }
            else
            {
                if (die1 == die2)
                {
                    if (die1 == 6 || die2 == 6)
                    {
                        return (die1 + die2 - 5);
                    }
                    else
                    {
                        return (die1 + die2 + 1);
                    }
                }
                else
                {
                    return (die1 + die2);
                }

                }
            }
            
        }
    }


