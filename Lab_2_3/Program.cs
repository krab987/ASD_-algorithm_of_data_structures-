
using Lab_2_3;
using System.Collections;


int count_el = InputCountEl();

var myQueue = new EasyQueue<int>(count_el); // об'явив чергу
Console.WriteLine($" push_el = {count_el} ");
int menuIndex = 0;

while (true)
{
    try
    {
        Console.WriteLine("Menu.: ");
        for (int i = 0; i <= (int)Menu.Exit; i++)
        {
            Console.WriteLine(i + " - " + (Menu)i);
        }

        menuIndex = Convert.ToInt32(Console.ReadLine());
        switch (menuIndex)
        {
            case 0:
                AddElement(myQueue);
                break;
            case 1:
                Console.WriteLine("Inf in queue");
                Console.WriteLine(myQueue.ToString()); //  вивід
                //Console.WriteLine(MyQueue.Average()); // вивід сер ариф
                break;
            case 2:
                DelElement(myQueue);
                break;
            case 3:
                Environment.Exit(0);
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}
static int InputCountEl()
{
    int count_el = 1;
    while (true)
    {
        try
        {
            Console.WriteLine("Input count of el in queue");
            count_el = int.Parse(Console.ReadLine());
            if (count_el <= 0)
                throw new Exception("It can`t be <= 0");
            break;
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }

    return count_el;
}

void AddElement(EasyQueue<int> myQueue)
{
    Console.WriteLine("Input count of el to add");
    int push_el = int.Parse(Console.ReadLine());
    if (push_el < 0)
        throw new Exception("count of el to add cant be negative");

    Console.WriteLine($" push_el = {push_el} ");
    Random rand = new Random(); // створив рандом

    for (int i = 0; i < push_el; i++) // створив деяку ксть рандомних символів
    {
        myQueue.EnQueue(78);
        //Elem el = new Elem((char)rand.Next(0x0410, 0x44F)); // symbol from a to z

        //MyQueue.EnQueue((char)rand.Next(0x0410, 0x44F));
    }
}

void DelElement(EasyQueue<int> myQueue)
{
    Console.WriteLine("Input count of el to del");
    int del_el = int.Parse(Console.ReadLine()); // к-сть ел для видалення

    if (del_el < 0)
        throw new Exception("count of el to delete cant be negative");

    for (int i = 0; i < del_el; i++) // last in first out - видаляємо зверху кількість ел
    {
        if (!(myQueue.DeQueue())) // якщо нема що видалить
        {
            Console.WriteLine("Queue is empty");
            break;
        }
    }
}