// Задача 36: Задайте одномерный массив, заполненный 
// случайными числами. Найдите сумму элементов, стоящих 
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

void fillArray(int[] array)
{
  for (int i = 0; i < array.Length; i++)
  {
        array[i] = new Random().Next(1, 100);       
  }
  Console.WriteLine("[{0}]", string.Join(", ", array));
}
int[]array = new int[8];
fillArray(array);

void SumNumbers(int [] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 == 0)
        sum = sum + array[i];
    }
    Console.WriteLine("Сумма чисел на четных позициях в массиве равна " + sum);
} 

SumNumbers(array);