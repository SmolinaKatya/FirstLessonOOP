using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    class Program
    {
        static void Main(string[] args)
        {
            Figure figure = new Figure() { Name = "Triangle", NumberOfSides = 3 };
            Rectangle rectangle = new Rectangle() { Name = "Foursquare", NumberOfSides = 4 };
            Polygon polygon = new Polygon() { Name = "Hexagon", NumberOfSides = 6 };

            Figure[] figures = new Figure[] { figure, rectangle, polygon };

            foreach (var item in figures)
            {
                item.Display();
            }
            //Console.ReadKey();
        }
    }
}
