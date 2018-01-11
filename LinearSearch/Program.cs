using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearSearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] { 1, 2, 3, 4, 5, 6, 9 };
            Console.WriteLine("Enter Search Key : ");
            var key = Console.ReadLine();
            Console.WriteLine("Input matched : " + LinearSearch(array, int.Parse(key)));
            Console.ReadKey();
        }
        static string LinearSearch(int [] array, int key)
        {
            foreach(var a in array)
            {
                if(a==key)
                {
                    return "Yes";
                }
            }
            return "NO";
        }

    }
}
