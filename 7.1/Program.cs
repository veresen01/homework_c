//Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

Console.Clear();
Console.WriteLine("количествл строк массива ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("количествл столбцов массива ");
int columns = int.Parse(Console.ReadLine());
 
double [,] array = FillArray(rows, columns, 0, 10);
PrintArray(array);
double [,] FillArray (int rows, int columns, int min, int max){
    double [,] array = new double[rows, columns];
    for (int i = 0; i < rows; i++){
        for (int j = 0; j < columns; j++){
            array[i, j] = Convert.ToDouble(new Random().Next(0, 10)) / 10;
        }
    }
    return array;
}
void PrintArray(double [,] filledArray){
    for (int i = 0; i < filledArray.GetLength(0); i++){
        for (int j = 0; j < filledArray.GetLength(1); j++){
            Console.Write($"{filledArray[i,j]} ");
        }
        Console.WriteLine();
    }
}
