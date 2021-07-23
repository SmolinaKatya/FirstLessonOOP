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
            Triangle triangle = new Triangle() { Name = "Equilateral Triangle", NumberOfSides = 3, SideSize = 5 };
            Rectangle rectangle = new Rectangle() { Name = "Foursquare", NumberOfSides = 4, SideSize = 5 };
            Polygon polygon = new Polygon() { Name = "Hexagon", NumberOfSides = 6, SideSize = 5 };

            IFigure[] figures = new IFigure[] { triangle, rectangle, polygon };

            foreach (var item in figures)
            {
                item.Display();
            }
        }
    }
}
