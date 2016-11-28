using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    //Allows to test the CircularBufferQueue class and methods
    class TestQueue
    {
        
        //Method that contains set of actions to test the Queue with lenght 5
        public void TestTheQueue()
        {
            var newQueue = new CircularBufferQueue(5);

            Console.WriteLine("-----------------\n");
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            int dequeuedValue = 0;
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(1);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(2);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(3);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(4);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(5);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(6);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(7);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(8);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(9);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to dequeue");
            dequeuedValue = newQueue.Dequeue();
            Console.WriteLine(dequeuedValue);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");

            Console.WriteLine("Try to enqueue");
            newQueue.Enqueue(10);
            newQueue.PrintQueue();
            Console.WriteLine("-----------------\n");
            
        }
    }
}
