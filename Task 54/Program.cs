// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortArray (int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        // Создание временного одномерного массива для сортировки строки
        int[] row = new int[array.GetLength(1)];
        for (int j = 0; j < array.GetLength(1); j++)
        {
            row[j] = array[i, j];
        }

        // Сортировка элементов строки по убыванию
        Array.Sort(row, (a, b) => b.CompareTo(a));

        // Обратное копирование отсортированной строки в исходный двумерный массив
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = row[j];
        }
    }
}


System.Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите количество столбцов: ");
int cols = Convert.ToInt32(Console.ReadLine());
int [,] array = new int[rows, cols];
FillArray (array);
PrintArray (array);
SortArray (array);
Console.WriteLine();
PrintArray (array);
