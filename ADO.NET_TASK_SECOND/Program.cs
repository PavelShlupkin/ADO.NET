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
            PyramidFile file = new PyramidFile();
            Employee[] arrEmployee = file.Read();
            file.Write(arrEmployee);

            CircleReader fileCircle = new CircleReader();
            Ring a = fileCircle.Read();
            fileCircle.Save(a);
        }
    }
}
