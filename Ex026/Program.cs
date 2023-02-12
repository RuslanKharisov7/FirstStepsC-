// 26. Возведите число А в натуральную степень B используя цикл

Console.Clear();
Console.WriteLine("Введите число A");
double A = double.Parse(Console.ReadLine()!);
Console.WriteLine("Введите чтсло B");
double B = double.Parse(Console.ReadLine()!);
Console.WriteLine($"Число {A} в степени {B} = {getPow(A,B)}");

double getPow (double A,double B)
{
  double result = (Math.Pow(A, B));
  return result;
}

