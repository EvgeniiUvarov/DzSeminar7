// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;
Clear();

Write("Введите колличество строк: ");
int m = int.Parse(ReadLine());
Write("Введите колличество столбцов: ");
int n = int.Parse(ReadLine());
int[,] arr = GetRandomArray(m, n);
PrintArray(arr);

double[] arrSum = arrArifmetic(arr);
PrintNewArray(arrSum);

double[] arrArifmetic(int [,] array)
{

    double[] arrSum = new double[array.GetLength(1)];

    for(int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i,j];
        }
        arrSum[j] = sum / array.GetLength(0);
    }
    return arrSum;
}


int[,] GetRandomArray(int m, int n)
{
    int[,] result = new int[m,n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) result[i,j] = new Random().Next(0,10);
    } return result;
}


void PrintArray(int [,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

void PrintNewArray(double [] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Write($"{array[i]};  ");
    }
     WriteLine();
}