﻿//Задача 21

//Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B(2, 1, -7), -> 15.84

//A(7, -5, 0); B(1, -1, 9)-> 11.53

Console.WriteLine("Введите координаты первой точки:");
Console.Write("X1: ");
var x1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y1: ");
var y1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z1: ");
var z1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координаты второй точки:");
Console.Write("X2: ");
var x2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Y2: ");
var y2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Z2: ");
var z2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Расстояние между двумя точками равно: {Math.Round(Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2) + Math.Pow((z2 - z1), 2)), 27)}");