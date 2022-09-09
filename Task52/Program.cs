// Задача 52: Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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
  
  int[,] array = new int[dimensM, dimensN];
  for (int i = 0; i < dimensM; i++)
      for (int j = 0; j < dimensN; j++)
        array[i, j] = new Random().Next(minimum, maximum + 1);
  return array;
}

void PrintArray (int[,] array)
{
  for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) Console.Write("{0,6}", array[i, j] + "  ");
        Console.WriteLine();
    }
}

void Mean(int[,] array)
{
  Console.WriteLine("The arithmetic mean of the");
  for (int i = 0; i < array.GetLength(1); i++)
  {
    double arithmeticMean = 0;
    for (int j = 0; j < array.GetLength(0); j++) arithmeticMean += array[j, i];
    arithmeticMean = Math.Round(arithmeticMean / array.GetLength(0), 1);
    Console.WriteLine($"{i+1} column is {arithmeticMean}");
  }
}

Console.Clear();
int[,] array = CreateArray();
PrintArray(array);
Mean(array);