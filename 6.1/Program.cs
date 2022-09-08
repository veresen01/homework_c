//Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

Console.Clear();
Console.WriteLine("введите количество чисел ");
int M = int.Parse(Console.ReadLine());
int count = 0;
for (int i = 0; i < M; i++)
{
    Console.WriteLine($"Введите число {i + 1}: ");
    int x = int.Parse(Console.ReadLine());
    if (x>0){
        count++;
    }
}
Console.WriteLine($"Положительных чисел: {count}");
