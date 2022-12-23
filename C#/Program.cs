// Напишите программу, которая выводит случайное число из отрезка [10, 99] 
// и показывает наибольшую цифру числа.
// Например:
// 78 -> 8
// 12-> 2
// 85 -> 8


int number = new Random().Next(10,100);
Console.WriteLine(number);
if (number/10 > number%10)
{
    Console.WriteLine(number/10);
}
else
{
    Console.WriteLine(number%10);
}

 
// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
// и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8 
// 918 -> 1

// int number = new Random().Next(100,1000);
// Console.WriteLine(number);
// Console.Write(number/100);
// Console.Write(number%10);
// // 2 вариант решения: 
// int num1 = number/100;
// int num2 = number%10;
// Console.WriteLine(num1*10+num2); //Console.WriteLine($"{num1}{num2}");


// Задача 12. Напишите программу, которая будет принимать на вход два числа и выводить, 
// является ли второе число кратным первому. Если число 2 не кратно числу 1, 
// то программа выводит остаток от деления.

// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

// double a = new Random().Next(1, 10);
// double b = new Random().Next(1, 3);
// double ost = (a % b);

// Console.WriteLine(a);
// Console.WriteLine(b);

// if(ost == 0)
// {
//     Console.WriteLine("Кратно");
// }
// else
// {
//     Console.WriteLine("Не кратно, остаток = " + ost);
// }

// Задача 14. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.

// 14 -> нет 
// 46 -> нет 
// 161 -> да

// Console.WriteLine("Введите число: ");
// int i = Convert.ToInt32(Console.ReadLine());
// if((i % 7 == 0) && (i % 23 == 0))
// {
//     Console.WriteLine("Yes - число кратно одновременно 7 и 23");
// }
// else{
//     Console.WriteLine("No - не делится одновременно на 7 и 23");
// }


// Задача 16. Напишите программу, которая принимает на вход два числа
//  и проверяет, является ли одно число квадратом другого.

// 5, 25  ->  да
// -4, 16  ->  да
// 25, 5  ->  да
// 8,9  ->  нет

// Console.Write("Enter number A: ");
// int a = Convert.ToInt32(Console.ReadLine());
// Console.Write("Enter number B: ");
// int b = Convert.ToInt32(Console.ReadLine ());
// if((a * a == b) || (b * b == a))
// {
//     Console.WriteLine("the number a is the square of the number b");
// }
// else
// {
//     Console.WriteLine("not");

// }
