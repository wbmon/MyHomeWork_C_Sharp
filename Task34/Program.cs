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
        if (mas[i] % 2 == 0) sum ++;
    }
    Console.WriteLine("]");
    return sum;
}

Console.Clear();
Console.Write("Enter the dimension of the array: ");
int numberElements = Convert.ToInt32(Console.ReadLine());

int numEl = CreateRandomArray(numberElements, 100, 1000);
Console.WriteLine($"Even elements in the array {numEl}. ");
