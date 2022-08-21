// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.WriteLine("Введите первое число: ");
int A = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int B = int.Parse(Console.ReadLine());
if (A > B)
{
    Console.WriteLine("первое число -большее, второе число -меньшее");
}
else
{
   Console.WriteLine("второе число -большее, первое число -меньшее"); 
}