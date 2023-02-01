// 16. Дано число обозначающее день недели. Выяснить является номер дня недели выходным 
Console.Clear();
Console.WriteLine("Введите номер дня недели");
int day = int.Parse(Console.ReadLine()!);
if (day == 6 || day == 7)
{
    Console.WriteLine("Этот день является выходным");
}
if (day == 1 || day == 2 || day == 3 || day == 4 || day == 5)
{
    Console.WriteLine("Этот день не является выходным");
}
if (day < 1 || day > 7)
{
    Console.WriteLine("В неделе семь дней");
}