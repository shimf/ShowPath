using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowPath
{
    class Program
    {
        static void Main(string[] args)
        {
            var paths = Environment.GetEnvironmentVariable("PATH", EnvironmentVariableTarget.Process);

            var pathArray = paths.Split(';');
            var i = 1;

            foreach(var p in pathArray)
            {
                Console.WriteLine($"{i}: {p}");
                i++;
            }

            Console.ReadKey();
        }
    }
}
