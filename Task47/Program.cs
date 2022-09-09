// Задача 47: Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateArray()
{
    Console.Write("Set the number of rows in the array: ");
    int dimensM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Set the number of columns in the array: ");
    int dimensN = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the minimum value of the elements in the array: ");
    int minimum = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the maximum value of the elements in the array: ");
    int maximum = Convert.ToInt32(Console.ReadLine());
    double[,] array = new double[dimensM, dimensN];
    for (int i = 0; i < dimensM; i++)
        for (int j = 0; j < dimensN; j++)
          array[i, j] = new Random().NextDouble() * (maximum - minimum) + minimum ;
    return array;
}

void PrintArray (double[,] array)
{
for (int i = 0; i < array.GetLength(0); i++)
  {
      for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0,10}", Math.Round(array[i, j], 1) + "  ");
      Console.WriteLine();
  }
}

Console.Clear();

double[,] array = CreateArray();

PrintArray(array);