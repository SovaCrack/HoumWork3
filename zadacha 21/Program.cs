// Напишите программу, которая принимает на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B(2,1,-7), ->15,84
// A (7,-5,0); B(1,1,9), >11,53

Console.Write("введите координаты x1, точка А: ");
double x1 = double.Parse(Console.ReadLine());
Console.Write("введите координаты x2, точка А: ");
double x2 = double.Parse(Console.ReadLine());
Console.Write("введите координаты x3, точка А: ");
double x3 = double.Parse(Console.ReadLine());
Console.Write("введите координаты y1,точка B: ");
double y1 = double.Parse(Console.ReadLine());
Console.Write("введите кординаты y2, точка B: ");
double y2 = double.Parse(Console.ReadLine());
Console.Write("введите координаты y3, точка B: ");
double y3 = double.Parse(Console.ReadLine());


double result  = Math.Sqrt(Math.Pow((x1-y1), 2) + Math.Pow((x2-y2), 2) + Math.Pow((x3-y3), 2));
Console.WriteLine($"Расстояние между координатами: {result}");

Console.ReadLine();