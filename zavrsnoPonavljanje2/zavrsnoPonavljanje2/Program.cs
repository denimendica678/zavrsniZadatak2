using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zavrsnoPonavljanje2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sek, min, vrijeme;

            Console.Write("Upišite broj sekundi: ");
            vrijeme = Convert.ToInt32(Console.ReadLine());

            min = vrijeme / 60;
            sek = vrijeme % 60;

            Console.Write("Vrijeme pretvoreno u minute i sekunde je: " + min + ":" + sek);

            Console.ReadKey();
        }
    }
}
