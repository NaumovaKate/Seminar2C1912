// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// Console.WriteLine("Введите 5-ти значное число: ");
// int i = new Random().Next(10000, 100000);
// int num = Convert.ToInt32(Console.ReadLine());
// if ((num[0]==num[4]) && (num[1]==num[3]))
// {
//     Console.WriteLine($"Число является палиндромом");
// }
// else
//      {
//          Console.WriteLine($"Число не является палиндромом");
//      }


// Задача 21

// Напишите программу, которая принимает на вход координаты двух точек
//  и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите Z1: ");
// int z1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());
// Console.Write("Введите Z2: ");
// int z2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2) + Math.Pow(z1-z2, 2));

// Console.WriteLine($"d={d:f2}");


// Задача 23

// Напишите программу, которая принимает на вход число (N) 
// и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Clear();
int N = new Random().Next(1,100);
Console.WriteLine(N);

// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

for(int i = 1; i <= N; i++)
{
    Console.Write($"Таблица{i*i*i} ");
}