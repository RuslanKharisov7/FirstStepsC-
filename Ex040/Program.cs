// Задача 38: Задайте массив вещественных чисел.
//Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76
Console.Clear();
Console.WriteLine("Введите размерность массива");
int number = int.Parse(Console.ReadLine()!);
int [] array = getArray(number);
Console.WriteLine($"[{String.Join(",", array)}]");
int[] getArray(int size)
{
    int[] res = new int [size];
    for(int i =0; i<size; i++)
    {
        res[i] =new Random().Next(0, 10);
    }
    return res;
} 

int min = array[0];
int max = array[0];
for(int i= 0; i<array.Length; i++)
{
    if(array[i]<min)
    {
       min = array[i];
    }
    if (array[i]>max)
    {
      max = array[i];
    }
}
Console.WriteLine($"Минимальное число массива = {min}");
Console.WriteLine($"Максимальное число массива = {max}");
Console.WriteLine($"Разница между минимальным и максимальным числом массива = {max - min}");
