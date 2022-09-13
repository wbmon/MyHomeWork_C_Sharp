// Задача 60: Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.

int[,,] CreateArray()
{
    Console.Write($"Specify the dimension of the array X: ");
    int x = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Specify the dimension of the array Y: ");
    int y = Convert.ToInt32(Console.ReadLine());
    Console.Write($"Specify the dimension of the array Z: ");
    int z = Convert.ToInt32(Console.ReadLine());

    int[,,] array3D = new int[x, y, z];
    int[] array1D = new int[x * y * z];
    int element;

    for (int i = 0; i < x * y * z; i++)
    {
        array1D[i] = new Random().Next(10, 100);
        element = array1D[i];
        if (i >= 1)
        {
            for (int j = 0; j < i; j++)
            {
                while (array1D[i] == array1D[j])
                {
                    array1D[i] = new Random().Next(10, 100);
                    j = 0;
                    element = array1D[i];
                }
                element = array1D[i];
            }
        }
    }
    int count = 0;
    for (int i = 0; i < x; i++)
    {
        for (int j = 0; j < y; j++)
        {
            for (int k = 0; k < z; k++)
            {
                array3D[i, j, k] = array1D[count];
                count++;
            }
        }
    }
    return array3D;
}

void PrintArray(int[,,] array3D)
{
    Console.WriteLine("The 3D-matrix is filled with two-digit non-repeating numbers:");
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            for (int k = 0; k < array3D.GetLength(2); k++)
            {
                Console.Write("{0,14}", $"{array3D[i, j, k]} ({i},{j},{k}) ");
            }
            Console.WriteLine();
        }
    }
}

Console.Clear();

int[,,] array3D = CreateArray();
Console.WriteLine();
PrintArray(array3D);