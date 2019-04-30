using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace ADO.NET_TASK_FIRST
{
    public class CircleReader
    {
        private const string fileInName = "InputCircle.txt";
        private const string fileOutName = "Output.txt";

        public Ring Read()
        {
            using (StreamReader file = new StreamReader(fileInName))
            {
                string[] StrFromFile = file.ReadToEnd().Split(new[] { " ", "\n" }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(item => item.Trim())
                    .Where(item => !string.IsNullOrEmpty(item)).ToArray();
                foreach (var s in StrFromFile)
                {
                    if (!double.TryParse(s, out var value))
                    {
                        throw new ArgumentException("ERROR in reading file");
                    }
                }

                return new Ring(new Circle(double.Parse(StrFromFile[0]), double.Parse(StrFromFile[1]), double.Parse(StrFromFile[2])), new Circle(double.Parse(StrFromFile[0]), double.Parse(StrFromFile[1]), double.Parse(StrFromFile[3])));

            }
        }

        public void Save(Ring a)
        {
            using (StreamWriter sw = new StreamWriter(fileOutName,true))
            {
                sw.WriteLine("");
                sw.WriteLine("Площадь {0}", a.S);
                sw.WriteLine("Сумма длин {0}", a.LengthR);
            }
        }
    }
}