// Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

int ReverseNumber(int number)
{
    int temp = number;
    int reverse = 0;
    while(number > 0)
        {
            int digit = number % 10;
            reverse = reverse * 10 + digit;
            number = number / 10;
        }
    return reverse;
}

void CheckReverse(int checknum, int numb)
{
if (checknum == numb) Console.WriteLine("The entered number is a palindrome!");
else Console.WriteLine("The entered number is not a palindrome!");
}

Console.Clear();
Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

int rebnum = ReverseNumber(number);
CheckReverse(rebnum, number);