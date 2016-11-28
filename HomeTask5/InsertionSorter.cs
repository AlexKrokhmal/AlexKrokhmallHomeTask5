using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class InsertionSorter
    {
        private int[] array;


        public int[] Array
        {
            private set
            {
                if (value.Length > 0)
                {
                    array = value;
                }
                else
                {
                    Console.WriteLine("Error: cannot sort array with '0' elements.");
                }
            }

            get { return array; }
        }


        public InsertionSorter(int[] array)
        {
            Array = array;
        }

        public void Sort()
        {
            Console.WriteLine("\n\n***** Insetion Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            Print();

            for (int i = 1; i < array.Length; i++)
            {

                Console.WriteLine("\nIteration {0}:", i);
                Print();

                int j = i;

                while (j > 0 && array[j] < array[j - 1])
                {
                    Swap(j, j - 1);
                    j--;
                }
            }

            Console.WriteLine("\nThe result is:");
            Print();
        }
                
        public void Print()
        {
            foreach (int i in array)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine();
        }

        private void Swap(int firstIndexForSwap, int secondIndexForSwap)
        {
            //Test alternative method of swap with XOR, but is does not work
            //a ^= b ^= a ^= b
            //array[firstIndexForSwap] ^= array[secondIndexForSwap] ^= array[firstIndexForSwap] ^= array[secondIndexForSwap];

            int temp = 0;
            temp = array[firstIndexForSwap];
            array[firstIndexForSwap] = array[secondIndexForSwap];
            array[secondIndexForSwap] = temp;

        }

    }
}
