// 35. Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();
Console.WriteLine("Введите элементы массива");
string elements = Console.ReadLine();
int [] enterArray = GetArrayFromString(elements);
Console.Write("Введите число: ");
int n = int.Parse(Console.ReadLine()!);
if (FindElement(enterArray, n))
{
    Console.WriteLine("Yes");
}
else
{
    Console.WriteLine("No");
}

int[] GetArrayFromString(string stringArray)
{
    string[] nums = stringArray.Split(" ", StringSplitOptions.RemoveEmptyEntries);
    int[] res = new int[nums.Length];

    for(int i = 0; i <nums.Length; i++)
    {
        res[i] = int.Parse(nums[i]);
    }
    return res;
}

bool FindElement(int [] array, int el)
{
    foreach(var item in array)
    {
        if (el == item)
         return true;
    }
    return false;
}