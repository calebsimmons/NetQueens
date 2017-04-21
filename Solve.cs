using System;
using System.Collections.Generic;
using System.Linq;

namespace Nqueens
{
    class Solve
    {
        private const int _n = 4;
        public static void Solution(Board board)
        {
            if(board.Locations.Count == 0)
            {
                if(board.Queens.Count == _n)
                {
                    foreach (Queen queen in board.Queens.ToList())
                    {
                        Console.Write("(" + queen.Location.X + ", " + queen.Location.Y +") ");
                    }
                    Console.WriteLine("");
                }
                return;
            }

            foreach(BoardLocation location in board.Locations.ToList())
            {
                Board afterBoard = new Board(board.Locations, board.Queens);
                afterBoard.Locations.Remove(location);
                Queen queen = new Queen(location);
                afterBoard.Queens.Add(queen);
                foreach(BoardLocation target in afterBoard.Locations.ToList())
                {
                    if(queen.ThreatensLocation(target))
                    {
                        afterBoard.Locations.Remove(target);
                    }
                }
                Solve.Solution(afterBoard);
            }

            return;
        }

        public static void Main()
        {
            
            
            Console.WriteLine("Hello World!");
            Board board = new Board(_n,_n);
            Solve.Solution(board);
        }
    }
}