// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9


using System;
using static System.Console;
Clear();

Write("Введите m= ");
int m = int.Parse(ReadLine());
Write("Введите n= ");
int n = int.Parse(ReadLine());
double[,] printar = GetArrMan(m, n);
PrintArray(printar);

double[,] GetArrMan(int m, int n)
{
    double[,] result =  new double[m,n];
    for(int i=0; i<m; i++)
    {
        for(int j=0; j<n; j++)
        {
            result[i,j] = Convert.ToDouble(new Random().Next(-100,100))/5;
            //result[i,j] = new Random().NextDouble();
        }
    }
    return result;
}

void PrintArray(double [,] array)
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