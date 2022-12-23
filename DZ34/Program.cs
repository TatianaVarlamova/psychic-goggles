int[] Array =new int[10];
for (int i=0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(100, 1000);
    Console.Write(Array[i]+ ", ");
}

int count = 0;
for (int i = 0; i < Array.Length; i++)
if (Array[i] % 2 == 0)
    count++;

Console.WriteLine($" {count}  из них чётные");