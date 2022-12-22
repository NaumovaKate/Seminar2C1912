// Console.WriteLine("Введите любое число по оси X");
// int X = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите любое число по оси Y");
// int Y = Convert.ToInt32(Console.ReadLine());
// if(X < 0)
// {
//     if(Y < 0)
//     {
//         Console.WriteLine("Точка находится в 1 четверте");
//     }
//     else
//     {
//         Console.WriteLine("Точка находится в 2 четверте");
//     }
// }
// else
// {
//     if(Y < 0)
//     {
//         Console.WriteLine("Точка находится в 3 четверте");
//     }
//     else
//     {
//         Console.WriteLine("Точка находится в 4 четверте");
//     }
// }


// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

// void printQuarter(int a, int b)
// {
//     if (a>0 && b>0)
//     {
//         Console.WriteLine ("Первая четверть");
//     }
//     else if (a<0 && b>0)
//     {
//         Console.WriteLine ("Вторая четверть");
//     }
//     else if (a<0 && b<0)
//     {
//         Console.WriteLine ("Третья четверть");
//     }
//     else if (a>0 && b<0)
//     {
// int returnQuarter (int a, int b)
// {
//     if (a>0 && b>0)
//     {
//         return 1;
//     }
//     else if (a<0 && b>0)
//     {
//         return 2;
//     }
//     else if (a<0 && b<0)
//     {
//         return 3;
//     }
//     else if (a>0 && b<0)
//     {
//         return 4;
//     }
//     else
//     {
//         return 0;
//     }
// }

// Console.WriteLine ("Введите координаты x");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine ("Введите координаты y");
// int y = Convert.ToInt32(Console.ReadLine());
// // printQuarter(x, y);

// Console.WriteLine(returnQuarter(x,y));
// int quarter = returnQuarter(x,y);
// Console.WriteLine($"Четверть: {quarter}");

// Напишите программу, которая по заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

// int quarter = int.Parse(Console.ReadLine());

// switch (quarter)
// {
//     case 1:
//     {
//         Console.WriteLine("x>0 y>0");
//         break;
//     }
//     case 2:
//     {
//         Console.WriteLine("x<0 y>0");
//         break;
//     }
//     case 3:
//     {
//         Console.WriteLine("x<0 y<0");
//         break;
//     }
//     case 4:
//     {
//         Console.WriteLine("x>0 y<0");
//         break;
//     }

//     default:
//     {
//         Console.WriteLine("Введена неправильная четверть");
//         break;
//     }
// }




// // Задача 21. Напишите программу, которая принимает на вход координаты двух точек
// //  и находит расстояние между ними в 2D пространстве.

// // A (3,6); B (2,1) -> 5,09 
// // A (7,-5); B (1,-1) -> 7,21

// Console.Clear();
// Console.Write("Введите X1: ");
// int x1=int.Parse(Console.ReadLine());
// Console.Write("Введите Y1: ");
// int y1=int.Parse(Console.ReadLine());
// Console.Write("Введите X2: ");
// int x2=int.Parse(Console.ReadLine());
// Console.Write("Введите Y2: ");
// int y2=int.Parse(Console.ReadLine());

// double d = Math.Sqrt(Math.Pow(x1-x2, 2) + Math.Pow(y1-y2, 2));

// Console.WriteLine($"d={d:f3}");




// Задача 22.Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу квадратов чисел 
// от 1 до N.

// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4

// Console.Clear();
// Console.Write("Введите число N: ");
// int N = int.Parse(Console.ReadLine());

// for(int i = 1; i <= N; i++)
// {
//     Console.Write($"{i*i} ");
// }
