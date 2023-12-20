// Задача 3: Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.

using System.ComponentModel.DataAnnotations;

int [,] array = new int[5, 4];

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

void PrintMinSum()
{
    int min = int.MaxValue;
    int index = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int summa = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            summa += array[i, j];
        }
        if(summa < min)
        {
            index = i;
            min = summa;
        }
    }
    Console.Write($"min stroka {index}");
}

CreateArray();
PrintArray();
PrintMinSum();


