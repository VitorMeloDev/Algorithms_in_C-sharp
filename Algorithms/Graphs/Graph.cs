using System;
using System.Collections;
using System.Collections.Generic;

class Graph
{
    // DFS with undirected path
    public static void DepthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);
        List<char> visited = new List<char>();

        while(stack.Count > 0)
        {
            char current = stack.Pop();
            if(!visited.Contains(current)) { visited.Add(current); }

            Console.WriteLine(current);

            foreach(char neighbor in graph[current])
            {
                if (!visited.Contains(neighbor)) 
                { 
                    stack.Push(neighbor); visited.Add(neighbor); 
                }
            }
        }
    }

    // BFS with undirected path
    public static void BreadthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue(source);
        List<char> visited = new List<char>();

        while(queue.Count > 0)
        {
            char current = queue.Dequeue();
            if(!visited.Contains(current)) { visited.Add(current); }

            Console.WriteLine(current);

            foreach(char neighbor in graph[current])
            {
                if (!visited.Contains(neighbor)) { queue.Enqueue(neighbor); visited.Add(neighbor); }
            }
        }
    }


    // Has Path with recursion
    public static void HasPath(Dictionary<char, List<char>> graph, char source, char destiny)
    {
        if(source == destiny)
        {
            Console.WriteLine("Has Path!");
            return;
        }
        else
        {
            foreach(char neighbor in graph[source])
            {
                HasPath(graph, neighbor, destiny);
            }
        }
    }

    public static void HasPath2(Dictionary<char, List<char>> graph, char source, char destiny)
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue(source);
        List<char> visited = new List<char>();

        while(queue.Count > 0)
        {
            char current = queue.Dequeue();

            if (current == destiny) { Console.WriteLine("Has Path!"); return; }
            
            if(!visited.Contains(current)) { visited.Add(current);}

            foreach(char neighbor in graph[current])
            {
                if (!visited.Contains(neighbor))
                {
                    queue.Enqueue(neighbor);
                    visited.Add(neighbor);
                }
            }
        }

        Console.WriteLine("Hasn't path!");
        return;
    }
}