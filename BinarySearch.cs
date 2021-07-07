using System;
namespace Algorithms{

    class BinarySearch{
        public void binarySearch(int[] arr, int searchElement){
            int left = 0;
            int right = arr.Length - 1;
            bool isTrue = false;
            while(left <= right){
                
                int mid = left + (right - left)/2;
                Console.WriteLine("Mid = "+mid);
                if(arr[mid] == searchElement){
                    Console.WriteLine("Element found at index " + mid);
                    isTrue = true;
                    break;
                }
                if(searchElement > arr[mid])
                    left = mid + 1;
                else
                    right = mid - 1;
                
            }

            if(!isTrue){
                Console.WriteLine("Element not found.");
            }
        }
    }
}