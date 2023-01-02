// Задача 54: Задайте двумерный массив. Напишите программу, 
// которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

int[,] FillArray(int m, int n, int min, int max)
{
     int[,] result = new int[m, n];
     for (int i = 0; i < m; i++)
     {
        for (int j = 0; j < n; j++)
        {
            result[i, j] = new Random().Next(min, max +1);
        } 
     }
     return result;
}

void PrintArray(int[,] inArray)
{
    for (int i = 0; i < inArray.GetLength(0); i++)
    {
         for (int j = 0; j < inArray.GetLength(1); j++)
        {
              Console.Write($"{inArray[i, j]} ");  
        }
        Console.WriteLine();
    }
}

int[,] array = FillArray(3, 4, 0, 10);
PrintArray(array);
Console.WriteLine();
int temp = 0;
for (int i = 0; i < array.GetLength(0); i++)
{
    for (int j = 0; j < array.GetLength(1) - 1; j++)
        {
            for (int k = 0; k < array.GetLength(1) - 1; k++)
               {
                  if (array[i, k] < array[i, k+1])
                    {
                       temp = array[i, k];
                       array[i, k] = array[i, k+1];
                       array[i, k+1] = temp;
                    }
                }
        }
}
PrintArray(array);