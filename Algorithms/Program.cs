using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Algorithms.Book_Exercises;

class Program
{
    static void Main(string[] args)
    {
        int[] list = { 7, 3, 25, 9, 5, 2, 8, 4, 6 };

        Console.WriteLine("List Sum: " + Chapter4Exercises.Sum(list));
        
        Console.WriteLine(Chapter4Exercises.TotalItens(list) + " Itens in the list");

        Console.WriteLine("Highest Value in the list: " + Chapter4Exercises.HighestValue(list));
    }
}