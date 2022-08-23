// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

int FindThirdDigit(int number)
        {
            int digit = -1;
            if (number > 99)
            {
                int digitIndex = 2;
                digit = number.ToString()[digitIndex] - '0';
            }
          return digit;
        }

 Console.Clear();
 
 Console.Write("Enter a number: ");
 int number = Convert.ToInt32(Console.ReadLine());
 
 int dig = FindThirdDigit(number);
 
 if (dig == -1) Console.WriteLine($"There is no third digit in the number {number}.");
    else Console.WriteLine($"In the number {number}, the third digit is {dig} ");