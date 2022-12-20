Console.WriteLine("Введите любое число ");
int a = int.Parse(Console.ReadLine()!);
char[] arr = a.ToString().ToCharArray();
int n = arr.Length;
if ( n > 2 )
{
    Console.WriteLine(arr[2]);
}
else
{
    Console.WriteLine("нет третьего числа");
}