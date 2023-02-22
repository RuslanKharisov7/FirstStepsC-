//39. Найти произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.WriteLine("Введите размерность массива");
int number = int.Parse(Console.ReadLine()!);
int[] Array = getArray(number);
Console.WriteLine($"[{String.Join(",", Array)}]");
int[] getArray(int size)
{
    int[] res = new int [size];
    for(int i=0; i<size; i++)
    {
        res[i] = new Random().Next(0,10);
    }
    return res;
}

for(int i=0; i<Array.Length/2; i++)
{
  Console.Write($"{Array[i] * Array[Array.Length -1-i]}  ");
}