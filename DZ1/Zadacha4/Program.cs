﻿/*Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
5 -> 2, 4
8 -> 2, 4, 6, 8*/

Console.Clear();
Console.WriteLine("Введите число:");
int a = Int32.Parse(Console.ReadLine());
for (int i = 2; i <= a; i += 2) 
Console.Write("-> {0},", i);