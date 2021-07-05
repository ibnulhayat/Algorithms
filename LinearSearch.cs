using System;

namespace Algorithms
{

    class LinearSearch
    {
        public int singleSearch(int[] arr, int search_Element)
        {
            int len = arr.Length;
            for (int i = 0; i < len; i++)
            {
                if (arr[i] == search_Element) return i;
            }
            return -1;
        }

        public void doubleSearch(int[] arr, int search_Element)
        {
            int length = arr.Length;
            int left = 0;
            int right = length - 1;
            int position = -1;
            for (left = 0; left <= right;)
            {
                // searching in left side
                if (arr[left] == search_Element)
                {
                    position = left;
                    Console.WriteLine("Element found in Array at " + (position + 1) + " Position with "
                        + (left + 1) + " Attempt");
                    break;
                }
                // searching in right side
                if (arr[right] == search_Element)
                {
                    position = right;
                    Console.WriteLine("Element found in Array at " + (position + 1) + " Position with "
                        + (right + 1) + " Attempt");
                    break;
                }
                left++;
                right--;
                // if element not found
                if (position == -1)
                    Console.WriteLine("Not found in Array with "+ left + " Attempt");
            }
        }
    }
}

