// 27. Определить количество цифр в числе

Console.Clear();
Console.WriteLine("Введите число");
int A = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Количество цифр в числе = {CountNumbers(A)}");
int CountNumbers (int A)
{
  int count = 0;
  while(A>0)
  {
  count++;
  A /=10;
  }
  return count;
}