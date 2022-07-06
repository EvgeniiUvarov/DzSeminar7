// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();

Write("Введите m= ");
int m = int.Parse(ReadLine());
Write("Введите n= ");
int n = int.Parse(ReadLine());


int[,] arrSize = new int [5,5];
PrintArray(GetRandomArray(arrSize));


if (m > arrSize.GetLength(0) || n > arrSize.GetLength(1) ) WriteLine("Такого элемента нет");
else WriteLine($"значение {m} столбца {n} строки равно: {arrSize[n-1, m-1]}");

int[,] GetRandomArray(int[,] array)
{
    for(int i = 0; i < arrSize.GetLength(0); i++)
    {
        for(int j = 0; j < arrSize.GetLength(1); j++)
        {
            arrSize[i,j] = new Random().Next(10,100);
        }
    }
    return arrSize;
}

void PrintArray(int[,] array)
{
     for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}