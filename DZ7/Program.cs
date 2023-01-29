// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Домашне задание к Семинару 7

// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

// решение:

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());

// double[,] array = new double[m, n];
// Random random = new Random();
// for (int i = 0; i < m; i++)
// {
//     for (int j = 0; j < n; j++)
//     {
//         array[i, j] = (double) random.Next(-100, 100)/10;
//         Console.Write(array[i, j] + "\t");
//     }
// Console.WriteLine();
// }


// Задача 50. Напишите программу, которая на вход принимает 
// позиции элемента в двумерном массиве, 
// и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

// Console.Write("Введите количество строк массива: ");
// int m = int.Parse(Console.ReadLine());

// Console.Write("Введите количество столбцов массива: ");
// int n = int.Parse(Console.ReadLine());

// int[,] FillNumb = new int[5,10];
// FillArrayNum(FillNumb);

// if (n > FillNumb.GetLength(0) || m > FillNumb.GetLength(1))
// {
//     Console.WriteLine("такого числа нет");
// }
// else
// {
//     Console.WriteLine($"значение элемента {n} строки и {m} столбца равно {FillNumb[n - 1, m - 1]}");
// }

// PrintArray(FillNumb);

// void FillArrayNum(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             array[i, j] = new Random().Next(0,10);
//         }
//     }
// }

// void PrintArray(int[,] array)
// {
//     for (int i = 0; i < array.GetLength(0); i++)
//     {
//         for (int j = 0; j < array.GetLength(1); j++)
//         {
//             Console.Write(array[i, j] + "\t");
//         }
//               Console.WriteLine();
//     }
// }



// Задача 52. Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// решение:

Console.WriteLine("введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());
int [,] array = GetArray(rows,columns, 0, 10);
PrintArray(array);

double[] averageColumns = GetResultArray(array);
Console.WriteLine($"Cреднее арифметическое каждого столбца = {String.Join("; ", averageColumns)}");

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max + 1);
        }
    }
    return result;
}
void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
        for (int j = 0; j < inArray.GetLength(1); j++)
        {
            Console.Write($"{inArray[i, j]} ");
        }
        Console.WriteLine();
    }
}

double[] GetResultArray(int[,] array)
{
    double[] result = new double[array.GetLength(1)];
    for (int columns = 0; columns < array.GetLength(1); columns++)
    {
        double sum = 0;
        for (int rows = 0; rows < array.GetLength(0); rows++)
        {
            sum+=array[rows, columns];
        }
        result [columns] = Math.Round(sum/array.GetLength(0), 2);
    }
    return result;
}