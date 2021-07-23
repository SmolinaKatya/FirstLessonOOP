using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public class Triangle : IFigure
    {
        public string Name { get; set; }
        public int NumberOfSides { get; set; }
        public int SideSize { get; set; }
        public double Area { get; set; }
        public void Display()
        {
            Area = Math.Sqrt(3) * Math.Pow(SideSize, 2) / 4;
            Console.WriteLine("Figure Name = {0}, NumberOfSides = {1}, Figure area = {2}", Name, NumberOfSides, Math.Round(Area, 2));
        }
    }
}
