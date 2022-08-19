// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.

Console.Clear();

Console.Write("Enter the first integer: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the third integer: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (number2 > number1)
    max = number2;

if (number3 > max)
    max = number3;

Console.WriteLine($"Of the three numbers {number1}, {number2} and {number3}, the maximum is the number {max}.");
