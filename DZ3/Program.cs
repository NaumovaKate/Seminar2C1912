// Задача 19

// Напишите программу, которая принимает на вход пятизначное число и проверяет, 
// является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да
// Решение 1
// Console.WriteLine("Введите 5-ти значное число: ");
// int i = new Random().Next(10000, 100000);
// String num = (Console.ReadLine());
// if ((num[0]==num[4]) && (num[1]==num[3]))
// {
//     Console.WriteLine($"Число является палиндромом");
// }
// else
//      {
//          Console.WriteLine($"Число не является палиндромом");
//      }

// Решение 2

// Console.Clear();
// Console.WriteLine("Введите 5-ти значное число: ");
// int i =Convert.ToInt32(Console.ReadLine());
// int A = i / 10000;
// int B = i / 1000 % 10;
// int C = i / 10 % 10;
// int D = i % 10;
// Console.WriteLine(A);
// Console.WriteLine(B);
// Console.WriteLine(C);
// Console.WriteLine(D);

// if(( A ==  D) && ( B ==  C)){
//     Console.WriteLine($"Число является палиндромом");
// }
// else {
// Console.WriteLine($"Число не палиндром");
// }

//Решение 3
// Console.Write("Для проверки палиндрома, введите любое число или слово");
// string num = Console.ReadLine();
// int numTxt = num.Length;

// for (int i = 1; i < numTxt; i++)
// {
// if (num[i - 1] != num[numTxt - (i)])
// {
// Console.WriteLine("не палиндром!");
// break;
// }
// if (i == numTxt-1)
// {
// Console.WriteLine("палиндром!");
// break;
// }
// }

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
// Решение 1
// Console.Clear();
// int N = new Random().Next(1,100);
// Console.WriteLine(N);
// for(int i = 1; i <= N; i++)
// {
//     Console.Write($"Таблица{i*i*i} ");
// }

// решение 2

// Console.WriteLine("Введите число N: ");
// int N = new Random().Next(1,100);
// int i = 1;
// while (i <= N)
// {
//  Console.Write($"{i*i*i} \t "); // t в выводе дает разделение на столбики
// if (i%5 == 0) Console.WriteLine(); // if (i%5 == 0) - отсекает по количеству чисел

// i++;
// }
