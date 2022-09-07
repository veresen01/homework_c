
//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 100);
    Console.Write(rand[i]+" ");
}
Console.WriteLine();
int maxValue = rand.Max<int>();
 
int minValue = rand.Min<int>();
 
Console.WriteLine($"Разница между максимальным и минимальным элементом: {maxValue-minValue}");
