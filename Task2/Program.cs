// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.Clear();

Console.Write("Enter the first integer: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second integer: ");
int number2 = Convert.ToInt32(Console.ReadLine());

if (number1 > number2)
{
    Console.WriteLine($"Of the numbers {number1} and {number2}, the largest number is the number {number1}, and the smallest is the number {number2}");
}
else if (number1 < number2)
{
    Console.WriteLine($"Of the numbers {number1} and {number2}, the largest number is the number {number2}, and the smallest is the number {number1}");
}
     else
       {
       Console.WriteLine($"The numbers {number1} and {number2} are equal.");
       }