﻿// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
Console.Clear();
int[] array = new int[8]; 
for(int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(0, 10);
    Console.Write(array[i] + " ");
}
