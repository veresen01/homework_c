﻿// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.


Console.WriteLine("введите число");
int i = int.Parse(Console.ReadLine());
int sum = 0;
while (i >0)
{
    int num = i % 10;
    i = i/10;
    sum=sum + num;

}
Console.WriteLine("сумма всех цифр в равна: ");
Console.WriteLine(sum);