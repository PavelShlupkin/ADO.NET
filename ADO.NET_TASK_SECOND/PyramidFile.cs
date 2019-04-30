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
       
            public Employee[] Read()
            {
                using (StreamReader sr = new StreamReader("input.txt"))
                {
                    String count = sr.ReadLine();
                    int i = 0;
                    Employee[] arrEmp = new Employee[int.Parse(count)];

                
                while (!sr.EndOfStream)
                    {
                        string[] line = sr.ReadLine().Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        if (!(int.TryParse(line[3], out int Dday)) || !int.TryParse(line[4], out int Dmounth) || !int.TryParse(line[5], out int Dyear))
                        {
                            throw new FormatException("Enter correct values");
                        }
                        arrEmp[i] = new Employee(line[0], line[1], line[2], new DateTime(Dyear, Dmounth, Dday), line[6], line[7], line[8]);
                        i++;
                    }
                    return arrEmp;
                }
            }
            public void Write(Employee[] arr)
            {
                using (StreamWriter sw = new StreamWriter("Output.txt"))
                {
                    foreach (var item in arr)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
            }
        }
    }
