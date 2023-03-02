// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

Console.WriteLine("Введите количество строк массива");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int b = int.Parse(Console.ReadLine()!);

int[,] array = new int [a,b];

void FillArray(int[,] array)
{
  for(int i=0; i<array.GetLength(0); i++)
  {
    for(int j=0; j<array.GetLength(1); j++)
    {
      array[i,j]= new Random().Next(0,20);
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
PrintArray(array);
Console.WriteLine();

for (int j = 0; j < array.GetLength(1); j++)
{
    double Sred = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Sred = (Sred + array[i, j]);
    }
    Sred = Sred / a;
    Console.WriteLine($"Среднее арифметическое {j+1} столбца {Sred}; ");
}
