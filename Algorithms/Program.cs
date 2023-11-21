using System;
using System.Globalization;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int[] list = { 7, 3, 25, 9, 5, 2, 8, 4, 6 };

        Console.WriteLine("Lista Ordenada do Maior para Menor: ");
        SelectionSort.Sort(list, true);
        SelectionSort.printList(list);

        Console.WriteLine("Lista Ordenada do Menor para o Maior: ");
        SelectionSort.Sort(list,false);
        SelectionSort.printList(list);
    }
}