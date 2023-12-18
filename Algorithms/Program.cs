using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Algorithms.QuickSort;

class Program
{
    static void Main(string[] args)
    {
       Dictionary<char,List<char>>  graph = new Dictionary<char, List<char>>();

        graph['A'] = new List<char> { 'C', 'B' };
        graph['B'] = new List<char> { 'D'};
        graph['C'] = new List<char> { 'E' };
        graph['D'] = new List<char> { 'F'};
        graph['E'] = new List<char> {};
        graph['F'] = new List<char> {};

        Console.WriteLine("DFS: ");
        Graph.DepthFirstSearch(graph, 'A'); // ABDFCE

        Console.WriteLine("BFS: ");
        Graph.BreadthFirstSearch(graph, 'A'); // ACBEDF
    }
}