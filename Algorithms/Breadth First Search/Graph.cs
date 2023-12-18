using System;
using System.Collections.Generic;

class Graph
{
    public static void DepthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Stack<char> stack = new Stack<char>();
        stack.Push(source);

        while (stack.Count > 0)
        {
            char current = stack.Pop();
            Console.WriteLine(current);

            foreach (char neighbor in graph[current])
            {
                stack.Push(neighbor);
            }
        }
    }

    public static void BreadthFirstSearch(Dictionary<char, List<char>> graph, char source)
    {
        Queue<char> queue = new Queue<char>();
        queue.Enqueue(source);

        while (queue.Count > 0)
        {
            char current = queue.Dequeue();
            Console.WriteLine(current);

            foreach (char neighbor in graph[current])
            {
                queue.Enqueue(neighbor);
            }
        }
    }
}