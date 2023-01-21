// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

// Урок 5. Функции и одномерные массивы

// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2
// Console.Clear();

// решение задачи 34:

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

// int[] Array1 = CreateRandomArray(8, 100, 500);
// ShowArray(Array1);

// int evenNumbers = 0;

// for (int i = 0; i < Array1.Length; i++)
// {
// if (Array1[i] % 2 == 0)
// evenNumbers++;
// }
// Console.WriteLine($"Количество четных чисел в массиве = {evenNumbers}");





// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

// решение задачи 36:

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
// Console.WriteLine(" - это одномерный массив");
// }

// int[] Numbers = CreateRandomArray(5, 5, 30);
// ShowArray(Numbers);

// int oddEl = 0;

// for (int i = 0; i < Numbers.Length; i+=2)
// oddEl = oddEl + Numbers[i];
// Console.WriteLine($"Сумма нечетных элементов в массиве = {oddEl}");




// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

// решение задачи 38:

Console.Clear();
int[] startArray = GetArray(6, 0, 99);
Console.WriteLine(String.Join(" ", startArray));
Console.WriteLine($"Разница = {GetDifference(startArray)}");

int[] GetArray(int size, int minValue, int maxValue)
{
    int [] res = new int[size];
    for (int i = 0; i < size; i++)
    {
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}
 int GetDifference(int[] array)
 {
    int min = array[0];
    int max = array[0];
    foreach (var item in array)
    {
        if (min > item) min = item;
        if (max < item) max = item;
    }
    return max - min;
 }






// int[] CreatRandomArray = new int[massiv];
// for (int i = 0; i < massiv.Length - 1; i++)
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
// Console.WriteLine(" - это одномерный массив");
// }

// int[] El = CreateRandomArray(7, -20, 30);
// ShowArray(El);
// int Mass = 0;
//  for (int i = 0; i < El.Length; i++)

// // решение 3:
// int[]
// int temp;
// for (int i = 0; i < nums.Length - 1; i++)
// {
//     for (int j = i + 1; j < nums.Length; j++)
//     {
//         if (nums[i] > nums[j])
//         {
//             temp = nums[i];
//             nums[i] = nums[j];
//             nums[j] = temp;
//         }
//     }
// }
//  Console.WriteLine("Вывод отсортированного массива");
// for (int i = 0; i < nums.Length; i++)
// {
//     Console.WriteLine(nums[i]);
// }