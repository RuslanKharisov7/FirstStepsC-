// //  9.Показать последнюю цифру трёхзначного числа**
Console.WriteLine("Введите трехзначное число");
string s = Console.ReadLine();
int number =  int.Parse(s);
int y = number%10;
if (s.Length !=3)
{
    Console.Write("Число не является трехзначным");
    return;
}
string lastnumber = Convert.ToString(s[2]);
Console.WriteLine($"Последняя цифра заданого чисала {lastnumber}");

