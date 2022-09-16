// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.

int InitialData(string inStr)
{
    Console.Write(inStr);
    int outNum = Convert.ToInt32(Console.ReadLine());
    return outNum;
}

int Acker(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return Acker(m - 1, 1);
    else return Acker(m - 1, Acker(m, n - 1));
}

Console.Clear();

int n = InitialData("Set the value of the number N: ");
int m = InitialData("Set the value of the number M: ");

if (n > 0 && m > 0)
{
    Console.Write($"Ackerman function = {Acker(m, n)} ");
}
else Console.Write($"Please enter a number greater than 0 next time.");

