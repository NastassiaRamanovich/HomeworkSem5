// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


int Prompt (string message);
{
  System.Console.Write(message);
  string value = Console.ReadLine();
  int result = Convert.ToInt32(Console.ReadLine());
  return result;
}

int [] InputArray (int length)
{
  int[] array = new int[length];
  for (i = 0; i < array.length; i++)
  {
    array[i] = Prompt($"Введите {i + 1}-ый элемент");
  }
    return array;
}

void PrintArray (int[] array)
{
  for (i = 0; i < array.length; i++)
  {
    Console.WriteLine($"a[{i}] = array[{i}]");
  }
}

int CountPositiveNumber (int[] array)
{
  int count = 0;
  for (i = 0; i < array.length; i++)
  {
    if (array[i] > 0)
    {
      count++;
    }
  }
  return count;
}

int length = Prompt("Введите количество элементов больше >");
int[] array;
array = InputArray(length);
PrintArray(array);
Console.WriteLine($"Количество чисел больше 0 - {CountPositiveNumber(array)}");
