﻿// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

int[] array = new int[8];
PrintArray(array);
Console.WriteLine();
var arr = FillArray(8);
PrintArray(arr);

int[] FillArray(int length)
{
    int[] result = new int[length];
    for(int i =0; i < result.Length; i++)
    {
        result[i] = new Random().Next(0, 9);
    }
    return result;
}

void PrintArray(int[] arr)
{
    for(int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]}, ");
    }
}
