// Задача 1: Напишите программу, которая на вход принимает 
//позиции элемента в двумерном массиве, и возвращает значение 
//этого элемента или же указание, что такого элемента нет.

using System.Globalization;

int [,] array = new int[4, 3];

void CreateArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 10);
        }    
    }
}


void PrintArray()
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}


void PrintNumbers()
{
    Console.WriteLine("Введите i ");
    int num = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите j ");
    int num1 = Convert.ToInt32(Console.ReadLine());
    if(num1 >= array.GetLength(1) || num >= array.GetLength(0))
    {
        Console.Write("nety");       
    }
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i == num)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                if(j == num1)
                {
                Console.Write($"({i}, {j}) = {array[i, j]}");
                }
            }  
        }
    }
}

CreateArray();
PrintArray();
PrintNumbers();
