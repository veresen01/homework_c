// напишите программу которая принимает на вход координаты 2х точек, и находит расстояние между ними в 3д пространстве
Console.WriteLine("введите координаты первой точки A(x1,y1,z1)");
Console.WriteLine("введите x1");
int x1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y1");
int y1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z1");
int z1 = int.Parse(Console.ReadLine());
Console.WriteLine("введите координаты второй точки B(x2,y2,z2)");
Console.WriteLine("введите x2");
int x2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите y2");
int y2 = int.Parse(Console.ReadLine());
Console.WriteLine("введите z2");
int z2 = int.Parse(Console.ReadLine());

Console.WriteLine(Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)));