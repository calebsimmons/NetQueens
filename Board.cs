using System.Collections.Generic;

namespace Nqueens
{
    class Board
    {   
        public List<BoardLocation> Locations { get; private set; } = new List<BoardLocation>();
        public List<Queen> Queens { get; set; } = new List<Queen>();

        public Board(int width, int height)
        {
            for(int i = 0; i < width; i++)
            {
                for(int k = 0; k < height; k++)
                {
                    Locations.Add(new BoardLocation(i, k, this));
                }
            }            
        }

        public Board(List<BoardLocation> locations, List<Queen> queens)
        {
            foreach(BoardLocation location in locations)
            {
                Locations.Add(new BoardLocation(location.X, location.Y, this));
            }

            foreach(Queen queen in queens)
            {
                Queens.Add(new Queen(queen.Location));
            }

            
        }
    }
}