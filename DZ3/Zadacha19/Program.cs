// Задача 19
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да
Console.Clear();
System.Console.Write("Введите пятизначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
while ( a < 9999 || a > 100000){
    System.Console.WriteLine("Пиши правильное число от 10000 до 99999");
    a = Convert.ToInt32(Console.ReadLine()); 
}
int num1 = a % 10; 
int num2 = a / 10 % 10;
int num3 = a / 100 % 10; 
int num4 = a / 1000 % 10; 
int num5 = a / 10000 % 10; 
int result = ((((num1*10+num2)*10+num3)*10+num4)*10+num5);
if (a == result){
    System.Console.WriteLine($"Число {a} палиндром, результат {result}");
}
else{
    System.Console.WriteLine($"Число {a} нифига не палиндром");
}