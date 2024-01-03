using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunWithValueAndReferenceTypes
{
    class PointRef
    {

        public int X, Y;

        public PointRef(int xPos, int yPos)
        {
            X = xPos;
            Y = yPos;
        }



        public void Increment()
        {
            X++; Y++;
        }

        public void Decrement()
        {
            X--; Y--;
        }

        public void Display()
        {
            Console.WriteLine("X: {0}, Y: {1}", X, Y);
        }
    }
}
