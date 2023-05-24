using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week7_1
{
    class TicTacToe
    {
        private char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };



        public bool checkWin()
        {
            // horizontal check
            if ((arr[1] == arr[2]) && (arr[2] == arr[3])) return true;
            else if ((arr[4] == arr[5]) && (arr[5] == arr[6])) return true;
            else if ((arr[7] == arr[8]) && (arr[8] == arr[9])) return true;
            // vertical check
            else if ((arr[1] == arr[4]) && (arr[4] == arr[7])) return true;
            else if ((arr[2] == arr[5]) && (arr[5] == arr[8])) return true;
            else if ((arr[3] == arr[6]) && (arr[6] == arr[9])) return true;
            // diagonal check
            else if ((arr[1] == arr[5]) && (arr[5] == arr[9])) return true;
            else if ((arr[3] == arr[5]) && (arr[5] == arr[7])) return true;

            return false;
        }

        public bool move(int boardLoc, int player)
        {
            if (player == 1 || player == 2)
            {
                if (boardLoc > 0 && boardLoc < 10)
                {
                    if (player == 1)
                    {
                        if (arr[boardLoc] == 'X' || arr[boardLoc] == 'O')
                        {
                            return false;
                        }
                        else
                        {
                            arr[boardLoc] = 'X';
                            return true;
                        }

                    }
                    else
                    {
                        if (arr[boardLoc] == 'X' || arr[boardLoc] == 'O')
                        {
                            return false;
                        }
                        else
                        {
                            arr[boardLoc] = 'O';
                            return true;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Wrong board location");
                }
            }
            else
                Console.WriteLine("Wrong player!");

            return false;
        }


        public void printBoard()
        {
            Console.WriteLine("\t   " + " | " + "   " + " | ", "   ");
            Console.WriteLine("\t {0} " + " | " + " {1} " + " | " + " {2} ", arr[1], arr[2], arr[3]);
            Console.WriteLine("\t___" + " | " + "___" + " | " + "___");
            Console.WriteLine("\t   " + " | " + "   " + " | ", "   ");
            Console.WriteLine("\t {0} " + " | " + " {1} " + " | " + " {2} ", arr[4], arr[5], arr[6]);
            Console.WriteLine("\t___" + " | " + "___" + " | " + "___");
            Console.WriteLine("\t   " + " | " + "   " + " | ", "   ");
            Console.WriteLine("\t {0} " + " | " + " {1} " + " | " + " {2} ", arr[7], arr[8], arr[9]);
            Console.WriteLine("\t   " + " | " + "   " + " | " + "   ");
        }
    }
}
