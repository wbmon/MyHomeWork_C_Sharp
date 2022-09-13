// Задача 62: Заполните спирально массив N на N.

int[,] CreateArray()
{
    Console.Write("Specify the dimension of the array N: ");
    int dimens = Convert.ToInt32(Console.ReadLine());

    int[,] spiralMatrix = new int[dimens, dimens];
    int temp = 1;
    int i = 0;
    int j = 0;

    while (temp <= spiralMatrix.GetLength(0) * spiralMatrix.GetLength(1))
    {
        spiralMatrix[i, j] = temp;
        temp++;
        if (i <= j + 1 && i + j < spiralMatrix.GetLength(1) - 1)
            j++;
        else if (i < j && i + j >= spiralMatrix.GetLength(0) - 1)
            i++;
        else if (i >= j && i + j > spiralMatrix.GetLength(1) - 1)
            j--;
        else
            i--;
    }
    return spiralMatrix;
}

void PrintArray(int[,] spiralMatrix)
{
    var r = new Random();
    Console.SetCursorPosition(0, 2);
    for (int i = 0; i < spiralMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < spiralMatrix.GetLength(1); j++)
        {
            Console.ForegroundColor = (ConsoleColor)r.Next(16);
            Console.Write("{0,6}", spiralMatrix[i, j] + "  ");
        }
        Console.WriteLine();
    }
    Console.ResetColor();
    Console.SetCursorPosition(0, 4 + spiralMatrix.GetLength(0));
}

Console.Clear();
int[,] array = CreateArray();
PrintArray(array);