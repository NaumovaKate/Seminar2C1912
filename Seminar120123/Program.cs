// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Задача 24: Напишите программу, которая принимает на вход число (А)
//  и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

// Console.Clear();
// Console.WriteLine("Введите любое число: ");
// int a = Convert.ToInt32(Console.ReadLine());
//  int all = 0;
//  for (int x = 0; x <= a; x++)
// {
//     all = all + x;
//     Console.WriteLine(x);
//     Console.WriteLine(all);
// }
// Console.Write(all);

//Решение 2

// Console.Write("Введите целое число: ");
// if (!int.TryParse(Console.ReadLine(), out int A))
// {
// Console.Write("Вы ввели некорректное значение!");
// }
// else
// {
// int sum = 0;
// for (int i =1; i<=A; i++)
// {
// sum = sum +i;
// }
// Console.Write("Сумма чисел от 1 до {0} равна {1}", A, sum);
// }

// Решение 3 через функцию, а не линейное

// int Fx(int a)
// {
//     int all = 0;
//     for (int x = 0; x <= a; x++)
//     {
//         all += x;
//     }
//     return all;
// }

// Console.WriteLine(Fx(5));
// Console.WriteLine(Fx(6));

// Решение 4

// int SumOfNumberFrom(int from, int number)
// {
// int sum = 0;
// for (int i=from;i<=number;i++)
// {
// sum += i;
// }
// return sum;
// }

// Console.WriteLine("Input number");

// int number = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine($"Sum is {SumOfNumberFrom(1, number)}");

// Решение 5

// Console.Clear();

// int a = int.Parse(Console.ReadLine());

// int Sum(int num)
// {
// int sum = 0;
// for (int i = 1; i <= num; i++) sum+= i;
// return sum;
// }
// Console.Write(Sum(a));

// Решение 6 через функцию Void

// void GetSumNums(int number)
// {
// int sum = 0;
// for (int i = 1; i <= Math.Abs(number); i++)
// {
// sum += i;
// }
// Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");
// }

// Console.Clear();

// GetSumNums(-5);
// GetSumNums(58);
// GetSumNums(25);
// GetSumNums(16);

// Console.WriteLine("Введите число A");
// int n = Convert.ToInt32(Console.ReadLine());
// GetSumNums(n);

// Console.WriteLine("Введите число A");
// GetSumNums(Convert.ToInt32(Console.ReadLine()));

// Задача 26: Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе.
// 456 -> 3
// 78 -> 2
// 89126 -> 5

// решение 1
// void CountNumbs(int numb)
// {
// int result = 0;
// while(numb > 0)
// {
// numb = numb / 10;
// result++;
// }
// Console.WriteLine(result);
// }
// Console.WriteLine("Введите число");
// CountNumbs(Convert.ToInt32(Console.ReadLine()));

// решение 2 (более полное с нулями и минусами)

// void CountNumbs(int numb)
// {
// int result = 0;
// if (numb == 0)
// {
// result = 1;
// }
// while(numb > 0)
// {
// numb = numb / 10;
// result++;
// }
// Console.WriteLine(result);
// }

// Console.WriteLine("Введите число");
// CountNumbs(Math.Abs(Convert.ToInt32(Console.ReadLine())));

// Задача 28: Напишите программу, которая принимает на вход число N и 
// выдаёт произведение чисел от 1 до N.
// 4 -> 24 
// 5 -> 120

// void GetSumNums(int number)
// {
// int sum = 0;
// for (int i = 1; i <= Math.Abs(number); i++)
// {
// sum += i;
// }
// Console.WriteLine($"Cумма цифр от 1 до {Math.Abs(number)}: {sum}");

// }

// Console.Clear();

// GetSumNums(-5);
// GetSumNums(58);
// GetSumNums(25);
// GetSumNums(16);

// Console.WriteLine("Введите число A");
// int n = Convert.ToInt32(Console.ReadLine());
// GetSumNums(n);


// int MultOfNumb(int numb) // в этой строке функция, которая возвращает целочисленное значение
//                             // через функцию return
// {
//     int x = 1;
//     for(int i = 1; i <= numb; i++)
// {
//     x = x * i;
//     Console.WriteLine(x);
// }
//     return x;
// }
// Console.WriteLine("Введите число: ");
// int numb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine(MultOfNumb(numb));

// Console.Clear();
// Console.Write("Напишите число (N): ");
// int sum = 1;
// int a = int.Parse(Console.ReadLine());
// for (int i = 1; i <=a; i++)
// {
// sum *= i;
// }
// Console.Write(sum);

// Console.Clear();

// MultOfNumb(2);
// MultOfNumb(4);
// MultOfNumb(6);
// MultOfNumb(8);

// Console.WriteLine("Введите число A");
// int n = Convert.ToInt32(Console.ReadLine());
// MultOfNumb(n);



// Задача 30: Напишите программу, которая выводит массив из 8 элементов, заполненный нулями
// и единицами в случайном порядке.
// [1,0,1,1,0,1,0,0]

// Решение 1

// int [] mass = new int[8];
// for(int i = 0; i < mass.Length; i++)
// {
// mass [i] = new Random().Next(2);
// Console.Write(mass [i]);
// }

// Решение 2

int[] arr = new int[int.Parse(Console.ReadLine())];

void ArrTrueFalse(int[] array)
{
for (int i = 0; i < arr.Length; i++)
{
arr[i] = new Random().Next(0, 2);
Console.Write(arr[i]);
}
}
