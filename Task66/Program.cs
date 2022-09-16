// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int InitialData(string inStr)
{
    Console.Write(inStr);
    int outNum = Convert.ToInt32(Console.ReadLine());
    return outNum;
}

void PrintSumma(int m, int n, int summa)
{
    summa = summa + n;
    if (n <= m)
    {
        Console.Write($"The sum of the numbers from N to M is equal to {summa} ");
        return;
    }
    PrintSumma(m, n - 1, summa);
}

Console.Clear();

int n = InitialData("Set the value of the number N: ");
int m = InitialData("Set the value of the number M: ");

if (m < n)
{
    int temp = m;
    m = n;
    n = temp;
}

PrintSumma(n, m, 0);