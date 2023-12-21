using System;
using System.Collections;
using System.Collections.Generic;

class Graph
{
    // DFS with recursion
    public static void DepthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Console.WriteLine(source);

        foreach (char neighbor in graph[source])
        {
            DepthFirstSearch(graph, neighbor);
        }
    }

    // DFS with Stack
    public static void DepthFirstSearch2(Dictionary<char, List<char>> graph, char source)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);

        while(stack.Count > 0)
        {
            char current = stack.Pop();
            Console.WriteLine(current);

            foreach(char neighbor in graph[current])
            {
                stack.Push(neighbor);
            }
        }
    }

    // BFS
    public static void BreadthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue(source);

        while(queue.Count > 0)
        {
            char current = queue.Dequeue();
            Console.WriteLine(current);

            foreach(char neighbor in graph[current])
            {
                queue.Enqueue(neighbor);
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

        while(queue.Count > 0)
        {
            char current = queue.Dequeue();

            if (current == destiny) { Console.WriteLine("Has Path!"); return; }

            foreach(char neighbor in graph[current])
            {
                queue.Enqueue(neighbor);
            }
        }

        Console.WriteLine("Hasn't path!");
        return;
    }
}