
using Lab_3_Console.Module;
using Lab_3_Console;


int indexList = -1;
EasyArrayList list = new EasyArrayList(); //list of lists

while (indexList > 3)
{
    EasyList subList = new EasyList(++indexList); // create sublist

    Console.WriteLine("Input count el to add ");
    int pushEl = int.Parse(Console.ReadLine());


    for (int i = 0; i < pushEl; i++)
    {
        Random rand = new Random();
        Element el = new Element(rand.Next(10), indexList.ToString() + rand.Next(10).ToString());
        subList.AddEl(el);
    } // add el to aublist
    list.AddEl(subList); //add sublist to list

    Console.WriteLine(list.ToString()); 
}

list.RemoveEl(1, 2);


