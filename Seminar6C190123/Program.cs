// Задача 31: Задайте массив из 12 элементов, 
// заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] 
// сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Решение задачи 31:
// первое:
// int[] CreateRandomArray(int N, int start, int end)
// {
// int[] RandomArray = new int[N];
// for (int i = 0; i < N; i++)
// {
// RandomArray[i] = new Random().Next(start, end + 1);
// }
// return RandomArray;
// }

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }
// int[] Array1 = CreateRandomArray(12, -9, 9);
// ShowArray(Array1);

// int positive = 0;
// int negative = 0;

// for (int i = 0; i < Array1.Length; i++)
// {
// if (Array1[i] > 0){positive += Array1[i];}
// else{negative += Array1[i];}
// }

// Console.WriteLine($"Сумма позитивных = {positive}\nСумма негативных = {negative}");


// второе решение:
// int [] mass = new int[12];
// int sum = 0;
// int sum2 = 0;
// for(int i = 0; i < mass.Length; i++)
// {
// mass [i] = new Random().Next(-9, 9);
// Console.Write(" ");
// Console.Write(mass [i]);
// if(mass[i] < 0)
// {
// sum2 = sum2 + mass [i];
// }
// else
// {
// sum = sum + mass [i];
// }
// }
// Console.WriteLine();
// Console.WriteLine($"Сумма отрицательных чисел равна: {sum2}");
// Console.WriteLine($"Сумма положительных чисел равна: {sum}");





// Задачка из учебника на выполнение сортировка массива
// ввод чисел
// int[] mas = { 5, 6, 3, 7, 1 };
// // сортировка
// int temp;
// for (int i = 0; i < mas.Length-1; i++)
// {
// for (int j = i + 1; j < mas.Length; j++)
// {
// Console.WriteLine($"i = {i} и j = {j}");
// Console.WriteLine("Текущее состояние массива: "+ String.Join(",",mas));
// Console.WriteLine($"Сравниваем mas[i] = {mas[i]} и mas[j] = {mas[j]}");
// if (mas[i] > mas[j])
// {
// Console.WriteLine("mas[i] больше mas[j]");
// Console.WriteLine($"Работаем с : mas[i] = {mas[i]} и mas[j] = {mas[j]}");
// temp = mas[i];
// mas[i] = mas[j];
// mas[j] = temp;
// Console.WriteLine($"Поменяли местами, теперь : mas[i] = {mas[i]} и mas[j] = {mas[j]} ");
// }
// else
// {
// Console.WriteLine("mas[i] меньше mas[j], продолжаем итерации");
// }
// }
// }
// // вывод
// Console.WriteLine("Вывод отсортированного массива");
// for (int i = 0; i < mas.Length; i++)
// {
// Console.WriteLine(mas[i]);
// }
// Console.ReadLine();




// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

//Задача 40. Напишите программу, которая принимает на вход три числа и проверяет,
//может ли существовать треугольник со сторонами такой длины.
//Теорема о неравенстве треугольника: каждая сторона треугольника меньше суммы двух других сторон.

// Console.WriteLine("Введите первое число");
// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int number2 = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите третье число");
// int number3 = Convert.ToInt32(Console.ReadLine());
// if (number < number2 + number3)
// {
//     if (number2 < number + number3)
//     {
//         if (number3 < number2 + number)
//         {
//             Console.WriteLine("Да, такой треугольник может существовать");
//         }
//         else
//         {
//             Console.WriteLine("Нет, такой треугольник не может существовать");
//         }
//     }
//     else
        //     {
        //         Console.WriteLine("Нет, такой треугольник не может существовать");
        //     }
        // }
        // else
        // {
        //     Console.WriteLine("Нет, такой треугольник не может существовать");
        // }


        //Задача 42. Напишите программу, которая будет преобразовывать 
        // десятичное число в двоичное.
        // 45 -> 101101
        // 3 -> 11
        // 2 -> 10






        //Задача 44. Не используя рекурсию, выведите первые N чисел Фибоначчи.
        //Первые два числа Фибоначчи: 0 и 1.
        //Если N = 5 -> 0 1 1 2 3
        //Если N = 3 -> 0 1 1
        //Если N = 7 -> 0 1 1 2 3 5 8

        // Console.WriteLine("Введите число");
        // int number = Convert.ToInt32(Console.ReadLine());
        // if(number < 2)
        // {
        //     Console.WriteLine("Введите число больше 2");
        // }
        // else
        // {
        // int number1 = 0;
        // int number2 = 1;
        // int number3 = 0;
        // Console.WriteLine(number1);
        // Console.WriteLine(number2);
        // for(int j = 0; j < number; j++)
        // {
        //     number3 = number1 + number2;
        //     Console.WriteLine(number3);
        //     number1 = number2;
        //     number2 = number3; 
        // }
        // }


        //Задача 45. Напишите программу, которая будет создавать копию заданного
        //массива с помощью поэлементного копирования.

    //     int[] array = GetArray(10, 0, 10);
    // Console.WriteLine(String.Join(" ", array));

    // int[] copyArray = CopyArray(array);
    // Console.WriteLine(String.Join(" ", copyArray));


    // int[] GetArray(int size, int minValue, int maxValue)
    // {
    //     int[] res = new int[size];

    //     for (int i = 0; i < size; i++)
    //     {
    //         res[i] = new Random().Next(minValue, maxValue + 1);
    //     }
    //     return res;
    // }

    // int[] CopyArray(int[] inArray)
    // {
    //     int[] result = new int[inArray.Length];
    //     for (int i = 0; i < inArray.Length; i++)
    //     {
    //         result[i] = inArray[i];

    //     }
    //     return result;
    // }



// Задачи из 5 семинара
// Задача 32: Напишите программу замена элементов массива: 
// положительные элементы замените на соответствующие отрицательные, и наоборот.
// [-4, -8, 8, 2] -> [4, 8, -8, -2] 

// решение 1
// int [] mass = new int[12];
// for(int i = 0; i < mass.Length; i++)
// {
// mass [i] = new Random().Next(-9, 9);
// Console.Write(" ");
// Console.Write(mass [i]);
// }
// Console.WriteLine();
// for(int i = 0; i < mass.Length; i++)
// {
// mass [i] = mass [i] * -1;
// Console.Write(" ");
// Console.Write(" ");
// Console.Write(mass [i]);
// }

// решение 2

//  int[] CreateRandomArray(int N, int start, int end)
// // {
// // int[] RandomArray = new int[N];
// // for (int i = 0; i < N; i++)
// // {
// // RandomArray[i] = new Random().Next(start, end + 1);
// // }
// // return RandomArray;
// // }
// // void ShowArray(int[] array)
// // {
// // for (int i = 0; i < array.Length; i++)
// // {
// // Console.Write(array[i] + " ");
// // }
// // Console.WriteLine();
// // }


// Задача 33: Задайте массив. Напишите программу, которая определяет, 
// присутствует ли заданное число в массиве.
// 4; массив [6, 7, 19, 345, 3] -> нет
// -3; массив [6, 7, 19, 345, 3] -> да


