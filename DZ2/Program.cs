Задача 10: Напишите программу, которая принимает на вход трёхзначное число
 и на выходе показывает вторую цифру этого числа.

456 -> 5
782 -> 8
918 -> 1
Решение 1
int i = new Random().Next(100,1000);
Console.WriteLine(i);
int num1 = i / 10;
Console.WriteLine(num1);
int num2 = num1 % 10;
Console.WriteLine($"Вторая цифра в числе {i} -> {num2}");

Решение 2
int number = new Random().Next(100,1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine("вторая цифра " + stringNumber[1]);


Задача 13: Напишите программу, которая выводит третью цифру заданного числа
 или сообщает, что третьей цифры нет.
645 -> 5
78 -> третьей цифры нет
32679 -> 6

Console.Write("Введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
if (num > -100 && num < 100)
{
Console.WriteLine($"Третьей цифры нет");
}
else{
    while (num <= -1000 || num >= 1000) // Math.Abs() - по модулю, не знаю как
    {
        num/=10; // num = num / 10 
    }
int Number3 = num % 10;
Console.WriteLine($"Третья цифра числа {num} -> {Number3}");
}



Задача 15: Напишите программу, которая принимает на вход цифру,
 обозначающую день недели, и проверяет, является ли этот день выходным.
6 -> да
7 -> да
1 -> нет

Console.Write("Введите номер дня недели: ");
int day = Convert.ToInt32(Console.ReadLine());
if (day == 1) {
    Console.Write("Не выходной");
}
if (day == 2) {
    Console.Write("Не выходной");
}
if (day == 3) {
    Console.Write("Не выходной");
}
if (day == 4) {
    Console.Write("Не выходной");
}
if (day == 5) {
    Console.Write("Не выходной");
}
if (day == 6) {
    Console.Write("Выходной день");
}
if (day == 7) {
    Console.Write("Выходной день");
}

    else
{
       Console.WriteLine("Неверное число");
}
