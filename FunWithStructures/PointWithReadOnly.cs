using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithStructures
{
    struct PointWithReadOnly
    {
        // Fields of the structure.
        public int X;
        public readonly int Y;
        public readonly string Name;
        // Display the current position and name.
        public readonly void Display()
        {
            Console.WriteLine($"X = {X}, Y = {Y}, Name = {Name}");
        }
        // A custom constructor.
        public PointWithReadOnly(int xPos, int yPos, string name)
        {
            X = xPos;
            Y = yPos;
            Name = name;
        }
    }
}
