/*Задача 21
Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
A (3,6,8); B (2,1,-7), -> 15.84
A (7,-5, 0); B (1,-1,9) -> 11.53*/

Console.WriteLine("Координата x точки A");
double ax = int.Parse(Console.ReadLine());

Console.WriteLine("Координата y точки A");
double ay = int.Parse(Console.ReadLine());

Console.WriteLine("Координата c точки A");
double ac = int.Parse(Console.ReadLine());

Console.WriteLine("Координата x точки B");
double bx = int.Parse(Console.ReadLine());

Console.WriteLine("Координата y точки B");
double by = int.Parse(Console.ReadLine());

Console.WriteLine("Координата c точки B");
double bc = int.Parse(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(bx - ax, 2) + Math.Pow(by - ay, 2) + Math.Pow(bc - ac, 2));

Console.WriteLine($"Расстояние между точками А и В равно: {Math.Round(result, 3)}");