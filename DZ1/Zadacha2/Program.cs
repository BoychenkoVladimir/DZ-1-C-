﻿// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Clear();
Console.WriteLine("Введите 3 числа:");
int a = Int32.Parse(Console.ReadLine()); 
int b = Int32.Parse(Console.ReadLine());
int c = Int32.Parse(Console.ReadLine());
int maximal = Math.Max(Math.Max(a, b), c); 
Console.WriteLine(" Максимальное число -> {0}", maximal);



/*Другое решение
Console.Clear();
Console.WriteLine("Введите три числа");
int x = int.Parse(Console.ReadLine());
int y = int.Parse(Console.ReadLine());
int z = int.Parse(Console.ReadLine());
int max = 0;
if (x >= y && x >= z){
    max = x;
}
else if (y >= x && y >=z){
    max = y;
}
  else if (z >= x && z >= y){
    max = z;
  }
Console.WriteLine("Максимальное число {0}", max );*/