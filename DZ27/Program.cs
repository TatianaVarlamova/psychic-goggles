Console.WriteLine("введите число ");
string Number = Console.ReadLine()!;
int[] Array = new int[Number.Length];
int i;
for(i = 0; i < Number.Length; i++)
    {
     Array[i] = Convert.ToInt32(Number[i].ToString());
     }
int sum = Array.Sum();
        Console.WriteLine(sum);