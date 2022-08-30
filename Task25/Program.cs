// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

int RaiseToADegree(int numA, int numB)
{
  int C = 1;
  for(int i=1; i <= numB; i++)
    C = C * numA;
  return C;
}

Console.Clear();

Console.Write("Enter a number A: ");
int A = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter a number B: ");
int B = Convert.ToInt32(Console.ReadLine());

int degree = RaiseToADegree(A, B);
Console.WriteLine("A ^ B = " + degree);