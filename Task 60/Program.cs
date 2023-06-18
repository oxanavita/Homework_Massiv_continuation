// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)



int[,,] GenerateArray(int size1, int size2, int size3)
{
    int[,,] array = new int[size1, size2, size3];
    Random random = new Random();

    int minValue = 10;
    int maxValue = 99;
    int count = size1 * size2 * size3;

    if (count > (maxValue - minValue + 1))
    {
        throw new ArgumentException("Невозможно сформировать трехмерный массив с заданным размером из неповторяющихся двузначных чисел.");
    }

    int[] availableNumbers = new int[maxValue - minValue + 1];
    for (int i = 0; i < availableNumbers.Length; i++)
    {
        availableNumbers[i] = minValue + i;
    }

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                int index = random.Next(0, availableNumbers.Length);
                array[i, j, k] = availableNumbers[index];
                availableNumbers[index] = availableNumbers[availableNumbers.Length - 1];
                Array.Resize(ref availableNumbers, availableNumbers.Length - 1);
            }
        }
    }

    return array;
}

void PrintArrayWithIndices(int[,,] array)
{
    int size1 = array.GetLength(0);
    int size2 = array.GetLength(1);
    int size3 = array.GetLength(2);

    for (int i = 0; i < size1; i++)
    {
        for (int j = 0; j < size2; j++)
        {
            for (int k = 0; k < size3; k++)
            {
                Console.Write($"{array[i, j, k]}({i},{j},{k})".PadRight(14));
                    if (k % 2 == 1)
                    {
                        Console.WriteLine();
                    }
            }
        }
    }
}
int[,,] array = GenerateArray(2, 2, 2);
PrintArrayWithIndices(array);
