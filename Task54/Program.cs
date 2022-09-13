//Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.

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
        for (int j = 0; j < array.GetLength(1); j++)
        {
            int roundedValue = array[i, j];
            Console.Write("{0,6}", roundedValue + "  ");
        }
        Console.WriteLine();
    }
}

void SortedArrayLines(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if (array[i, k] < array[i, k + 1])
                {
                    int temp = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = temp;
                }
            }
        }
    }
}

Console.Clear();
int[,] array = CreateArray();
Console.WriteLine("Initial array: ");
PrintArray(array);

Console.WriteLine("An array with elements sorted in descending order in each row: ");
SortedArrayLines(array);
PrintArray(array);