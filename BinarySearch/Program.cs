using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class Program
    {
        static void Main(string[] args)
        {
            var sortedArray = new int [] { 1, 2, 3, 4, 5, 6, 9 };
            Console.WriteLine("Enter Search Key : ");
            var key = Console.ReadLine();
            Console.WriteLine("Input matched : " + SearchByIterative(sortedArray, 0, sortedArray.Length - 1, int.Parse(key)));
            Console.ReadKey();
        }
        static string SearchByRecursion(int [] array, int lowerbound, int upperBound,int key)
        {
           
            if (upperBound<lowerbound)
            {
                return "NO";
            }
           
            var midBound = (lowerbound + upperBound)/2;
            if (array[midBound] == key)
                return "Yes";
            if (array[midBound]>key)
            {
                upperBound = midBound-1;
            }
            if (array[midBound] < key)
            {
                lowerbound = midBound+1; 
            }
            return SearchByRecursion(array, lowerbound, upperBound, key);

        }
        static string SearchByIterative(int[] array, int lowerbound, int upperBound, int key)
        {
            bool isContinue = true;
            var matched = "NO";
            while (isContinue)
            {
                if (upperBound < lowerbound)
                {
                    isContinue = false;
                }

                var midBound = (lowerbound + upperBound) / 2;
                if (array[midBound] == key)
                {
                    matched = "Yes";
                    isContinue = false;
                }
                if (array[midBound] > key)
                {
                    upperBound = midBound - 1;
                }
                if (array[midBound] < key)
                {
                    lowerbound = midBound + 1;
                }
            }
            return matched;
        }
        //static string Searc(int[] array, int lowerbound, int upperBound, int key)
        //{
        //    var index = "No";
        //    if (upperBound < lowerbound)
        //    {
        //        return index;
        //    }
        //    var midBound = (lowerbound + upperBound) / 2;
        //    if (array[midBound] > key)
        //    {
        //        upperBound = midBound - 1;
        //        SearchByRecursion(array, lowerbound, upperBound, key);
        //    }
        //    if (array[midBound] < key)
        //    {
        //        lowerbound = midBound + 1;
        //        SearchByRecursion(array, lowerbound, upperBound, key);
        //    }
        //    if (array[midBound] == key)
        //        index = "Yes";
        //    return index;
        //}

    }
}
