// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
int C = int.Parse(Console.ReadLine());
int max = A;
if (B > max) max = B;
if (C > max) max = C;
Console.WriteLine("max=");
Console.Write(max);
