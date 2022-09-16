// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

void PrintNumber(int n, int m)
{
    if (n != m) Console.Write(n + ", ");
    else Console.Write(n);
    if (n < m) PrintNumber(n + 1, m);
}

int InitialData(string inStr)
{
    Console.Write(inStr);
    int outNum = Convert.ToInt32(Console.ReadLine());
    return outNum;
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

PrintNumber(n, m);