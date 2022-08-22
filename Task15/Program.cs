// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

 int InputNumbers()
 {
    int numberday; 
    do Console.WriteLine("Enter the number of the day of the week");
    while (!Int32.TryParse(Console.ReadLine(), out numberday) || numberday < 1 || numberday > 7);
    return numberday;
 }
        
void CheckNumber(int num) 
 {
    if (num > 5) Console.WriteLine("Yes, this day is a day off");
    else  Console.WriteLine("No, it's a working day");
 }

Console.Clear();
int inputday = InputNumbers();
CheckNumber(inputday);