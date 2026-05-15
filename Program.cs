

using DataStructureAndAlgorithm._2._Searching_Algorithm;

Searching search = new Searching();


int[] arr = [12,23, 33, 44, 66, 99];
int key = 98;

//var index = search.Linersearch(arr, key);

//var index = search.BinarySearch(arr, key);

var index = search.RecursiveBinarySearch(arr, key, 0, arr.Length - 1);

Console.WriteLine(index);
Console.ReadKey();