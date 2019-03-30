using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ADO.NET_TASK_FIRST
{
    class Program
    {
        static void Main(string[] args)
        {
            PyramidFile workWithFile = new PyramidFile();
            List<Point> listOfCoordinates = new List<Point>();

            listOfCoordinates = workWithFile.Read();

            Pyramid pyramid = new Pyramid(listOfCoordinates);
            double area = pyramid.QuadrangleS();
            double v = pyramid.QuadrangleV();
            workWithFile.Write(area, v);
        }
    }
}
