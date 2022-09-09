// Задача 50: Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

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

void SearchPosition(int[,] array)
{
int[] position = new int[2];
Console.Write("Enter the row number of the element we will be looking for: ");
position[0] = Convert.ToInt32(Console.ReadLine());
Console.Write("And now set the column number: ");
position[1] = Convert.ToInt32(Console.ReadLine());

if(position[0] <= array.GetLength(0) && position[1] <= array.GetLength(1) && position[0] >= 0 && position[1] >= 0) 
{
  int result = array[position[0]-1, position[1]-1];
  Console.Write($"There is an element ({position[0]},{position[1]}) in the array and its value is {result}");
}
else Console.Write($"Oops, but there is no element with indexes ({position[0]},{position[1]}) in this array.");
}

Console.Clear();
int[,] array = CreateArray();
PrintArray(array);
SearchPosition(array);