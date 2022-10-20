// Задача 58: Задайте две матрицы. 
// Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

Console.Clear();
Random rnd = new Random();
int[,] Multiplication(int[,] matrix1, int[,] matrix2) 
{
    if (matrix1.GetLength(1) != matrix2.GetLength(0)) throw new Exception("Матрицы нельзя перемножить");
    int[,] res = new int[matrix1.GetLength(0), matrix2.GetLength(1)];
    for (int i = 0; i < matrix1.GetLength(0); i++)
    {
        for (int j = 0; j < matrix2.GetLength(1); j++)
        {
            for (int k = 0; k < matrix2.GetLength(0); k++)
            {
                res[i, j] += matrix1[i, k] * matrix2[k, j];
            }
        }
    }
    return res;
}

void Print(int[,] array) 
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[ ");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j]} \t");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

void Print3D(int[,,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int depth = matrix.GetLength(2);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < depth; k++)
            {
                Console.Write($"{matrix[i, j, k]} ({i},{j},{k}) \t");
            }
            Console.WriteLine();
        }
    }
}
Console.WriteLine("Введите размерность матрицы А: ");
int[,] matrix1 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrix1.GetLength(0); i++)
{
    for (int j = 0; j < matrix1.GetLength(1); j++)
    {
        matrix1[i, j] = rnd.Next(1, 10);
    }
}

Console.WriteLine("Введите размерность матрицы B: ");
int[,] matrix2 = new int[Convert.ToInt32(Console.ReadLine()), Convert.ToInt32(Console.ReadLine())];
for (int i = 0; i < matrix2.GetLength(0); i++)
{
    for (int j = 0; j < matrix2.GetLength(1); j++)
    {
        matrix2[i, j] = rnd.Next(1, 10);
    }
}

Console.WriteLine("\nМатрица A:");
Print(matrix1);
Console.WriteLine("\nМатрица B:");
Print(matrix2);
Console.WriteLine("\nМатрица C = A * B:");
int[,] matrixRes = Multiplication(matrix1, matrix2);
Print(matrixRes);
Console.ReadKey();
