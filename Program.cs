using System;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            /** Crate an object of Linear Search  class 
                and call the single way method for search
            **/
            int[] arr = { 2, 3, 4, 10, 40, 20, 34, 50 };
            int searchElement = 30;
            LinearSearch linearSearch = new LinearSearch();
            // int result = linearSearch.singleSearch(arr, searchElement);
            // if (result != -1)
            //     Console.WriteLine("Element is present at index "+ result);
            // else
            //     Console.WriteLine("Element is not present in array");

            /**  call the double way method for search
            **/
            int result = linearSearch.doubleSearch(arr, searchElement);
            if (result == -1)
                Console.WriteLine("Not found in Array with " + arr.Length/2 + " Attempt");
            else
                Console.WriteLine("Element found in Array at " + (result + 1) + " Position with "
                    + (result + 1) + " Attempt");


        }
    }
}
