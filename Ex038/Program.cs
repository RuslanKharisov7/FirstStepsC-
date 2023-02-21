// Задача 36: Задайте одномерный массив,
//заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

Console.WriteLine("Введите размерность массива");
int number = int.Parse(Console.ReadLine()!);
int[] array = getArray(number);
Console.WriteLine($"[{String.Join("," , array)}]");
int[] getArray(int size)
{
  int[] res = new int [size];
  for(int i=0; i<size; i++)
  {
    res[i] = new Random().Next(0, 10);
  }
  return res;
}
 int sum = 0;
for(int i =0;  i<array.Length; i++)
{
    if(i % 2 != 0)
    sum += array[i];
}
Console.WriteLine($"Сумма элементов на нечетных позициях = {sum}");