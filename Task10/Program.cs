// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

 int InputNumber()
 {
    int chislo; 
    do Console.WriteLine("Enter a three-digit number");
    while (!Int32.TryParse(Console.ReadLine(), out chislo) || chislo < 100 || chislo > 999);
    return chislo;
 }
int DigitTwo(int number)
{
    int sot = number / 100;
    int ed = number % 10;
    int result = (number - sot * 100 - ed) / 10;
    return result;
}

Console.Clear();
int inputnumber = InputNumber();
int otvet = DigitTwo(inputnumber);
Console.WriteLine($"From the number {inputnumber} we get {otvet}");