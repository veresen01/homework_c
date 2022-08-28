// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N
Console.WriteLine("ВВЕДИТЕ ЧИСЛО");
int num = int.Parse(Console.ReadLine());
int count = 1;
while ( count <= num )
{
    Console.Write($"{Math.Pow(count, 3)} ");
    count ++;
}