using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Algorithms.QuickSort;

class Program
{
    static void Main(string[] args)
    {
        int[] list = { 7, 3, 25, 9, 5, 2, 8, 4, 6 };

        Console.WriteLine("QuickSort List: ");
        SelectionSort.printList(list);
    }
}