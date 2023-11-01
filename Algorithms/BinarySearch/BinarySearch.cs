using System.Security.Cryptography;

namespace System
{
    class BinarySearch
    {
        public static void Binary_Search(int[] list, int obj)
        {
            int low = 0;
            int high = list.Length - 1;

            while(low <= high)
            {
                int mid = (low + high) / 2;
                int getMiddle = list[mid];

                if(getMiddle == obj)
                {
                    Console.WriteLine("The obj exist! In position: " + mid);
                    return;
                }

                if(getMiddle < obj)
                {
                    low = mid + 1;
                }
                else
                {
                    high = mid - 1;
                }
            }

            Console.WriteLine("The obj doesn't exist!");
        }

    }
}
