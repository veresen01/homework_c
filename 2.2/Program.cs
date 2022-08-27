
//Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
if (num < 100 )
{
    Console.WriteLine("третьей цифры нет");
}
else
{
    string str = num.ToString();
    Console.WriteLine(str[2]);
}

