using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ADO.NET_TASK_FIRST
{
  
    class PyramidFile
    {
    private const string FileIn = "input.txt";
    private const string FileOut = "output.txt";
        public List<Point> Read()
        {
            List<double> coordinates = new List<double>();
            List<Point> points = new List<Point>();
            using (StreamReader file = new StreamReader(FileIn))
            {
                string[] StrFromFile = file.ReadToEnd().Split(new[] { " ", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item)).ToArray();
                foreach (var s in StrFromFile)
                {
                    if (!double.TryParse(s, out var value))
                    {
                        throw new ArgumentException("Incorrect coordinate in reading ");
                    }
                    else
                    {
                        coordinates.Add(value);
                    }
                }

                for (int i = 0; i < coordinates.Count; i += 3)
                {
                    points.Add(new Point(coordinates[i], coordinates[i + 1], coordinates[i + 2]));
                }
                return points;

            }
        }

        public void Write(double Area, double V)
        {
            using (StreamWriter ws = new StreamWriter(FileOut))
            {
                ws.WriteLine("Base S: {0}", Area);
                ws.WriteLine("Pyramid V: {0}", V);               
            }
        }
    }

}