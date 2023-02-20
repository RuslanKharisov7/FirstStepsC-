// 36. Задать массив, заполнить случайными положительными 
//трёхзначными числами. Показать количество нечетных\четных чисел

int [] Array = GetArray(123, 100, 1000);
Console.WriteLine(String.Join("  ", Array));

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i=0; i<size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}

int countEvenNumber = 0;
for (int i=0; i<Array.Length; i++)
{
    if (Array[i]%2 ==0)
    countEvenNumber++;
}

int countNegativeNumber = 0;
for (int i =0; i<Array.Length; i++)
{
    if (Array[i]%2 != 0)
    countNegativeNumber++;
}
Console.WriteLine($"Количество четных чисел в массиве {countEvenNumber}");
Console.WriteLine($"Количество не четных чисел в массиве {countNegativeNumber}");