namespace System
{
    class SelectionSort
    {
        public static void Sort(int[] list, bool bigToSmall)
        {
            int count = list.Length;

            for(int i = 0; i < count; i++)
            {
                for(int j = i +1; j < count; j++)
                {
                    if (bigToSmall)
                    {
                        if (list[j] > list[i]) { Swap(list, j, i); }
                    }
                    else
                    {
                        if (list[j] < list[i]) { Swap(list, j, i); }
                    }
                }
            }
        }

        static void Swap(int[] list, int a, int b)
        {
            int x = list[a];
            list[a] = list[b];
            list[b] = x;
        }

        public static void printList(int[] list)
        {
            Console.Write("[ ");
            for (int i = 0; i < list.Length; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine(" ]");
        }
    }
}
