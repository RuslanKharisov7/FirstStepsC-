// 31. Задать массив из 8 элементов и вывести их на экран 

Console.Clear();
Console.WriteLine("Введите размерность массива");
int number = int.Parse(Console.ReadLine()!);
int [] array = GetBinArray(number);

Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinArray (int size)
{
    int[] result = new int [size];
    for(int i=0; i<size; i++)
    {
        result[i] = new Random().Next();
    }
    return result;
}
