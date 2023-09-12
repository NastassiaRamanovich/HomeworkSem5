﻿// Внутри класса Answer напишите методы CreateIncreasingMatrix,
//  PrintArray, PrintListAvr и FindAverageInColumns.

// Метод CreateIncreasingMatrix должен создавать матрицу заданной 
// размерности, с каждым новым элементом увеличивающимся на опрделенное 
// число. Метод принимает на вход три числа (n - количество строк 
// матрицы, m - количество столбцов матрицы, k - число, на которое 
// увеличивается каждый новый элемент) и возвращает матрицу,
//  удовлетворяющую этим условиям.

// Метод PrintArray должен выводить на экран сгенерированную 
// методом CreateIncreasingMatrix матрицу.

// Метод FindAverageInColumns принимает целочисленную матрицу 
// типа int[,] и возвращает одномерный массив типа double. 
// Этот метод вычисляет среднее значение чисел в каждом столбце 
// матрицы и сохраняет результаты в виде списка.

// Метод PrintListAvr принимает одномерный массив, возвращенный 
// методом FindAverageInColumns и выводит этот список на экран в 
// формате "The averages in columns are: x.x0 x.x0 x.x0 ...", 
// где x.x0 - это значения средних значений столбцов, округленные 
// до двух знаков после запятой, разделенные знаком табуляции.

// using System;

public class Answer {
    public static void PrintArray (int [,] matrix)
    {
      // Введите свое решение ниже
      for (int i = 0 ; i < matrix.GetLength(0); i++)
      {
          for (int j = 0 ; j < matrix.GetLength(1); j++)
          {
            Console.Write(matrix[i,j] + "\t");
          }
          Console.WriteLine();
      }
    }
  
    public static int[,] CreateIncreasingMatrix(int n, int m, int k)
    {
      // Введите свое решение ниже
      int[,] matrix = new int[n, m];
      int count = 0;
      while (count < m * n)
      {
        for (int i = 0 ; i < n; i++)
        {
          for (int j = 0 ; j < m; j++)
          {
            matrix[i, j] = count + 1;
            count = count + k;
          }
        }
      }
      return matrix;
    }
  
    static void PrintListAvr (double [] list)
    {
      // Введите свое решение ниже
      Console.WriteLine("The averages in columns are:");
      for (int k = 0; k < list.GetLength(0); k++)
      {
        Console.Write("{0:0.00}",list[k]);
        Console.Write("\t");
      }
    }

    static double [] FindAverageInColumns (int [,] matrix)
    { 
      // Введите свое решение ниже
      double[] list = new double[matrix.GetLength(1)];
      for ( int j = 0; j < matrix.GetLength(1); j++)
      {
        double SumInColumns = 0;
        double AverageInColumns = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
          SumInColumns = SumInColumns + matrix[i, j]; 
        }
        AverageInColumns = System.Math.Round(SumInColumns / matrix.GetLength(0), 2); 
        list[j] = AverageInColumns;
      }
      return list;
    }


    // Не удаляйте и не меняйте метод Main! 
    static public void Main(string[] args) {
        int n, m, k;

        if (args.Length >= 3) {
           n = int.Parse(args[0]);
           m = int.Parse(args[1]);
           k = int.Parse(args[2]);
        } else {
           // Здесь вы можете поменять значения для отправки кода на Выполнение
           n = 4;
           m = 5;
           k = 3;
        }

        // Не удаляйте строки ниже
        int[,] result = CreateIncreasingMatrix(n, m, k);
        PrintArray(result);
        PrintListAvr(FindAverageInColumns(result));
    }
}