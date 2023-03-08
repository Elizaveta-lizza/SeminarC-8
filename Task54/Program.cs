int GetIncomingData(string message)
{
    Console.WriteLine(message);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Create2DArray(int col, int row)
{
    return new int[row, col];
}

void Fill2DArray(int[,] array2D, int low, int high)
{
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < array2D.GetLength(1); j++)
        {
            array2D[i, j] = new Random().Next(low, high);
        }
    }
}

void Print2DArray(int[,] array2D)
{
    int LastCol = array2D.GetLength(1);
    for (int i = 0; i < array2D.GetLength(0); i++)
    {
        for (int j = 0; j < LastCol; j++)
        {
            if (j == LastCol - 1)
            {
                Console.Write(array2D[i, j]);
            }
            else
            {
                Console.Write($"{array2D[i, j]};");
            }
        }
        Console.WriteLine();
    }
}

void SortRow2DArray(int[,] array2D)
{
    int Temp;
    for (int row = 0; row < array2D.GetLength(0); row++)
    {
        // BubbleSort
        for (int i = 0; i < array2D.GetLength(1); i++)
        {
            for (int j = i + 1; j < array2D.GetLength(1); j++)
            {
                if (array2D[row, i] < array2D[row, j])
                {
                    Temp = array2D[row, i];
                    array2D[row, i] = array2D[row, j];
                    array2D[row, j] = Temp;
                }
            }
        }
    }
}

int col = GetIncomingData("Введите количество столбцов");
int row = GetIncomingData("Введите количество строк");
int[,] arr2D = Create2DArray(col, row);
int low = GetIncomingData("Введите нижнюю границу значений элементов массива");
int high = GetIncomingData("Введите верхнюю границу значений элементов массива");
Fill2DArray(arr2D, low, high);
Console.WriteLine("Массив до сортировки");
Print2DArray(arr2D);
SortRow2DArray(arr2D);
Console.WriteLine("Массив после сортировки");
Print2DArray(arr2D);