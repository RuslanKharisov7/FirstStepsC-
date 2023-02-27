//  Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
// и возвращает значение этого элемента или же указание, что такого элемента нет.


int[,] array = new int [3,4];

void FillArray(int[,] array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(1); j++)
        {
            array[i,j]= new Random().Next(0,10);
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
PrintArray(array);
FillArray(array);
Console.WriteLine();
PrintArray(array);

Console.WriteLine("Введите номер строки элемента");
int rows = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца элемента");
int columns = int.Parse(Console.ReadLine()!);

if(rows>=3 & columns>=4)
{
    Console.WriteLine("Такого числа нет в заданном массиве");
}
else
{
    Console.WriteLine($"Элемент массива находящийся на позиции {rows},{columns} = {array[rows,columns]}");
}