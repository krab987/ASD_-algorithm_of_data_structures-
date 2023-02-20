
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;



while (true)
{
    try
    {
        string[] first = new string[100];
        string[] second = new string[100];
        string str = "";

        StreamReader file = new StreamReader("Input.txt");
        str = file.ReadLine();
        first = str.Split(',');
        str = file.ReadLine();
        second = str.Split(',');

        //Console.Write("\n ----- \n");

        //int firstIndex = 0;
        //EasyArrayList easyArrayList = new EasyArrayList();
        //for (int i = 0; i < second.Length; i++)
        //{
        //    EasyQueue easyQueue = new EasyQueue();
        //    while(firstIndex < first.Length)
        //    {
        //        firstIndex++;
        //        easyQueue.Enqueue(Convert.ToInt32(first[firstIndex]));
        //        if (Convert.ToInt32(second[i]) == firstIndex)
        //        {
        //            break;
        //        }
        //    }
        //    easyArrayList.AddEl(easyQueue);
        //}

        //Console.WriteLine(easyArrayList.ToString());
        //break;
    }
    catch (Exception ex)
    {
        Console.WriteLine("\nInvalid input!!!");
        Console.WriteLine(ex);
    }
}
