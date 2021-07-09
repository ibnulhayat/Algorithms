using System;

namespace Algorithms{
    
    class JumpSearch{

        public int jumpSearch(int[] arr, int searchElement){
            int len = arr.Length;
            int jump = (int)Math.Sqrt(len);
            int prev = 0;
            while(arr[Math.Min(jump, len)-1] < searchElement){
                Console.WriteLine("Jump = "+jump);
                prev = jump;
                jump += jump;
                if(prev >= len)
                    return -1;
            }

            while( prev < jump){
                if(arr[prev] == searchElement)
                    return prev;
                prev++;
            }

            return -1;
        }
    }
}