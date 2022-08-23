// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.WriteLine("Введите  число: ");
int number = int.Parse(Console.ReadLine());
int n = number%2;
if(n == 0) Console.WriteLine("Число четное ");
else Console.WriteLine("Число нечетное ");
