
using Try;

class Program
{
    static void Main (string[] args)
    {
        Console.WriteLine("Input kol el in stack");
        int count_el = int.Parse(Console.ReadLine());

        Stack MyStack = new Stack(count_el);

        int k = 10;
        do
        {
            Console.WriteLine("Input kol el to add");
            int push_el = int.Parse(Console.ReadLine());

            for (int i = 0; i < push_el; i++)
            {
                Elem el = new Elem((i + 1) * k);
                if (!(MyStack.Push(el)))
                {
                    Console.WriteLine("Stack is full");
                    break;
                }
                Console.WriteLine("Inf in stack");
                Console.WriteLine(MyStack.ToString());
                Console.WriteLine("Input kol elem to del");

                int del_el = int.Parse(Console.ReadLine());
                for (int j = 0; j < del_el; j++)
                {
                    if (!(MyStack.Pop()))
                    {
                        Console.WriteLine("Queue is empty");
                        break;
                    }
                }
                Console.WriteLine("Inf in queue");
                Console.WriteLine(MyStack.ToString());

            }

        } while (true);

    }
}

