using System;

namespace week7_1
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe t = new TicTacToe();
            t.printBoard();
            int moveNumber;
            bool flag = true;
            bool cont = true;
            while (!t.checkWin())
            {

                while (flag)
                {
                    Console.WriteLine("Player1 (X): ");
                    moveNumber = int.Parse(Console.ReadLine());

                    cont = t.move(moveNumber, 1);

                    if (cont)
                    {
                        flag = false;
                    }

                }
                if (t.checkWin())
                {
                    Console.Clear();
                    t.printBoard();
                    Console.WriteLine("Player1 win!");
                    break;
                }


                Console.Clear();
                t.printBoard();

                flag = true;

                while (flag)
                {
                    Console.WriteLine("Player2 (O): ");
                    moveNumber = int.Parse(Console.ReadLine());

                    cont = t.move(moveNumber, 2);

                    if (cont)
                    {
                        flag = false;
                    }


                }
                if (t.checkWin())
                {
                    Console.Clear();
                    t.printBoard();
                    Console.WriteLine("Player2 win!");
                    break;
                }
                Console.Clear();
                t.printBoard();
                flag = true;


            }



        }
    }
}

