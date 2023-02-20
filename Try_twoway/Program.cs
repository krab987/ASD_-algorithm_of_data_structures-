using Lab_1;

Console.WriteLine("Input kol el in stack");
int count_el = int.Parse(Console.ReadLine());

Stack MyStack = new Stack(count_el);

do
{
    Console.WriteLine("Input kol el to add");
    int push_el = int.Parse(Console.ReadLine());

    Random rand = new Random();

    for (int i = 0; i < push_el; i++)
    {
        Elem el = new Elem(rand.Next(0, 25));
        if (!(MyStack.Push(el)))
        {
            Console.WriteLine("Stack is full");
            break;
        }
    }
    Console.WriteLine("Inf in stack");
    Console.WriteLine(MyStack.ToString());
    Console.WriteLine("Input kol elem to del");
    int del_el = int.Parse(Console.ReadLine());

    for (int i = 0; i < del_el; i++)
    {
        if (!(MyStack.Pop()))
        {
            Console.WriteLine("Stack is empty");
            break;
        }
    }
    Console.WriteLine("Inf in Stack");
    Console.WriteLine(MyStack.ToString());

} while (true);
