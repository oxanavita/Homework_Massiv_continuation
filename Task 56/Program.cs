// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

void FillArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array[i, j] = new Random().Next(1,10); 
            }
        }
}

void PrintArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                Console.Write($"{array[i,j],2}    ");
            }
        Console.WriteLine();
        }
}

int NumRowsArray (int[,] array)
{
    int numRows = array.GetLength(0);
    int numCols = array.GetLength(1);

    int minRowSum = int.MaxValue;
    int minRowNum = -1;

    for (int i = 0; i < numRows; i++)
    {
        int rowSum = 0;
        for (int j = 0; j < numCols; j++)
        {
            rowSum += array[i, j];
        }

        if (rowSum < minRowSum)
        {
            minRowSum = rowSum;
            minRowNum = i;
        }
    }
    return minRowNum;
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows, cols];
FillArray (array);
PrintArray (array);
int rowNum = NumRowsArray(array);
Console.WriteLine($"Строка с наименьшей суммой элементов: {rowNum + 1} строка");

