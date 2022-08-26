// Задача 21 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

int EnteringСoordinates(string coord, string point)
{
    Console.Write($"Enter the {coord} coordinate of point {point}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Segm(double x1, double x2, double y1, double y2, double z1, double z2)
{
  double dx = x2 - x1;
  double dy = y2 - y1;
  double dz = z2 - z1;
  return Math.Sqrt(dx*dx + dy*dy + dz*dz);
}

Console.Clear();
int x1 = EnteringСoordinates("x", "A");
int y1 = EnteringСoordinates("y", "A");
int z1 = EnteringСoordinates("z", "A");
int x2 = EnteringСoordinates("x", "B");
int y2 = EnteringСoordinates("y", "B");
int z2 = EnteringСoordinates("z", "B");

double SegmLength = Segm(x1, x2, y1, y2, z1, z2);

Console.WriteLine($"Length of the segment AB = {SegmLength}");