using System.Globalization;

namespace Algorithms.QuickSort
{
    class QuickSort
    {
        public static void Sort(int[] list, int left, int right)
        {
            if(left < right)
            {
                int pivot = Partition(list, left, right);

                Sort(list, left, pivot - 1);
                Sort(list, pivot + 1, right);
            }
        }

        static int Partition(int[] list, int left, int right)
        {
            int pivot = list[right];
            int i = left - 1;

            for(int j = left; j < right; j++)
            {
                if (list[j] < pivot)
                {
                    i++;
                    Swap(list, i,j);
                }
            }

            Swap(list, i + 1, right);
            return i + 1;
        }

        static void Swap(int[] list, int a, int b)
        {
            int x = list[a];
            list[a] = list[b];
            list[b] = x;
        }
    }
}
