using lab_5.Module;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
namespace lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader file = new StreamReader("Input.txt");
            while (true)
            {
                try
                {
                    string[] first = new string[50];
                    string[] second = new string[50];
                    string str = "";

                    str = file.ReadLine();
                    first = str.Split(',');
                    str = file.ReadLine();
                    second = str.Split(',');

                    Console.Write("\n ----- \n");

                    EasyStack easyStack = new EasyStack();
                    for (int i = 0; i < second.Length; i++)
                    {
                        EasyQueue easyQueue = new EasyQueue();
                        for (int j = 0; j < first.Length; j++)
                        {
                            easyQueue.Enqueue(Convert.ToInt32(first[j]));

                        }
                        easyStack.Push(Convert.ToInt32(second[i]), easyQueue);
                    }

                    //for (int i = 0; i < s.Length; i++)
                    //{
                    //    if (s[i] == "0") { Console.Write(s[i] + "| "); vertex++; }
                    //    else Console.Write(s[i] + ", ");
                    //}
                    //for (int i = 0, v = 1; i < s.Length; i++, v++)
                    //{
                    //    while (s[i] != "0")
                    //    {
                    //        if (int.TryParse(s[i], out f))
                    //        {
                    //            if (Convert.ToInt32(s[i]) > vertex) throw new Exception($"s[{i}]={s[i]} is NOT exist!!!");
                    //            easyQueue.EnQueue(Convert.ToInt32(s[i]));
                    //            i++;
                    //        }
                    //        else throw new Exception($"s[{i}]={s[i]} is NOT number!!!");
                    //    }
                    //    easyStack.Push(v, easyQueue);
                    //    easyQueue = new easyQueue();


                    //    
                    //}
                    Console.WriteLine(easyStack.StringTop());
                    break;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("\nInvalid input!!!");
                    Console.WriteLine(ex);
                }
            }
        }
    }
}
