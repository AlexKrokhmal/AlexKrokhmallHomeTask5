using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class BubbleSorter
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


        public BubbleSorter(int [] array)
            {
            Array = array;
            }

        public void Sort()
        {
            bool swapWasDone = false;

            Console.WriteLine("***** Bubble Sorting *****\n");
            Console.WriteLine("Incoming array before sorting");
            Print();

            int iterationCounter = 1;

            do
            {
                swapWasDone = false;

                Console.WriteLine("Iteration {0}:", iterationCounter);

                for (int i = 0; i < array.Length - 1; i++)
                {
                    if (array[i] > array[i + 1])
                    {
                        Swap(i, i + 1);
                        swapWasDone = true;
                    }
                    Console.WriteLine("Step {0} result:", i + 1);
                    Print();
                }

                iterationCounter++;

            } while (swapWasDone);

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
            int temp = 0;
            temp = array[firstIndexForSwap];
            array[firstIndexForSwap] = array[secondIndexForSwap];
            array[secondIndexForSwap] = temp;            
        }
    }


}

