// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3


Console.WriteLine("Введите 5 чисел");
// int a = Convert.ToInt32(Console.ReadLine());
// int b = Convert.ToInt32(Console.ReadLine());
// int c = Convert.ToInt32(Console.ReadLine());
// int d = Convert.ToInt32(Console.ReadLine());
// int f = Convert.ToInt32(Console.ReadLine());

void Numbers (int n, int i)
{
  int count = 0;
  for (i = 0; i < 5; i++)
  {
    int M = Convert.ToInt32(Console.ReadLine());
    if (M > 0)
    count = count + 1;
    else return;
  }
  Console.WriteLine(count); 
}
Numbers(count);


// return M;
// int[]array = new int[M];
// int count = 0;

// // foreach (int number in array)
// // {
// //     if (number > 0)
// //     {
// //         count = count + 1;
// //     }
// //     else
// //     return count;
// // }
// // Console.WriteLine($"Количество положительных чисел из введённых пользователем - {count} ");


// void fillArray(int[] array){
//   for (int i = 0; i < M; i++)
//   {
//         array[i] = Convert.ToInt32(Console.ReadLine());       
//   }
//   Console.WriteLine(String.Join(" ", array)); 
// }

// fillArray(array);