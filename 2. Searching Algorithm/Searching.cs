using System;
using System.Collections.Generic;
using System.Text;

namespace DataStructureAndAlgorithm._2._Searching_Algorithm
{
    public class Searching
    {
        public int Linersearch(int[] arr, int key)
        {
            int index = 0;
            var n = arr.Length - 1;
            while (index <= n)
            {
                if (arr[index] == key)
                    return index;
                index = index + 1;
            }
            return -1;
        }

        public int BinarySearch(int[] arr, int key)
        {
            int l = 0;
            int r = arr.Length - 1;

            while (l <= r) 
            {
                int mid = (l + r) / 2;

                if (arr[mid] == key)
                    return mid;

                else if (key > arr[mid])
                    l = mid+1;
                else
                    r = mid-1;
            }


            return -1;
        }

        public int RecursiveBinarySearch(int[] arr, int key, int left, int right)
        {

            if (left > right)
            {
                return -1;
            }
            else
            { 
                int mid = (left + right) / 2;
                if (arr[mid] == key)
                    return mid;
                else if (key > arr[mid])
                    return RecursiveBinarySearch(arr, key, mid + 1, right);
                else
                    return RecursiveBinarySearch(arr, key, left, mid - 1);
            }
        }
    }
}
