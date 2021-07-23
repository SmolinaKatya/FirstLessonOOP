using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public class Rectangle : Figure
    {
        public override void Display()
        {
            Console.WriteLine("Rectangle name = {0}, NumberOfSides = {1}", Name, NumberOfSides);
        }
    }
}
