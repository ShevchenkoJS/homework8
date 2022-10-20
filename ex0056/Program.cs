// Задача 56: Задайте прямоугольный двумерный массив. 
// Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

Random rnd = new Random();

Console.Clear();
Console.Write("Введите размер массива N: ");
int arrSize = Convert.ToInt32(Console.ReadLine());
int[,] array = new int[arrSize, arrSize];
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        array[i, j] = rnd.Next(1, 10);
        Console.Write($"{array[i, j]} ");
    }
    Console.WriteLine("]");
}
Console.WriteLine();

int[] sumArray = new int[arrSize]; 
for (int i = 0; i < sumArray.Length; i++)
{
    int sumRow = 0;
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(0); j++)
    {
        sumRow += array[i, j];
    }
    sumArray[i] = sumRow;
    Console.Write($"Сумма {i + 1} строки равна {sumRow} ");
    Console.WriteLine("]");
}

int minVal = 0;
for (int i = 1; i < sumArray.Length; i++)
{
    if (sumArray[i] < sumArray[minVal]) minVal = i;
}
Console.WriteLine($"Номер строки с ноименьшей суммой: {minVal + 1}");
Console.ReadKey();