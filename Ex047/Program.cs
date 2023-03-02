// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

Console.WriteLine("Введите количество строк массива");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов массива");
int b = int.Parse(Console.ReadLine()!);

double[,] array = new double [a,b];

void FillArray(double[,] array)
{
  for(int i=0; i<array.GetLength(0); i++)
  {
    for(int j=0; j<array.GetLength(1); j++)
    {
        array[i,j] = Convert.ToDouble(new Random().Next(-100,100))/10;
    }
  }
}
void PrintArray(double[,]array)
{
    for(int i=0; i<array.GetLength(0); i++)
    {
        for(int j=0; j<array.GetLength(0); j++)
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