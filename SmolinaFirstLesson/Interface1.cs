using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SmolinaFirstLesson
{
    public interface IFigure
    {
        string Name { get; set; }
        int NumberOfSides { get; set; }
        int SideSize { get; set; }
        double Area { get; set; }
        void Display();        
    }
}
