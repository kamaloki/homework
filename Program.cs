// Задача 4*(не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, на пересечении 
//которых расположен наименьший элемент массива. Под удалением понимается 
//создание нового двумерного массива без строки и столбца

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

void PrintNewArray()
{
    int min = int.MaxValue;
    int newI=0;
    int newJ=0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if(array[i, j] < min)
            {
                min = array[i,j];
                newI = i;
                newJ = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
    {
        if(i != newI)
        {
            for (int j = 0; j < array.GetLength(1); j++){
                if(j != newJ)
                {
                    Console.Write(array[i, j] + " ");
                }
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

CreateArray();
PrintArray();
PrintNewArray();
