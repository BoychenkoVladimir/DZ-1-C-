// Задача 21
// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

Console.Clear();
System.Console.Write("Ведите число Х1: ");
int x1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите число y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите число z1: ");
int z1 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите число Х2: ");
int x2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите число y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Ведите число z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());
double result = Math.Round(Math.Sqrt(Math.Pow((x1 - x2),2)+Math.Pow((y1 - y2),2)+Math.Pow((z1 - z2),2)),2);



System.Console.WriteLine($"Растояние между тремя точками: {result}");