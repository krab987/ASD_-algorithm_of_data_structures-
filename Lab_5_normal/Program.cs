
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Lab_5_normal;

StreamReader file = new StreamReader("Input.txt");
while (true)
{
    try
    {
        string[] first = new string[0];
        string[] second = new string[0];
        string str = "";

        
        str = file.ReadLine();
        first = str.Split(',');
        str = file.ReadLine();
        second = str.Split(',');

        int firstIndex = 0;
        EasyArrayList easyArrayList = new EasyArrayList();
        foreach (string elSec in second)
        {
            EasyQueue easyQueue = new EasyQueue();
            while (firstIndex < first.Length)
            {
                easyQueue.Enqueue(Convert.ToInt32(first[firstIndex]));
                if (Convert.ToInt32(elSec) == firstIndex)
                {
                    firstIndex++;
                    break;
                }
                firstIndex++;
            }
            easyArrayList.AddEl(easyQueue);
        }
        
        Console.WriteLine(easyArrayList.ToString());
        //break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("Error: "+ex.Message);
    }
}

//namespace lab_5_normal
//{
//    class Program
//    {
//        static void Main(string[] args)
//        {
            
            
//        }
//    }
//}

//for (int i = 0; i < second.Length; i++)
//{
//    EasyQueue easyQueue = new EasyQueue();
//    while (firstIndex < first.Length)
//    {
//        for(int p = 0; p < second.Length; p++)
//        {
//            Console.WriteLine(second[p]);

//        }
//        //foreach (string el in second)
//        //{
//        //    Console.WriteLine(el);
//        //}
//        //Console.WriteLine("fist ["+ firstIndex+"]= "+first[firstIndex]);
//        Console.WriteLine("sec = " +second[i]);

//        easyQueue.Enqueue(Convert.ToInt32(first[firstIndex]));
//        if (second[i] == Convert.ToString(firstIndex))
//        {
//            firstIndex++;
//            break;
//        }
//        firstIndex++;
//    }
//    //Console.WriteLine("------");
//    easyArrayList.AddEl(easyQueue);
//}
