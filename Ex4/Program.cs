//Задача 4. Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
//Напишите программу, которая будет построчно выводить массив, добавляя индексы
//каждого элемента.

using System;
using static System.Console;
Clear();
Write("Введите введите размерность массива через пробел: ");
string[] numbers = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int[,,] array = GetArray(new int[] { int.Parse(numbers[0]), int.Parse(numbers[1]), int.Parse(numbers[2]) }, 10, 99);
PrintArray(array);


int[,,] GetArray(int[] sizes, int min, int max)
{
    int[,,] result = new int[sizes[0], sizes[1], sizes[2]];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            int k=0;
            while(k<result.GetLength(2))
            {
                int el=new Random().Next(min, max + 1);
                if(FindElement(result,el)) continue;
                result[i, j, k] = el;
                k++;
            }
        }
    }
    return result;
}


bool FindElement(int[,,] array, int el)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                if(array[i, j, k]==el) return true;
            }
        }
    }
    return false;
}

void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Write($"{array[i, j, k]} ({i},{j},{k})   ");
            }
            WriteLine();
        }
        WriteLine();
    }

}