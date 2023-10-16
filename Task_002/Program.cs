// Напишите код, который принимает на вход координаты двух точек pointA и pointB в виде массива целых чисел,
// и возвращает расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7) -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53
System.Console.WriteLine("Ведите координаты точки pointA (x, y): ");
int pointAx = Convert.ToInt32(Console.ReadLine());
int pointAy = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Ведите координаты точки pointB (x, y): ");
int pointBx = Convert.ToInt32(Console.ReadLine());
int pointBy = Convert.ToInt32(Console.ReadLine());


double squareX = Math.Pow(pointBx - pointAx, 2);
double squareY = Math.Pow(pointBy - pointAy, 2);
double rootXY = Math.Sqrt(squareX + squareY);
System.Console.WriteLine(Math.Round(rootXY, 2));
