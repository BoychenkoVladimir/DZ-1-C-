// Задача 2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет. Берем числа до 100000
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
Console.Clear();
Console.Write("Введи число до 100000: ");
int a = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(a);
if (a<100000 && a>99){
Console.WriteLine($"третья цифра этого числа -> "+stringNumber[2]);
}
else {
    Console.WriteLine( "-> третьей цифры нет"  );
}