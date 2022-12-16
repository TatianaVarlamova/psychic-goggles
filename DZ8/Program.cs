Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 100 * 10 + a % 10;
Console.WriteLine(b);
