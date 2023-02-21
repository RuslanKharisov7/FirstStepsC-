// Задача 35:Задайте одномерный массив из 123 случайных чисел [0: 1000].
//Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int[] Array = GetArray (123, 0, 1000);
Console.WriteLine(String.Join(" ", Array));
int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for (int i = 0; i<size; i++)
    {
      res[i] = new Random().Next(minValue, maxValue +1);
    }
    return res;
}
 int count = 0;
for( int i=0; i<Array.Length; i++)
{
    if(Array[i] >= 10 & Array[i]<=99)
    count++;
}
Console.WriteLine($"В заданом массиве отрезку (10,99) принадлежат {count} чисел");