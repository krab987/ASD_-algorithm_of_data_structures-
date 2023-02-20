
using Lab_2;
using Lab_2.Classes;
using System.Collections;


int count_el = InputCountEl();

EasyQueue myQueue = new EasyQueue(count_el); // об'явив чергу
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
                DelElement(myQueue);              
                break;
            case 2:
                Environment.Exit(0);
                break;
        }
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);
    }
}  //menu
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

void AddElement(EasyQueue myQueue)
{
    Console.WriteLine("Input count of el to add");
    int push_el = int.Parse(Console.ReadLine());
    if (push_el < 0)
        throw new Exception("count of el to add cant be negative");
    Random rand = new Random(); // connect class random

    for (int i = 0; i < push_el; i++) // 
    {
        Item element = new Item(Convert.ToChar(rand.Next('a', 'a' + 26)));// rand symbol from a to z
        myQueue.EnQueue(element);

    }
    Console.WriteLine("Inf in queue");
    Console.WriteLine(myQueue.ToString()); //  вивід
}

void DelElement(EasyQueue myQueue)
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
    Console.WriteLine("Inf in queue");
    Console.WriteLine(myQueue.ToString()); //  вивід

}