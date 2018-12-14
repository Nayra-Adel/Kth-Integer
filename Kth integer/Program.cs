using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kth_integer
{
    class Program
    {
        static void Main(string[] args)
        {
          
           int i, j, k, size;
  
           Console.Write("Input the size of array : ");
	       try
           {
            size = Convert.ToInt32(Console.ReadLine());
           }
           catch (FormatException)
            {
                Console.Write("Are you joke me!! Format Exception");
                return;
            }

            int[] arr = new int[size];

            /* Stored values into the array*/
            Console.Write("Input {0} elements in the array :\n", size);
            for (i = 0; i < size; ++i)
            {

                Console.Write("element - {0} : ", i);
                try
                {
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.Write("Are you joke me!! Format Exception");
                    return;
                }
            }

            /* take the Kth integer*/
            Console.Write("Input the Kth integer : ");
            try
            {
                k = Convert.ToInt32(Console.ReadLine());
            }
            catch (FormatException)
            {
                Console.Write("Are you joke me!! Format Exception");
                return;
            }

            /* sort the array */
            int temp;
            for (i = 0; i < size; ++i)
            {
                for (j = 0; j < size - 1; ++j)
                {
                    if (arr[j] < arr[j + 1])
                    {
                        temp = arr[j + 1];
                        arr[j + 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }

            /* get the Kth from the array */
            try{
                Console.Write(arr[k - 1]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.Write("Are you joke me ;) Index Out Of Range Exception");
            }
        
        Console.ReadKey(true);
       }
    }
}