﻿//33. Задать массив из 12 элементов, заполненных числами из [-9,9]. 
//Найти сумму положительных/отрицательных элементов массива

int [] array = GetRandomArray(12, -9, 9);
Console.WriteLine(String.Join(", ", array));

int positiveSum = 0;
int negativeSum = 0;

foreach (int el in array)
{
    positiveSum += el > 0 ? el : 0;
    negativeSum += el > 0 ? el : 0;
}

Console.WriteLine($"Positive sum = {positiveSum}, negative sum {negativeSum}");

int[] GetRandomArray(int size, int minValue, int maxValue)
{
    int [] result = new int[size];
    for ( int i = 0; i < size; i++)
    {
        result[i] = new Random().Next(minValue, maxValue + 1);
    }
    return result;
}