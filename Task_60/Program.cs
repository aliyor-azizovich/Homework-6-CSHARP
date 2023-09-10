public class ThreeDimensionalArray
{
    static void Main()
    {
        int[,,] array = new int[2, 2, 2];
        int value = 10;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = value;
                    value++;
                }
            }
        }

        // вывод массива на консоль
        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.Write("{0:D2}({1},{2},{3}) ", array[i, j, k], i, j, k);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
