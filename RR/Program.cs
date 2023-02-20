using System;
using System.Collections;
using System.Diagnostics;
namespace RR
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Default;
            Stopwatch time = new Stopwatch();

            Stack<int> stackInt = new Stack<int>();
            Stack stack = new Stack();
            EasyStack mystack = new EasyStack();

            int[] testCount = { 10000, 20000, 30000, 40000, 50000, 60000 };

            //my
            Console.WriteLine("Власний стек");

            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    mystack.Push(new Random().Next(),j);
                time.Stop();
                Console.WriteLine($"Додання {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    mystack.Pop();
                time.Stop();
                Console.WriteLine($"Видалення {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            Console.WriteLine(" ");


            //stack
            Console.WriteLine("Неузагальнений стек");

            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    stack.Push(new Random().Next());
                time.Stop();
                Console.WriteLine($"Додання {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    stack.Pop();
                time.Stop();
                Console.WriteLine($"Видалення {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            Console.WriteLine(" ");


            //stack<int>
            Console.WriteLine("Узагальнений стек");

            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    stackInt.Push(new Random().Next());
                time.Stop();
                Console.WriteLine($"Додання {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            for (int i = 0; i < testCount.Length; i++)
            {
                time.Start();
                for (int j = 0; j < testCount[i]; j++)
                    stackInt.Pop();
                time.Stop();
                Console.WriteLine($"Видалення {testCount[i]} елементів: {time.Elapsed.TotalMilliseconds} ms");
            }
            Console.WriteLine(" ");
        }
    }
}




