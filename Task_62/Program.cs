public class SpiralArray
{
    static void Main()
    {
        int[,] array = new int[4, 4];

        int value = 2;
        int row = 0;
        int col = 0;
        int size = 3;

        while (value <= size * size)
        {
            // заполнение верхней строки
            for (int i = col; i < size - col; i++)
            {
                array[row, i] = value;
                value++;
            }

            // заполнение правого столбца
            for (int i = row + 1; i < size - row; i++)
            {
                array[i, size - col - 1] = value;
                value++;
            }

            // заполнение нижней строки
            for (int i = size - col - 2; i >= col; i--)
            {
                array[size - row - 1, i] = value;
                value++;
            }

            // заполнение левого столбца
            for (int i = size - row - 2; i > row; i--)
            {
                array[i, col] = value;
                value++;
            }

            row++;
            col++;
        }

        // вывод массива на консоль
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size; j++)
            {
                Console.Write("{0:D2} ", array[i, j]);
            }
            Console.WriteLine();
        }
    }
}
// просто добвлю комментарий