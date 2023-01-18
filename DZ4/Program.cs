// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Урок 4. Функции

// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

// Решение 1:

// Console.WriteLine("Введите целое число A: ");
// int A = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите целое число (степень) B: ");
// int B = Convert.ToInt32(Console.ReadLine());
// int summ = (int)Math.Pow(A, B); //Math.Pow(Double, Double) Метод Возвращает указанное число, возведенное в указанную степень.
// Console.WriteLine($"Ответ: {summ}");

// Решение 2 (списано с семинара проверка дз)
// Console.WriteLine($"{A} в степени {B} = {Pow(A,B)}");
// int Pow(int num, int rank)
// {
//     if (rank==0) return 1;

//     int result = num;
//     for (int i = 2; i <= rank; i++)
//     {
//     result *= num; // result = result * num
//     }
//     return result;
// }


// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

// Решение 1: - ЗАПУТАЛАСЬ, не могу понять куда какие переменные писать

// Console.WriteLine("Введите число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int sum = 0;
// for (int i = 0; i < num.Length; i++)
// {
//     int number = Convert.ToInt32(num[i].ToString());
//     sum += number;  
// }
//   Console.WriteLine(sum);

// Console.WriteLine($"Сумма цифр в числе {i} ->{sum}");

// Решение 2 (списано с семинара)

// Console.Clear();
// Console.WriteLine("Введите число: ");
// int num = int.Parse(Console.ReadLine());
// Console.WriteLine($"Сумма цифр = {GetSumNums(num)}");

// int GetSumNums(int number)
// {
//     int sum = 0;
//     while(number >0)
//     {
//         sum += number % 10;
//         number /= 10;
//     }
//     return sum;
// }

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]

// Решение 1

// Console.Clear();
// int[]array = GetRandomArray(8, 0, 100);
// Console.WriteLine($"[{String.Join(", ", array)}]");

// int[] GetRandomArray(int size,int minValue,int maxValue)
// {
//         int[] result = new int[size];
//         for (int i = 0; i < size; i++)
//         {
//             result[i] = new Random().Next(minValue, maxValue + 1);
//         }
//         return result;
// }


// Решение 2

// int[] CreateRandomArray(int N, int start, int end)
// {
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
// RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }

// int[] CreateArray()
// {
// Console.WriteLine("Введите количество элементов массива");
// int size = Convert.ToInt32(Console.ReadLine());
// int[] array = new int[size];
// for (int i = 0; i < size; i++)
// {
// Console.WriteLine($"Введите {i+1} элемент массива");
// array[i] = Convert.ToInt32(Console.ReadLine());
// }
// return array;
// }