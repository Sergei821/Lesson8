//  Задайте двумерный массив. 
//  Напишите программу, которая поменяет местами первую и последнюю строку массива.

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
            array[i, j] = rnd.Next(-10, 11);
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

void Swap(int[,] array)
{
    int lastRow = array.GetLength(0) - 1;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        int temp = array[0, j];
        array[0, j] = array[lastRow, j];
        array[lastRow, j] = temp;
    }
}
int cntColumns = ReadInt($"Колличество колоннок");
int cntRows = ReadInt($"Количество строк");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
System.Console.WriteLine();
Swap(table);
Print2DArray(table);