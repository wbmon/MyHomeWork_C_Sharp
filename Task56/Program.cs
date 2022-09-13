// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

int[,] CreateArray()
{
    Console.Write("Set the number of rows in the array: ");
    int dimensM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Set the number of columns in the array: ");
    int dimensN = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the minimum value of the elements in the array: ");
    int minimum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of the elements in the array: ");
    int maximum = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"m = {dimensM}, n = {dimensN}.");
    int[,] array = new int[dimensM, dimensN];

    for (int i = 0; i < dimensM; i++)
        for (int j = 0; j < dimensN; j++)
            array[i, j] = new Random().Next(minimum, maximum + 1);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) { Console.Write("{0,6}", array[i, j] + "  "); }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void PrintColorArray(int[,] array, int row)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        if (i == row) Console.ForegroundColor = ConsoleColor.Red;
        else Console.ResetColor();
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write("{0,6}", array[i, j] + "  ");
        }
        Console.WriteLine();
    }
}

int FindingMinimumElement(int[,] array)
{
    int rowMinSum = 0;
    int rowSum = SumElementsInRow(array, 0);
    for (int i = 1; i < array.GetLength(0); i++)
    {
        int tempRowSum = SumElementsInRow
    (array, i);
        if (rowSum > tempRowSum)
        {
            rowSum = tempRowSum;
            rowMinSum = i;
        }
    }
    Console.WriteLine($"In {rowMinSum + 1} row, the sum of the elements is minimal and equal to {rowSum}.");
    return rowMinSum;
}

int SumElementsInRow(int[,] array, int i)
{
    int rowSum = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        rowSum += array[i, j];
    }
    return rowSum;
}

Console.Clear();
int[,] array = CreateArray();
Console.WriteLine("Initial array: ");
PrintArray(array);

int rowMin = FindingMinimumElement(array);
PrintColorArray(array, rowMin);