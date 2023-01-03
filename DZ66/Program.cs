int PrintSum(int M, int N)
{
    if(M == N) return N;
    return (M + PrintSum(M+1, N));
}

Console.Clear();
Console.WriteLine("Введите начальное значение М: ");
int M = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите конечное значение N: ");
int N = int.Parse(Console.ReadLine()!);
Console.WriteLine();
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N: {PrintSum(M, N)}");
