static int FindRowWithMinSum(int[,] array)
{
    int minSum = int.MaxValue;
    int minRow = -1;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        if (sum < minSum)
        {
            minSum = sum;
            minRow = i+1;
        }
    }

    return minRow;
}
// проверка
int[,] array = new int[4, 4] { {1, 4, 7, 2}, {5, 9, 2, 3}, {8, 4, 2, 4}, {5, 2, 6, 7} };
int minRow = FindRowWithMinSum(array);
Console.WriteLine("Row with minimum sum of elements is: " + minRow);
