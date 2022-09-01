// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int CreateRandomArray (int dimens, int min, int max)
{
    int [] mas = new int[dimens];
    int sum = 0;
    Console.WriteLine("Array generated: ");
    Console.Write("[");
    for(int i = 0; i < dimens; i++) 
    {
        mas[i] = new Random().Next(min, max);
        if (i < dimens - 1) Console.Write($"{mas[i]}, ");
            else Console.Write($"{mas[i]}");
        if (i % 2 != 1) sum += mas[i];
    }
    Console.WriteLine("]");
    return sum;
}

Console.Clear();
Console.Write("Enter the dimension of the array: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int sumEl = CreateRandomArray(numberElements, 100, 1000);
Console.WriteLine($"The sum of the elements in odd positions is equal to {sumEl}, ");
