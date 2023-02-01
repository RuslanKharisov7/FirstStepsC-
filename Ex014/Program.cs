// 14.Найти третью цифру числа или сообщить, что её нет**

Console.Clear();
Console.WriteLine("Введите число");
string s = Console.ReadLine();
int number = int.Parse(s);

if (s.Length < 3)
{
    Console.WriteLine("В данном числе нет третьей цифры");
    return;
}
else
{   
     string lastnumber = Convert.ToString(s[2]);
    Console.WriteLine($"Третья цифра заданого числа {lastnumber}");
}