// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
Console.Clear();
Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N));
string PrintNumbers(int N)
{
    if(N==1)
    {
        Console.WriteLine(N);
        return N.ToString();
    }
    string s= N.ToString() + " " + PrintNumbers(N-1);
    Console.WriteLine(s);
    return s;
}


