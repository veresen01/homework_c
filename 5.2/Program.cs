// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
Console.WriteLine("введите длинну массива ");
int size = int.Parse(Console.ReadLine());
int[] rand = new int[size];
 
 
for(int i = 0; i < rand.Length; i++){
    rand[i] = new Random().Next(0, 10);
    Console.Write(rand[i]+" ");
}
int sum = 0;
for (int i = 1; i < rand.Length; i+=2)
sum += rand[i];
Console.WriteLine("сумма= " + sum);
