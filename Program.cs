using System;

namespace Linear_search
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the size of the array");
            int size = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[100];

            Console.WriteLine("Enter elements to the array");

            for(int i=0; i<size; i++)
            {
                Console.WriteLine("Enter element to index of : " + i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            int key;

            Console.WriteLine("Enter a search key : ");
            key = Convert.ToInt32(Console.ReadLine());

            int result = linearSearch(key, arr);

            if (result == -1)
                Console.WriteLine("Entered search key is unabled to find inside the array");
            else
                Console.WriteLine("Entered search key is found at the index of : " + result);
        }

        static int linearSearch(int key, int[] arr)
        {
            foreach(int i in arr)
            {
                if (key == arr[i])
                    return i;
            }

            return -1;
        }
    }
}
