// 48. Показать двумерный массив размером m×n заполненный целыми числами

void FillArray(int[,]matrix)
{
    for(int i=0; i<matrix.GetLength(0); i++)
    {
        for(int j=0; j<matrix.GetLength(1); j++)
        {
            matrix[i,j] = new Random().Next(1, 10);
        }
    }
}

void PrintArray(int[,]matrix)
{
 for(int i=0; i<matrix.GetLength(0); i++)
 {
    for(int j=0; j<matrix.GetLength(1); j++)
    {
        Console.Write($"{matrix[i,j]}");
    }
    Console.WriteLine();
 }
}
int[,] matrix = new int [3,4];
PrintArray(matrix);
FillArray(matrix);
Console.WriteLine();
PrintArray(matrix);
