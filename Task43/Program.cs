// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.

double[,] coefficients = new double[2, 2];
double[] intersect = new double[2];

void SettingCoefficients()
{
    for (int i=0; i < coefficients.GetLength(0); i++)
    {
        Console.WriteLine($"Enter the coefficients k and b of the {i+1} equation.");
        for (int j=0; j < coefficients.GetLength(1); j++) 
        {
            if (j == 0) Console.Write("First the coefficient k: ");
            else Console.Write("And now the coefficient b: ");
            coefficients[i,j] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine();
    }
}

double[] Check(double[,] coeff)
{
  intersect[0] = (coeff[1,1] - coeff[0,1]) / (coeff[0,0] - coeff[1,0]);     //  Find the x coordinate of the intersection point.
  intersect[1] = intersect[0] * coeff[0,0] + coeff[0,1];                    //  We substitute the found x into the first equation and find the y coordinate of the intersection point.
  return intersect;
}

void VerificationResult(double[,] coefficients)
{
  if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] == coefficients[1,1]) 
  {
    Console.Write("The lines you set match. All points of these lines are common.");
  }
  else if (coefficients[0,0] == coefficients[1,0] && coefficients[0,1] != coefficients[1,1]) 
  {
    Console.Write("The lines you set are parallel. They have no intersection points.");
  }
  else 
  {
    Check(coefficients);
    Console.Write($"The lines you set intersect at the point: ({Math.Round(intersect[0], 2)}; {Math.Round(intersect[1], 2)}).");
  }
}

Console.Clear();

SettingCoefficients();
VerificationResult(coefficients);