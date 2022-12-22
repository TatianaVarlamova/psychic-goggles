int[] Array =new int[8];
for (int i=0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(-10,11);
    Console.Write(" "+Array[i]);
}
