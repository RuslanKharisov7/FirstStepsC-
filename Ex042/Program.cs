// 42. Определить сколько чисел больше 0 введено с клавиатуры

Console.WriteLine("Введите размерность массива");
int number = int.Parse(Console.ReadLine()!);
int[] array= new int [number];

for (int i =0; i<array.Length; i++)
{
  Console.Write($"Введите элемент массива под индексом {i}:\t");
  array[i] = int.Parse(Console.ReadLine()!);
}
Console.WriteLine("Вывод массива");
for (int i =0; i<array.Length; i++)
{
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
int count = 0;
for(int i=0; i<array.Length; i++)
{
  if (array[i]> 0)
  count++;
}
Console.WriteLine($"Введенно {count} чисел больше 0 ");