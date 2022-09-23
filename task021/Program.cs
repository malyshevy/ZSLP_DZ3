// Задача 21 : Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
Console.Clear();
Console.WriteLine("Введите координаты первой точки");
Console.Write("x : ");
double x=double.Parse(Console.ReadLine());
Console.Write("y : ");
double y=double.Parse(Console.ReadLine());
Console.Write("z : ");
double z=double.Parse(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки");
Console.Write("x : ");
double x1=double.Parse(Console.ReadLine());
Console.Write("y : ");
double y1=double.Parse(Console.ReadLine());
Console.Write("z : ");
double z1=double.Parse(Console.ReadLine());
double rezult=Math.Abs(Math.Sqrt(Math.Pow((x1-x),2)+Math.Pow((y1-y),2)+Math.Pow((z1-z),2)));
Console.WriteLine($"Расстояние между точками равно : {Math.Round(rezult,2)}");
