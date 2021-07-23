using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public class Figure
    {
        public string Name { get; set; }
        public int NumberOfSides { get; set; }
        public virtual void Display()
        {
            Console.WriteLine("Figure Name = {0}, NumberOfSides = {1}", Name, NumberOfSides);
        }
    }
}
