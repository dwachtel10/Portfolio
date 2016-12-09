using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    public class Board
    {
        private string[] spaces;
        public Board()
        {
            spaces = new string[9];
            spacesLeft = 9;
            
        }
        private int spacesLeft;
        public string printBoard()
        {
            string result = "";
            int row = 0;
            for (int i = 0; i < spaces.Length; i++)
            {
                var col = i % 3;
                string cell = (i + 1).ToString();
                if (spaces[i] != null)
                {
                    cell = spaces[i];
                }
                result += cell;
                if (col < 2)
                { result += "|"; }
                if (col == 2 && row < 2)
                {
                    result += "\n-----\n";
                    row++;
                }
            }

            
            return result;
        }

        public PlaceResult PlaceMark(int v1, string v2)
        {
            PlaceResult SpaceResult = PlaceResult.Invalid;
            if (spaces[v1] == null)
            {
                SpaceResult = PlaceResult.Ok;
                spaces[v1] = v2;
                spacesLeft--;
                if (isWin(v2))
                {
                    SpaceResult = PlaceResult.Win;
                }
                else if (spacesLeft == 0)
                {
                    SpaceResult = PlaceResult.Tie;
                }
            }
            else if (spaces[v1] == v2)
            {
                SpaceResult = PlaceResult.Duplicate;

            }
            else if (spaces[v1] != v2)
            {
                SpaceResult = PlaceResult.Invalid;
            }


            return SpaceResult;
        }
        private bool isWin(string mark)
        {
            if (((spaces[0] == mark && ((spaces[1] == mark && spaces[2] == mark) || (spaces[4] == mark && spaces[8] == mark))) ||
                   ((spaces[3] == mark && ((spaces[4] == mark && spaces[5] == mark) || (spaces[0] == mark && spaces[6] == mark))) ||
                    ((spaces[6] == mark && ((spaces[7] == mark && spaces[8] == mark) || (spaces[4] == mark && spaces[2] == mark))) ||
                    (spaces[1] == mark && spaces[4] == mark && spaces[7] == mark) || (spaces[2] == mark && spaces[5] == mark && spaces[8] == mark)))))
            {
                return true;

            }
            return false;
        }

    }

    public enum PlaceResult
    {
        Ok,
        Invalid,
        Duplicate,
        Win,
        Tie
    }
}






    

