Console.WriteLine("Введите трехзначное число");
int a = int.Parse(Console.ReadLine()!);
int b = a / 10 % 10;
Console.WriteLine(b);
