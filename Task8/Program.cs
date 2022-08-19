// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.Clear();

Console.Write("Enter a number N greater than 1: ");
int number = Convert.ToInt32(Console.ReadLine()),
    count=1;
if (number > 0) 
{
    Console.Write($"All even numbers in the range [1; {number}]: ");
    while (count <= number)
    {     
        if (count%2 == 0)    
        {
            Console.Write($"{count}");
            if (count != number/2*2)    
            Console.Write(", ");         // Output comma until end of output is reached [for beauty ;) ]
        }
    
        count++;
    }
}
else
Console.Write($"Please enter a number greater than 1 next time.");