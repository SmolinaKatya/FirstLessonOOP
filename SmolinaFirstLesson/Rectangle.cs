using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public class Rectangle : IFigure
    {
        public string Name { get; set; }
        public int NumberOfSides { get; set; }
        public int SideSize { get; set; }
        public double Area { get; set; }
        public void Display()
        {
            Area = Math.Pow(SideSize, 2);
            Console.WriteLine("Rectangle name = {0}, NumberOfSides = {1}, Figure area = {2}", Name, NumberOfSides, Math.Round(Area, 2));
        }
    }
}
