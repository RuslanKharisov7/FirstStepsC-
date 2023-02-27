﻿// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, 
//что такого элемента нет


Console.WriteLine("Введите колисество строк массива");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int b = int.Parse(Console.ReadLine()!);
int [,] array = new int [a,b];

void FillArray(int[,] array)
{
for(int i=0; i<array.GetLength(0); i++)
{
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j]= new Random().Next(0,100);
    }
}
}

void PrintArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}
FillArray(array);
Console.WriteLine("Вывод заданного массива");
PrintArray(array);

Console.WriteLine("Введите строку искомого элемента");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите столбец искомого элемента");
int columns = int.Parse(Console.ReadLine()!);

if(rows>=a && columns>=b)
{
    Console.WriteLine($"Числа на позиции {rows}, {columns} не существует");
}
else
{
    Console.WriteLine($"Число на позиции {rows}, {columns} = {array[rows,columns]}");
}