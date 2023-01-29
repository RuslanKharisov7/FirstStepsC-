// //  9.Показать последнюю цифру трёхзначного числа**
Console.WriteLine("Введите трехзначное число");
string s = Console.ReadLine();
int number =  int.Parse(s);
int y = number%10;
string lastnumber = Convert.ToString(s[2]);
Console.WriteLine($"Последняя цифра заданого чисала {lastnumber}");

