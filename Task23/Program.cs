// Задача 23. Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

void Cube(int[] cubenumber)
{
  int i = 0, len = cubenumber.Length;
  while (i <  len)
  {
    cubenumber[i] = Convert.ToInt32(Math.Pow(i, 3));
    i = i + 1;
  }
}

void Print(int[] massive)
{
  int j = massive.Length, h = 0;
  while(h < j - 1)
  {
    Console.Write(massive[h]+ ", ");
    h = h + 1;
  }
  Console.Write(massive[h]);
} 

Console.Clear();
Console.Write("Enter a number: ");
int cubenumber = Convert.ToInt32(Console.ReadLine());

int[] mas = new int[cubenumber + 1];
Cube(mas);
Print(mas);