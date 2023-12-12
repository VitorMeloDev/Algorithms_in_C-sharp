using System;
using System.Collections.Generic;

class Graph
{
    private int V; // Número de vértices
    private List<int>[] adj; // Lista de adjacências

    public Graph(int v)
    {
        V = v;
        adj = new List<int>[v];
        for (int i = 0; i < v; ++i)
            adj[i] = new List<int>();
    }

    public void AddEdge(int v, int w)
    {
        adj[v].Add(w);
    }

    public List<int> BFS(int s, int target)
    {
        bool[] visited = new bool[V];
        int[] parent = new int[V];
        for (int i = 0; i < V; ++i)
        {
            visited[i] = false;
            parent[i] = -1;
        }

        Queue<int> queue = new Queue<int>();
        visited[s] = true;
        queue.Enqueue(s);

        while (queue.Count != 0)
        {
            int u = queue.Dequeue();

            foreach (int v in adj[u])
            {
                if (!visited[v])
                {
                    visited[v] = true;
                    queue.Enqueue(v);
                    parent[v] = u;

                    if (v == target)
                        return GetPath(parent, s, v);
                }
            }
        }

        return null; // Se o alvo não for alcançado
    }

    private List<int> GetPath(int[] parent, int s, int v)
    {
        List<int> path = new List<int>();
        for (int i = v; i != s; i = parent[i])
            path.Add(i);
        path.Add(s);
        path.Reverse();
        return path;
    }
}