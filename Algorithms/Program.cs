using System;

class Program
{
    static void Main(string[] args)
    {
        int[] list = { 2, 3, 5, 6, 7, 10, 11 };

        BinarySearch.Binary_Search(list, 6);
        BinarySearch.Binary_Search(list, 1);
    }
}