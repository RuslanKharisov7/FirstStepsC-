// 58. Написать программу, которая в двумерном массиве заменяет строки на столбцы или сообщить, 
// что это невозможно (в случае, если матрица не квадратная).

using System;
using static System.Console;

WriteLine("Введите количество строк массива");
int rows = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива");
int columns = int.Parse(ReadLine()!);

int[,] array = new int[rows, columns];

void FillArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i =0; i < array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

FillArray(array);
PrintArray(array);
WriteLine();
PrintArray(ChangeArray(array));




int[,] ChangeArray(int[,]array)
{
    int[,] result = new int [array.GetLength(1), array.GetLength(0)];
    for(int i = 0; i<array.GetLength(0); i++)
    {
        for(int j=0; j < array.GetLength(1); j++)
        {
            result[j,i] = array[i,j];
        }
    }
    return result;
}