using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] arrayForBubbleSorting = new int[] { 4, 3, 2, 1, 6, 5 };
            int[] arrayForInsertionSorting = (int[])arrayForBubbleSorting.Clone();

            var TestBubble = new BubbleSorter(arrayForBubbleSorting);

            
            TestBubble.Sort();

            var TestInsertion = new InsertionSorter(arrayForInsertionSorting);

            TestInsertion.Sort();



            
            var newTestQueue = new TestQueue();
            newTestQueue.TestTheQueue();

            
            var newTestStack = new TestStack();
            newTestStack.TestTheStack();
            

            Console.ReadLine();

        }
        
    }    
}
