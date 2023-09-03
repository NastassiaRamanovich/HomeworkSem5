// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным 
// элементов массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

void fillArray(double[] array)
{
  Random x = new Random();
  for (int i = 0; i < array.Length; i++)
  {
        array[i] = Convert.ToDouble(x.Next(-10000, 10000)/100.0);      
  }
  Console.WriteLine("[{0}]", string.Join(", ", array));
}
double[]array = new double[8];
fillArray(array);

void Search(double [] array)
{
    double dif = 0;
    double max;
    double min;
    for (int i = 0; i < 2; i++)
    {
        if (array[i] > array[i + 1])
        {
            max = array[i];
            min = array[i + 1];
        }
        else
        {
            min = array[i];
            max = array[i + 1];
        }
        for (int j = 2; j < array.Length; j++)
        {
            if (array[j] > max)
            max = array[j];
            else if (array[j] < min)
            min = array[j];

        }
        dif = max - min;
    }
    Console.WriteLine("Разница между максимальным и минимальнным числом в массиве равна " + Math.Round(dif, 2));
} 

Search(array);