// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.

  int SumDigits(int N)
  {
    int counter = Convert.ToString(N).Length;
    int step = 0;
    int res = 0;

    for (int i = 0; i < counter; i++)
    {
      step = N - N % 10;
      res = res + (N - step);
      N = N / 10;
    }
   
   return res;
  }

Console.Clear();

Console.Write("Enter a number N: ");
int numN = Convert.ToInt32(Console.ReadLine());

int sum = SumDigits(numN);
Console.WriteLine($"The sum of the digits in the number {numN} is equal to " + sum);