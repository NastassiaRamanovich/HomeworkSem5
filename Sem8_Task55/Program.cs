// Задача 55: Задайте двумерный массив. Напишите программу, 
// которая заменяет строки на столбцы. В случае, если это невозможно, 
// программа должна вывести сообщение для пользователя.

int[,] array = new int[4, 5];

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(-10, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

int[,] array2 = FillArray(array);

Console.WriteLine("---------------");


void PrintArray(int[,] array){
    if (array.GetLength(0) != array.GetLength(1))
    {
        Console.WriteLine("Невозможно перевернуть массив");
    }
    else
    for (int j = 0; j < array.GetLength(0); j++)
    {
        for (int i = 0; i < array.GetLength(1); i++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
}

PrintArray(array2);

