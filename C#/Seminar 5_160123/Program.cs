// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Создание и вывод массива

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

// void ShowArray(int[] array)
// {
// for (int i = 0; i < array.Length; i++)
// {
// Console.Write(array[i] + " ");
// }
// Console.WriteLine();
// }


// Console.Clear();

// Console.WriteLine("Введите количество элементов в массиве");
// int num = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите первое число случайно генерируемого диапазона");
// int min = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("Введите последнее число случайно генерируемого диапазона");
// int max = Convert.ToInt32(Console.ReadLine());

// int[] myRandomArray = CreateRandomArray(num, min, max);
// ShowArray(myRandomArray);
// Console.WriteLine("-------");
// int[] myArray = CreateArray();
// ShowArray(myArray);


// Задача 31: Задайте массив из 12 элементов, заполненный случайными числами
//  из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов
//  массива.
// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int[] CreateRandomArray(int N, int start, int end)
{
int[] RandomArray = new int[N];
for (int i = 0; i < N; i++)
{
RandomArray[i] = new Random().Next(start, end + 1);
}
return RandomArray;
}
 void ShowArray(int[] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write(array[i] + " ");
}
Console.WriteLine();
}
int[] Array1 = CreateRandomArray(12, -9, 9);
ShowArray(Array1);

int positive = 0;
int negative = 0;
for (int i = 0; i < Array1.Length; i++)
{
if (Array1[i] > 0){positive += Array1[i];}
else{negative += Array1[i];}
}

Console.WriteLine($"Сумма позитивных = {positive}\nСумма негативных = {negative}");