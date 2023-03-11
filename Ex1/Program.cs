// Показать треугольник Паскаля. *Сделать вывод в виде равнобедренного треугольника.

using System;
using static System.Console;

Clear();

Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(ReadLine()!);
PrintTriangle(rows);

void PrintTriangle(int b)
{
    for (int i = 0; i < b; i++)
    {
        for (int a = 0; a <= (b - i); a++) {
            Write("  ");
        }
        for (int a = 0; a <= i; a++)
        {
            Write("   "); 
            Write(factorial(i) / (factorial(a) * factorial(i - a)));
        }
        WriteLine();
    }
}

float factorial(int b)
{
    float x = 1;
    for (int i = 1; i <= b; i++)
    {
        x *= i;
    }
    return x;
}
