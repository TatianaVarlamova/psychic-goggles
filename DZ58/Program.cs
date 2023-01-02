// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу,
//  которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

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

int[,] array = FillArray(2, 2, 0, 10);
PrintArray(array);
Console.WriteLine();

int[,] array2 = FillArray(2, 2, 0, 10);
PrintArray(array2);

int[,] result = new int[2,2];
for (int i = 0; i < array.GetLength(0); i++)
 {
     for (int j = 0; j < array.GetLength(1); j++)
     {
        result[i, j] = array[i, j] * array2[i, j];
     }
     Console.WriteLine();
 }     
 PrintArray(result);