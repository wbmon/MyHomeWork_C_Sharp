// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

int [] CreateArray(int n)
{
  int [] group = new int[n];
  for (int i = 0; i < n; i++)
  {
    Console.Write($"Enter the {i+1} element of the array: ");
    group[i] = Convert.ToInt32(Console.ReadLine());
  }
  return group;
}

void PrintArry(int[] mas)
{
  int count = mas.Length;
  Console.Write("[");
  for(int index = 0; index < count; index++)
  {
    Console.Write(mas[index]);
    if (index < count - 1) Console.Write(", ");
  }
  Console.Write("]");
} 

int [] arNum = CreateArray(8); // If necessary, i can add the ability to set the dimension of the array.
PrintArry(arNum);