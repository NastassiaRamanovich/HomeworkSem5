// Задача 56: Задайте прямоугольный двумерный массив.
//  Напишите программу, которая будет находить строку с 
//  наименьшей суммой элементов.

int[,] array = new int[4, 5];

int[,] FillArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}
FillArray(array);
void Sum(int[,] array)
{
    int sum = 0;
    int min = array[0,0];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i,j];
        }
        Console.WriteLine(sum + "\t");
        sum = 0;
        if (sum < min)
        {
           min = sum; 
        }
        else
        {
            return;
        }
        Console.WriteLine(min);
    }
    Console.WriteLine();
}

Sum(array);

// void Max(int[] array2)
// {
//     int min = array2[0];
//     for (k = 0; k < array.Length; k++)
//     {
//         if (array[k] < min)
//         {
//             min = array[k];
//         }
//         Console.Write(min);
//     }

// }
// Max(array);

// int[,] array = new int[4, 7];

// int[,] FillArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0, 5);
//             Console.Write(array[i, j] + "\t");
//         }
//         Console.WriteLine();
//     }
//     return array;
// }

// int[,] array2 = FillArray(array);

// Console.WriteLine("---------------");

// void MaxArray(int[,] array){
//     int min = 0;
//     for (int i = 0; i < array.GetLength(1); i++){
//             min += array[0, i];
//     }
    
//     int sum = 0;
//     int count = 0;
//     for (int i = 0; i < array.GetLength(0); i++){
//         for (int j = 0; j < array.GetLength(1); j++){
//             sum += array[i, j];
//         }
//         if (sum <= min) {
//             min = sum;
//             count = i + 1;
//         }
//     }
//     Console.WriteLine("Минимальная сумма элементов находится на строке " + count + " = " + min);
// } 

// MaxArray(array2);