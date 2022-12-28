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
