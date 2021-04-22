using System;
using System.Threading;

namespace ticToeC
{
    class Program
    {

        static int player = 1; //X is player 1 
        static string flag = "None";//if flag x then x won if o then o won else Draw
        static XOBoard board = null;
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Console.WriteLine("give me the size");
            int size = int.Parse(Console.ReadLine());//get the size of the board

            board = new XOBoard(size);
            board.init();//init the board with dots
          
            Console.WriteLine("Player1:X and Player2:O");
            do
            {
                //Console.Clear();
                Console.WriteLine("\n");
                if (player == 1)
                {
                    Console.WriteLine("X Turn\n");
                    board.display();// calling the display Function  
                    Console.WriteLine("give me row && col");
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());

                    if (row <= size && row > 0 && col <= size && col > 0)
                    {
                        if (board.checkPlace(row, col) == 1)
                            Console.WriteLine("the place is already taken");
                        else { 
                            board.put(row, col, "x");
                            player = 2;
                        }
                    }else
                        Console.WriteLine("you have to put indecies from 1-" + size);
                }
                else if (player == 2)
                {
                    Console.WriteLine("O Turn\n");
                    board.display();// calling the display Function  
                    Console.WriteLine("give me row && col");
                    int row = int.Parse(Console.ReadLine());
                    int col = int.Parse(Console.ReadLine());

                    if (row <= size && row > 0 && col <= size && col > 0)
                    {
                        if (board.checkPlace(row, col) == 1)
                            Console.WriteLine("the place is already taken");
                        else
                        {
                            board.put(row, col, "o");
                            player = 1;
                        }
                    }
                    else
                        Console.WriteLine("you have to put indecies from 1-" + size);
                }
                flag = board.status();// calling status of game 
            } while (flag != "x" && flag != "o" && flag != "Draw");

           // Console.Clear();// clearing the console  
            board.display();
            if (flag == "x")
            {
                Console.WriteLine("The winner is X");
            }
            else if (flag == "o")
            {
                Console.WriteLine("The winner is O");
            }
            else if (flag == "Draw")
            {
                Console.WriteLine("The game ended with Draw");
            }
            else
                Console.WriteLine("the game is still running");
            Console.ReadLine();
        } 
    }
}
