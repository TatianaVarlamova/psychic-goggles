int[,] arr = new int[3,4];
for (int i = 0; i < arr.GetLength(0); i++)
{
     for (int j = 0; j < arr.GetLength(1); j++)
     {
         arr[i, j] = new Random().Next(0, 10);
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
int[] result = new int[3];
 for (int i = 0; i < arr.GetLength(0); i++)
{
    int sum = 0;
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        sum = (sum + arr[i, j]);
        result[i] = sum;
    }
    Console.Write(result[i] + "; ");
}
Console.WriteLine();
int min = result[0];
int count = 0;
Console.WriteLine();
for (int i = 0; i < result.Length; i++)
{
    if (result[i] < min)
        {
            min = result[i];
            count = i;
        }
}
Console.WriteLine($"строка с наименьшей суммой элементов: {count+1}.");