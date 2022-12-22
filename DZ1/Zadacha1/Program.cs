// int a1 = 5;
// int b1 = 7;
// int a2 = 44;
// int b2 = 15;
// double a3 = -9;
// double b3 = -3;
// if(a1 > b1)
//     Console.WriteLine("a1 bolshe b1");
// else
//     Console.WriteLine("b1 bolshe a1");
// if(a2 > b2)
//     Console.WriteLine("a2 bolshe b2");
// else
//     Console.WriteLine("b2 bolshe a2");
// if(a3 > b3)
//     Console.WriteLine("a3 bolshe b3");
// else
//     Console.WriteLine("b3 bolshe a3");

Console.WriteLine("Напишите программу, которая на вход принимает два числа и выдает, какое число больше, а какое меньше");
Console.WriteLine("Press number 1");
int number1 = int.Parse(Console.ReadLine()!);
Console.WriteLine("Press number 2");
int number2 = int.Parse(Console.ReadLine()!);

if (number1 > number2) 
{
    Console.WriteLine("Число 1 больше, чем 2");
}
else
{
    Console.WriteLine("Число 2 больше, чем 1");
}