Console.WriteLine("Введите первое число: ");
double a1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите третье число: ");
double c1 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите четвертое число: ");
double a2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите пятое число: ");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Введите шестое число: ");
double c2 = double.Parse(Console.ReadLine());

double abc = Math.Sqrt(Math.Pow(a2-a1,2) + Math.Pow(b2 - b1,2) + Math.Pow(c2-c1,2));

Console.WriteLine(abc);