using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Participation_9_4_19
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Now;
            DateTime future = today.AddDays(27);
            
            Console.WriteLine(today);
            Console.WriteLine(future);

            var difference = future - today;
            Console.WriteLine(difference);


            Console.ReadKey();
        }
    }
}
