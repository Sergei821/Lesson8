// Составить частотный словарь элементов двумерного массива. 
// Частотный словарь содержит информацию о том,
// сколько раз встречается элемент входных данных. Значения элементов массива 0..9

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

int[] Freqence(int[,] array)
{
    int[] Group = new int[10];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int index = array[i, j];
            Group[index]++;
        }
    }
    return Group;
}
void PrintArray(int[] Group)
{
    for (int i = 0; i < Group.Length; i++)
    {
        System.Console.WriteLine($"{i}-{Group[i]}");
    }
}
int cntColumns = ReadInt($"Колличество колоннок");
int cntRows = ReadInt($"Количество строк");
int[,] table = Generate2DArray(cntColumns, cntRows);
Print2DArray(table);
int [] freqence = Freqence(table);
PrintArray(freqence);
System.Console.WriteLine();