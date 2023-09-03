// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. Напишите программу, 
// которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2


void fillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
        array[i] = new Random().Next(100, 1000);       
  }
  Console.WriteLine("[{0}]", string.Join(", ", array));
}
int[]array = new int[8];
fillArray(array);

void CountNumbers(int [] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0)
        count = count + 1;
    }
    Console.WriteLine("Количество четных чисел в массиве: " + count);
} 

CountNumbers(array);