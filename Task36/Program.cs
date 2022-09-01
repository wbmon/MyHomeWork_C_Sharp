// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.


int CreateRandomArray (int dimens, int min, int max)
{
    int [] mas = new int[dimens];
    int sum = 0;
    Console.WriteLine("Array generated: ");
    Console.Write("[");
    for(int i = 0; i < dimens; i++) 
    {
        mas[i] = new Random().Next(min, max+1);
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

Console.Write("Enter the MINIMUM value of the array elements: ");
int minval = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the MAXIMUM value of the array elements: ");
int maxval = Convert.ToInt32(Console.ReadLine());

int sumEl = CreateRandomArray(numberElements, minval, maxval);
Console.WriteLine($"The sum of the elements in odd positions is equal to {sumEl}. ");
