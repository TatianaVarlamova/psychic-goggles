// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами от -10,0 до 10,0.
// m = 3, n = 4.
// 0,5 7,0 -2,0 -0,2
// 1,0 -3,3 8,0 -9,9
// 8,0 7,8 -7,1 9,0

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
double[,] arr = new double[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         double number = new Random().Next(-10, 11) + new Random().NextDouble();
         arr[i, j] = Math.Round(number, 2);
     }
 }
for (int i = 0; i < arr.GetLength(0); i++)
 {
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         Console.Write(arr[i, j] + " ");
     }
     Console.WriteLine();
 }    