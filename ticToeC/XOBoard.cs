using System;
using System.Collections.Generic;
using System.Text;

namespace ticToeC
{
    class XOBoard
    {
        
        private int size = 0;
        private string[,] board;

        public XOBoard(int size)
        {
            this.size = size;
            board = new string[size, size];
        }

        public void put(int row,int col,string choice)
        { 
            board[row - 1, col - 1] = choice;
        }
      
     
        public void init()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    board[i, j] = ".";
                   
                }
            }
        }

        public string status()
        {
            bool isX = true;
            bool isO = true;
            bool isDraw = true;

                //// Row  X to win
                for (int i = 0; i < size; i++)
                {
                    isX = true;
                    for (int j = 0; j < size; j++)
                    {
                        if (board[i, j] == "o" || board[i, j] == ".")//if at least one O ecist in the row then X won't win
                        {
                            isX = false;
                        }
                    }
                    if (isX == true)
                        return "x";
                }



                //Columns

                for (int i = 0; i < size; i++)
                {
                    isX = true;
                    for (int j = 0; j < size; j++)
                    {
                        if (board[j, i] == "o" || board[j, i] == ".")
                        {
                            isX = false;
                        }
                    }
                    if (isX == true)
                        return "x";
                }



            //Diagonals
            //diagonal 1
            for (int i = 0; i < size; i++)
            {
                isX = true;
                for (int j = 0; j < size; j++)
                    {
                        if (board[j, j] == "o" || board[j, j] == ".")
                            {
                                isX = false;
                            }
                    }
                    if (isX == true)
                        return "x";
            }
            //diagonal 2
            isX = true;
            for (int j = size - 1, i = 0; j >= 0 && i < size; i++, j--)
                {
                    if (board[i, j] == "o" || board[i, j] == ".")
                        isX = false;
                }
                if (isX == true)
                    return "x";

      

                    //**********************************O Section

                    //rowas for o winning
                for (int i = 0; i < size; i++)
                    {
                        isO = true;
                        for (int j = 0; j < size; j++)
                        {
                            if (board[i, j] == "x" || board[i, j] == ".")
                            {
                                isO = false;
                            }
                        }
                        if (isO == true)
                            return "o";
                  }


                //columns
                for (int i = 0; i < size; i++)
                {
                    isO = true;
                    for (int j = 0; j < size; j++)
                    {
                        if (board[j, i] == "x" || board[j, i] == ".")
                        {
                            isO = false;
                        }

                    }
                    if (isO == true)
                        return "o";
                }


            //diagnolas
            for (int i = 0; i < size; i++)
            {
                isO = true;
                for (int j = 0; j < size; j++)
                    {
                        if (board[j, j] == "x" || board[j, j] == ".")
                            {
                                isO = false;
                            }
                    }
                    if (isO == true)
                        return "o";

            }
            isO = true;
            for (int j = size - 1, i = 0; j >= 0 && i < size; i++, j--)
                {
                    if (board[i, j] == "x" || board[i, j] == ".")
                        isO = false;
                }
                if (isO == true)
                    return "o";
       


            for (int i = 0; i < size; i++)//to check draw
            {
                for (int j = 0; j < size; j++)
                {
                    if (board[i, j] == ".")
                        isDraw = false;
                }
            }
            if (isDraw == true)
                return "Draw";

            return "None";
        }

        public int checkPlace(int row,int col)
        {
            if (board[row - 1, col - 1] != ".")
                return 1;
            return 0;
        }

        public void display()
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(board[i, j]+"\t");
                }
                Console.WriteLine();
            }
        }
    }
}

