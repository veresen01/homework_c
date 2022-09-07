
//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.[345, 897, 568, 234] -> 2
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(100, 1000);
    Console.Write(rand[i]+" ");
}
 
int count = 0;
for (int i = 0; i < rand.Length; i++)
if (rand[i] % 2 == 0)
count++;
 
Console.WriteLine($"всего {rand.Length} чисел, {count} из них чётные");