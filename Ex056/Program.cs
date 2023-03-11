// 56. Написать программу, которая обменивает элементы первой строки и последней строки

using System;
using static System.Console;

Clear();

WriteLine("Введите количество строк массива");
int m = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива");
int n = int.Parse(ReadLine()!);
WriteLine("Введите номер строки котороую хотите заменить");
int a = int.Parse(ReadLine()!);
Console.WriteLine("Введите номер строки на которую хотите заменить");
int b = int.Parse(ReadLine()!);

int[,] matrix = GetArray(m,n,0,10);
PrintArray(matrix);
WriteLine();
ChangeRows(matrix, a, b);
PrintArray(matrix);

int[,] GetArray(int d, int e, int min, int max)
{
    int[,] result = new int[d,e];
    for (int i=0; i<d; i++)
    {   
        for(int j=0; j<e; j++)
        {
            result[i,j] = new Random().Next(min, max+1);
        }
    }    
    return result;
}    

void PrintArray(int[,] matrix)
{
    for(int i =0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            Write($"{matrix[i,j]} ");
        }
        WriteLine();
    }
}

void ChangeRows (int[,] matrix, int a, int b)
{
    int rowCount = matrix.GetLength(0)-1;
    for(int i = 0; i<matrix.GetLength(1); i++)
    {
        int k = matrix[a-1,i];
        matrix[a-1, i] = matrix[b-1, i];
        matrix[b-1, i] = k;
    }
}
