using System;

namespace Nqueens
{
    class Queen
    {
        public BoardLocation Location { get; set; }

        public Queen(BoardLocation location)
        {
            Location = location;
        }

        public bool ThreatensLocation(BoardLocation location)
        {
            int xDiff = Math.Abs(Location.X - location.X);
            int yDiff = Math.Abs(Location.Y - location.Y);
            return xDiff == 0 || yDiff == 0 || xDiff == yDiff;
        }
    }
}