// 32. Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран 

Console.Clear();
Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine()!);
int [] array = GetBinArray(number);
Console.WriteLine($"[{String.Join(",", array)}]");

int[] GetBinArray (int size)
{
    int[] result = new int [size];
    for(int i=0; i<size; i++)
    {
        result[i]= new Random().Next(2);
    }
    return result;
}

