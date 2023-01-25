// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3

// Решение задачи 1:


// int[] CreateRandomArray(int M, int start, int end)
// {
//     int[] RandomArray = new int[M];
//     for (int i = 0; i < M; i++)
//     {
//         RandomArray[i] = new Random().Next(start, end + 1);
//     }
//     return RandomArray;
// }

// void ShowArray(int[] array)
// {
//     for (int i = 0; i < array.Length; i++)
//     {
//         Console.Write(array[i] + " ");
//     }
//     Console.WriteLine();
// }

// int[] ArrayM = CreateRandomArray(10, -100, 100);
// ShowArray(ArrayM);

// int positive= 0;

// for (int i = 0; i < ArrayM.Length; i++)
// {
//     if (ArrayM[i] > 0)
//         positive++;
// }
// Console.WriteLine($"Количество положительных чисел в массиве = {positive}");


// Посчитайте, сколько чисел больше 0 ввёл пользователь.


// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых,
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.
// b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)

Console.WriteLine("Введите число b1");
double b1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k1");
double k1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число b2");
double b2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число k2");
double k2 = Convert.ToInt32(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k2 * x + b2;

Console.WriteLine($"Точка пересечения двух прямых c координатами X: {x} и Y: {y}");