// Задайте двумерный массив из целых чисел. 
// Напишите программу, которая удалит строку и столбец, 
// на пересечении которых расположен наименьший элемент массива.

int ReadInt(string message)
{
    System.Console.Write($"{message} > ");
    return Convert.ToInt32(Console.ReadLine());
}

int[,] Generate2DArray(int cntRows, int cntColumns)
{
    int[,] array = new int[cntRows, cntColumns];
    Random rnd = new Random();
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = rnd.Next(0, 10);
        }
    }
    return array;
}

void Print2DArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j]}\t");
        }
        System.Console.WriteLine();
    }
}

(int, int) Min(int[,] array)
{
    int minI = 0;
    int minJ = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[minI, minJ] > array[i, j])
            {
                minI = i;
                minJ = j;
            }
        }
    }
    return (minI, minJ);
}
int[,] DeletMinElemment(int[,] array)
{
    (int minI, int minJ) = Min(array);
    int[,] result = new int[array.GetLength(0) - 1, array.GetLength(1) - 1];
    int ind1 = 0;
    int ind2 = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (minI == i)
        {
            continue;
        }
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (minJ == j)
            {
                continue;
            }
            result[ind1, ind2] = array[i, j];
            ind2++;
        }
        ind1++;
        ind2 = 0;
    }
    return result;
}
int cntColumns = ReadInt($"Колличество колоннок");
int cntRows = ReadInt($"Количество строк");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine(Min(table));
Print2DArray(DeletMinElemment(table));