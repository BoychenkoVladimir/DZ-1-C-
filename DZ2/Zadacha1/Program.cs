// //Задача 1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа. Обязательна проверка на ввод чисел больше/меньше 3-х знаков
// 456 -> 5
// 782 -> 8
// 918 -> 1
Console.Clear();
Console.Write("Введи трёхзначное число: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
if (a<1000 && a>99){
Console.WriteLine("вторая цифра этого числа -> "+stringNumber[1]);
}
else {
    Console.WriteLine("Число не яляется трехзначным");
}

