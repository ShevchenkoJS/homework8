// Задача 54: Задайте двумерный массив. 
// Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2


Console.Clear();
Random rnd = new Random();
double[,] FillArray() 
{
    Console.WriteLine("Введите размер массива (m*n): ");
    var (m, n) = (Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine()));
    Console.WriteLine("Создание двумерного массива...");
    Console.WriteLine();
    double[,] array = new double[m, n];
    Console.WriteLine();
    for (int i = 0; i < array.GetLength(0); i++) 
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(1, 10);
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
    Console.WriteLine();
    return array;
}

double[,] array = FillArray();

Console.WriteLine("Сортировка массива");
for (int i = 0; i < array.GetLength(0); i++)
{
    Console.Write("[ ");
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int maxVal = j;
        for (int k = j + 1; k < array.GetLength(1); k++)
        {
            if (array[i, k] > array[i, maxVal]) maxVal = k;
        }
        double tempVal = array[i, j];
        array[i, j] = array[i, maxVal];
        array[i, maxVal] = tempVal;
        Console.Write(array[i, j] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}
Console.ReadKey();
