// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

double[] CreateArray(int n, int min, int max)
{
    double[] mas = new double[n];

    Console.WriteLine("Array generated: ");
    Console.Write("[");

    Random rnd = new Random();
        for (int i = 0; i < mas.GetLength(0); i++)
        {
            mas[i] = Math.Round((rnd.NextDouble() * (max - min) + min), 2);

            if (i < n - 1) Console.Write($"{mas[i]}, ");
            else Console.Write($"{mas[i]}");
            
        }
    Console.WriteLine("]");
    return mas;
}

Console.Clear();
Console.Write("Enter the dimension of the array: ");
int dimens=Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the LOWER limit of the range of values: ");
int minlim = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the UPPER limit of the range of values: ");
int maxlim = Convert.ToInt32(Console.ReadLine());


double[] massive = CreateArray(dimens, minlim, maxlim);
double dif = 0;
double minval = massive[0];
double maxval = massive[0];
    for (int i = 0; i < massive.GetLength(0); i++)
        {
            if (minval > massive[i]) minval = massive[i];
            if (maxval < massive[i]) maxval = massive[i];
        }
dif = Math.Round(maxval - minval,2);
 Console.WriteLine($"The difference between the maximum {maxval} and minimum {minval} elements of the array: {dif}");