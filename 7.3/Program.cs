// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов 
 
Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
int [,] array = FillArray(rows, columns, 1, 10);
 
PrintArray(array);
Console.WriteLine();
for (int j = 0; j < array.GetLength(1); j++)
{
    double sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum += array[i, j];
    }
    Console.Write($"{ sum / array.GetLength(0)} ");
 
}
int [,] FillArray (int rows, int columns, int min, int max){
    int [,] array = new int[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i,j] = new Random().Next(min, max + 1);
        }
    }
    return array;
}
void PrintArray(int [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
} 
