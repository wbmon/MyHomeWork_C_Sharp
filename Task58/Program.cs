// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.

int[,] CreateArray(string matrix)
{
    Console.Write($"Set the number of rows in the matrix {matrix}: ");
    int dimensM = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Set the number of columns in the matrix {matrix}: ");
    int dimensN = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter the minimum value of the elements in the matrix {matrix}: ");
    int minimum = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Enter the maximum value of the elements in the matrix {matrix}: ");
    int maximum = Convert.ToInt32(Console.ReadLine());

    int[,] array = new int[dimensM, dimensN];

    for (int i = 0; i < dimensM; i++)
        for (int j = 0; j < dimensN; j++)
            array[i, j] = new Random().Next(minimum, maximum + 1);
    return array;
}

bool CheckPossibilMultiplication(int rowA, int colB)
{
    bool result = false;
    if (rowA == colB) result = true;
    return result;
}

void PrintArray(int[,] array, string matrix)
{
    Console.WriteLine($"The matrix {matrix}:");
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++) { Console.Write("{0,6}", array[i, j] + "  "); }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MultMatrix(int[,] matrixA, int[,] matrixB, int[,] matrixC)
{
    for (int i = 0; i < matrixC.GetLength(0); i++)
    {
        for (int j = 0; j < matrixC.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrixA.GetLength(1); k++)
            {
                sum += matrixA[i, k] * matrixB[k, j];
            }
            matrixC[i, j] = sum;
        }
    }
}

Console.Clear();
int[,] arrayA = CreateArray("A");
int[,] arrayB = CreateArray("B");

PrintArray(arrayA, "A");
PrintArray(arrayB, "B");

int[,] matrixC = new int[arrayA.GetLength(0), arrayB.GetLength(1)];

bool check = CheckPossibilMultiplication(arrayA.GetLength(0), arrayB.GetLength(1));
if (check == false) Console.WriteLine("These matrices cannot be multiplied!");
else
{
    MultMatrix(arrayA, arrayB, matrixC);
    Console.Write("The multiplication of these matrices is ");
    PrintArray(matrixC, "AxB");
}

