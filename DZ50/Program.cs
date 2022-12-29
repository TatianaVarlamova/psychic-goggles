// Задача 50. Напишите программу, которая на вход принимает число,
//  и возвращает индексы числа в двумерном массиве или же указание, 
//  что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк: ");
int m = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите количество столбцов: ");
int n = int.Parse(Console.ReadLine()!);
Console.WriteLine();
int[,] arr = new int[m,n];
for (int i = 0; i < arr.GetLength(0); i++)
{
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         arr[i, j] = new Random().Next(0, 20);
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
Console.WriteLine();
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine()!);
 bool f = false;
for (int i = 0; i < arr.GetLength(0); i++)
{
     for (int j = 0; j < arr.GetLength(1); j++)
     { 
        if (number == arr[i, j]) 
        {
             m = i;n = j;f = true;
             break;
         };
     }
 }
 Console.WriteLine();
if (f)
     Console.WriteLine($"Данное число находится в строке {m+1} , столбец {n+1}");
 else
     Console.WriteLine($"Числа {number} нет в массиве");
