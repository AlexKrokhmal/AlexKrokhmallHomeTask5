using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class CircularBufferQueue
    {
        private int[] arrayForQueue;
        private int queueHead;
        private int queueTail;
        private int numberOfUtilizedQueueElements;

        
        public CircularBufferQueue(int queueSize)
        {
            arrayForQueue = new int[queueSize];
            queueHead = 0;
            queueTail = 0;
            numberOfUtilizedQueueElements = 0;
        }


        public int Dequeue()
        {
            int returnValue = 0;

            if (!IsEmpty())
            {
                returnValue = arrayForQueue[queueHead];
                arrayForQueue[queueHead] = 0;
                queueHead = WhatIsNextCellIndexForTailOrHead(queueHead);
                numberOfUtilizedQueueElements--;                
            }
            else
            {
                Console.WriteLine("Cannot dequeue from the queue");
                returnValue = 0;
            }

            return returnValue;
        }
        
        public void Enqueue(int valueToBeAddedToQueue)
        {
            if (!IsFull())
            {
                arrayForQueue[queueTail] = valueToBeAddedToQueue;
                queueTail = WhatIsNextCellIndexForTailOrHead(queueTail);
                numberOfUtilizedQueueElements++;
            }
            else
            {
                Console.WriteLine("Cannot enqueue the queue.");
            }
        }
        
        public bool IsFull()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == arrayForQueue.Length)
            {
                Console.WriteLine("The queue is full.");
                returnValue = true;
            }

            return returnValue;
        }
        
        private int WhatIsNextCellIndexForTailOrHead(int currentIndex)
        {
            int returnValue = 0;

            if (currentIndex < arrayForQueue.Length - 1)
            {
                returnValue = currentIndex + 1;
            }

            return returnValue;
        }
        
        public bool IsEmpty()
        {
            bool returnValue = false;

            if (numberOfUtilizedQueueElements == 0)
            {
                Console.WriteLine("The queue is empty.");
                returnValue = true;
            }

            return returnValue;
        }
        
        public void PrintQueue()
        {
            Console.WriteLine();

            foreach (int i in arrayForQueue)
            {
                Console.Write("{0}   ", i);
            }
            Console.WriteLine("\n head: {0}\n tail: {1}\n count: {2}", queueHead, queueTail, numberOfUtilizedQueueElements);
            Console.WriteLine();
        }
    }        
}
