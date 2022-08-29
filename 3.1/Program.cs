// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
Console.Write("Введите пятизначное число: ");
int num = int.Parse(Console.ReadLine());
 
if (num < 10000 || num > 99999 )
{
    Console.WriteLine("введите пятизначное число");
}
else
{
    string str = num.ToString();
    Console.WriteLine(str[0] == str[4] || str[1] == str[3] ? "палиндром" : "не палиндром");
}