// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07



int[,] GenerateSpiralArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];

    int currentValue = 1;
    int rowStart = 0;
    int rowEnd = rows - 1;
    int colStart = 0;
    int colEnd = cols - 1;

    while (currentValue <= rows * cols)
    {
        // Заполнение верхней строки
        for (int col = colStart; col <= colEnd; col++)
        {
            array[rowStart, col] = currentValue++;
        }
        rowStart++;

        // Заполнение правого столбца
        for (int row = rowStart; row <= rowEnd; row++)
        {
            array[row, colEnd] = currentValue++;
        }
        colEnd--;

        // Заполнение нижней строки
        for (int col = colEnd; col >= colStart; col--)
        {
            array[rowEnd, col] = currentValue++;
        }
        rowEnd--;

        // Заполнение левого столбца
        for (int row = rowEnd; row >= rowStart; row--)
        {
            array[row, colStart] = currentValue++;
        }
        colStart++;
    }

    return array;
}

void PrintArray(int[,] array)
{
    int rows = array.GetLength(0);
    int cols = array.GetLength(1);

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < cols; j++)
        {
            Console.Write($"{array[i, j],2} ");
        }
        Console.WriteLine();
    }
}

int[,] array = GenerateSpiralArray(4, 4);
PrintArray(array);