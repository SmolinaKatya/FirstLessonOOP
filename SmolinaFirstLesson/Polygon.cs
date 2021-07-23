using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public class Polygon : Figure
    {
        public override void Display()
        {
            Console.WriteLine("Polygon name = {0}, NumberOfSides = {1}", Name, NumberOfSides);
        }
    }
}
