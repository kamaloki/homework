// Задача 2: Задайте двумерный массив. Напишите программу, 
//которая поменяет местами первую и последнюю строку массива.

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


void PrintNumbers()
{
    int newNum;
    int i = 0;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        newNum = array[i,j];
        array[i,j] = array[array.GetLength(0) - 1, j];
        array[array.GetLength(0) - 1, j] = newNum;
    }
}

CreateArray();
PrintArray();
PrintNumbers();
PrintArray();

