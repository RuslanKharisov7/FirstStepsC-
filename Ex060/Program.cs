// 60. Составить частотный словарь элементов двумерного массива

using System;
using static System.Console;

WriteLine("Введите количество строк массива");
int a = int.Parse(ReadLine()!);
WriteLine("Введите количество столбцов массива");
int b = int.Parse(ReadLine()!);

int[,] array = new int [a,b];

void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j] = new Random().Next(0,10);
        }
    }
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Write($"{array[i,j]} ");
        }
        WriteLine();
    }
}

FillArray(array);
PrintArray(array);
WriteLine();
int[] rowAr = GetRowArray(array);

SortArray(rowAr);
WriteLine(String.Join(" ", rowAr));
PrintData(rowAr);

int[] GetRowArray (int[,] array)
{
    int[] result = new int [array.GetLength(0)* array.GetLength(1)];
    int index = 0;
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            result[index] = array[i,j];
            index++;
        }
    }
    return result;
}

void SortArray(int[] array) 
{
  for(int i=0; i<array.Length; i++)
  {
    for(int j=0; j<array.Length; j++)
    {
        if(array[i]>array[j])
        {
            int k = array[i];
            array[i] = array[j];
            array[j] = k;
        }
    }
  }
}

void PrintData (int[] array)
{
    int el = array[0];
    int count = 1;
    for(int i = 1; i<array.Length; i++)
    {
        if(array[i] != el)
        {
            WriteLine($"{el} встречается {count} раз");
            el=array[i];
            count = 1;
        }
        else
        {
            count++;
        }
    }
    WriteLine($"{el} встречается {count} раз");
}
