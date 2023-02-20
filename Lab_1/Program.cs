using Lab_1;

while (true)
{
    try
    {
        Console.WriteLine("Input count of el in stack");
        int count_el = int.Parse(Console.ReadLine());
        if (count_el <= 0)
            throw new Exception();

        Stack MyStack = new Stack(count_el); // об'явив стек

        Console.WriteLine("Input count of el to add");
        int push_el = int.Parse(Console.ReadLine());

        Random rand = new Random(); // створив рандом

        for (int i = 0; i < push_el; i++) // створив деяку ксть рандомних чисел
        {
            Elem el = new Elem(rand.Next(0, 25)); // елемент від 0 до 25
            MyStack.Push(el);
            if(MyStack.IsEmpty(el))
            {
                Console.WriteLine("Stack is empty");
            } 
        }
        Console.WriteLine("Inf in stack");
        Console.WriteLine(MyStack.ToString()); //  вивід
        Console.WriteLine(MyStack.Average()); // вивід сер ариф
        Console.WriteLine("Input count of el to del");
        int del_el = int.Parse(Console.ReadLine()); // к-сть ел для видалення

        for (int i = 0; i < del_el; i++) // last in first out - видаляємо зверху кількість ел
        {
            if (!(MyStack.Pop())) // якщо нема що видалить
            {
                Console.WriteLine("Stack is empty");
                break;
            }
        }
        Console.WriteLine("Inf in Stack");
        Console.WriteLine(MyStack.ToString()); // вивід
        Console.WriteLine(MyStack.Average()); // вивід сер ариф


        // break;брейка нема нескукнченний цикл

    }
    catch (FormatException)
    {
        Console.WriteLine("FormatException");
    }
    catch (ArgumentOutOfRangeException)
    {
        Console.WriteLine("ArgumentOutOfRangeException");
    }
    catch (OutOfMemoryException)
    {
        Console.WriteLine("OutOfMemoryException");
    }
    catch (Exception)
    {
        Console.WriteLine("Exception");
    }
}