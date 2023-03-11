// Задача 5. Заполните спирально массив 4 на 4.


using System;
using static System.Console;
Clear();
Write($"Введите размер матрицы: ");
int s = int.Parse(ReadLine());
int[,] arr = GetArray(s);

PrintArray(arr);



int[,] GetArray(int size)
{
    int[,] result = new int[size, size];
    int i = 0;
    int j = 0;
    int rowA = size - 1;
    int columnA = size - 1;
    int rowB = 0;
    int columnB = 0;
    bool left = true;
    bool top = true;
    int count = 0;
    while (count < size * size)
    {
        count++;
        result[i, j] = count;
        if (left && top)
        {
            if (j == columnA)
            {
                rowB ++;
                top = true;
                left = false;
                i++;
                continue;
            }
            else
            {
                j++;
                continue;
            }
        }

        if (!left && top)
        {
            if (i == rowA)
            {
                columnA--;
                top = false;
                left = false;
                j--;
                continue;
            }
            else
            {
                i++;
                continue;
            }
        }
       
        if (!left && !top)
        {
            if (j == columnB)
            {
                rowA--;
                top = false;
                left = true;
                i--;
                continue;
            }
            else
            {
                j--;
                continue;
            }
        }
        
        if (left && !top)
        {
            if (i == rowB)
            {
                columnB++;
                top = true;
                left = true;
                j++;
                continue;
            }
            else
            {
                i--;
                continue;
            }
        }

    }
    return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Write($"{inArray[i, j]} ");
        }
        WriteLine();
    }
}