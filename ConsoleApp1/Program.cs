﻿using System;

namespace ConsoleApp1
{
    class Program
    {
       
            private static void Main(string[] args)
            {
                {
                    Console.Clear();
                    Console.WriteLine(" имеющегося массива строк формирует новый массив из строк, длина которых меньше, либо равна 3 символам");
                    Console.WriteLine("Введите массив. для разделения элементов массива используйте ;");
                    string[] array = Console.ReadLine()!.Split(';');
                    int Uslovie = 3;
                PrintM(array);
                   
                   int counts = 0;

                   for ( int i=0;i<array.Length;i++)
                    {
                        if (array[i].Length >= Uslovie)
                        {counts++;}
                    }
                    if (counts > 0)
                    { string[] result = new string[counts];
                     counts = 0;
                    for ( int i=0;i<array.Length;i++)
                    {
                        if (array[i].Length >= Uslovie)
                        {result[counts] = array[i];
                        counts++;}
                    }
                     Console.WriteLine("результат");
                    PrintM(result);}
                    else 
                    {Console.WriteLine("нет элементов удовлетворяющих условиям");}
                }

            void PrintM(string[] matrix)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {             
                    if (!(string.IsNullOrEmpty(matrix[i])) )    
                   { Console.Write($"{matrix[i]} \t");
                    Console.WriteLine();}
                }
            }


        }
        }

    
}
