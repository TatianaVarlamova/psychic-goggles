Console.WriteLine("ВВедите число ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("ВВедите степень числа ");
int b = int.Parse(Console.ReadLine()!);
int stepen = a;
for (int i = 1; i < b; i++)
{
    stepen = stepen * a;
}
Console.WriteLine(stepen);