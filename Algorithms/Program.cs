﻿using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Algorithms.QuickSort;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<char, List<char>> graph = new Dictionary<char, List<char>>();

        graph['A'] = new List<char> {'B', 'C' };
        graph['B'] = new List<char> {'D', 'E' };
        graph['C'] = new List<char> {'F' , 'A' };
        graph['D'] = new List<char> {'B', 'E' };
        graph['E'] = new List<char> {'B','D','F'};
        graph['F'] = new List<char> {'C', 'E'};

        Console.WriteLine("Depth First Search: ");
        Graph.DepthFirstSearch(graph, 'A');

        Console.WriteLine("Breadth First Search: ");
        Graph.BreadthFirstSearch(graph, 'A');

        Console.WriteLine("Has Path between B and F? ");
        Graph.HasPath2(graph, 'B', 'F');
    }
}