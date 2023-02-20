using System;
using System.Collections.Generic;

namespace Lab_6
{
    class Program
    {
        public static void Main()
        {
           // RSort ob = new RSort();
            int choose = 1;
            do
            {
                Console.WriteLine("Input size of Array");
                int n = Convert.ToInt32(Console.ReadLine());
                int[] mas = new int[n];

                Random rand = new Random();
                for (int i = 0; i < n; i++)
                {
                    mas[i] = rand.Next(1000);
                    Console.WriteLine(mas[i]);
                }

                int[][] matr = new int[n][];

                int indRow = 0,indCol = 0;
                foreach(int el in mas)
                {
                    indRow = el % 10;
                    matr[indRow][indCol] = el;
                    indCol++;
                }



                for(int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.WriteLine(matr[i][j].ToString());
                    }
                }
                    

                
                




                //Console.WriteLine("Your Array is");
                //ob.printArray(mas);
                //ob.sort(mas);
                //Console.WriteLine("Sorted array is");
                //ob.printArray(mas);


                Console.WriteLine("\n" + "Do you want to continue?(1 - yes; 2 - no)");
                choose = Convert.ToInt32(Console.ReadLine());
            } while (choose == 1);
        }
    }
}

