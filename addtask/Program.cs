// Дополнительная задача (задача со звёздочкой): Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

Console.Clear();
static IEnumerable<int> UniqueRandomNumbers(int from, int to) 
{
    Random rand = new();
    int[] values = Enumerable.Range(from, to).ToArray();
    int i = values.Length;
    while (i > 0)
    {
        int j = rand.Next(i--);
        yield return values[j];

        (values[i], values[j]) = (values[j], values[i]);
    }
}

int[,,] matrix = new int[2, 2, 2]; 
IEnumerator<int> iterator = UniqueRandomNumbers(10, 99).GetEnumerator();
for (int i = 0; i < matrix.GetLength(0); i++)
    for (int j = 0; j < matrix.GetLength(1); j++)
        for (int k = 0; k < matrix.GetLength(2); k++)
        {
            if (!iterator.MoveNext())
            {
                Console.WriteLine("Уникальных чисел больше нет!");
                return;
            }

            matrix[i, j, k] = iterator.Current;
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
Print3D(matrix);
