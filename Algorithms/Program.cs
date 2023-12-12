using System;
using System.Globalization;
using System.Runtime.InteropServices;
using Algorithms.QuickSort;

class Program
{
    static void Main(string[] args)
    {
        Graph g = new Graph(4);
        g.AddEdge(0, 1);
        g.AddEdge(0, 2);
        g.AddEdge(1, 2);
        g.AddEdge(2, 0);
        g.AddEdge(2, 3);
        g.AddEdge(3, 3);

        int source = 0;
        int target = 3;

        List<int> path = g.BFS(source, target);

        if (path != null)
        {
            Console.Write($"Caminho de {source} para {target}: ");
            foreach (int vertex in path)
                Console.Write($"{vertex} ");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine($"Não há caminho de {source} para {target}");
        }
    }
}