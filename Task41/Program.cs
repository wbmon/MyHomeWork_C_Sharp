// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int FillArrayAndSearchPositive(int[] array)
{
    int positive = 0;
    for (int i=0; i < array.Length; i++) 
    {
        Console.Write($"Enter {i+1} number: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) positive++;
    }
return positive;
}

void PrintResult(int[] array, int positive)
{
    Console.Write($"You have been given the following numbers: ");
    for (int i=0; i < array.Length; i++)
    {
    if (i <  array.Length - 1) Console.Write($"{array[i]},  ");
    else Console.WriteLine($"{array[i]}");
    }
    Console.WriteLine($"There are {positive} positive numbers among them.");
}

Console.Clear();
int m = 0;
Console.Write("Set how many numbers we will enter: ");
m = Convert.ToInt32(Console.ReadLine());

int [] arr = new int[m];
int pos = FillArrayAndSearchPositive(arr);
PrintResult(arr, pos);