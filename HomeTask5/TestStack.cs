using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask5
{
    class TestStack
    {
        public void TestTheStack()
        {
            var newStack = new Stack(3);
            newStack.PrintStack();

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(5);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(6);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(7);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(8);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(9);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(10);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            newStack.Push(11);
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Peek());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");

            Console.WriteLine(newStack.Pop());
            newStack.PrintStack();
            Console.WriteLine("-----------------");
        }
    }
}
