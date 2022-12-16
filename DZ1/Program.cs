Console.Write("Введите первое число ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Введите второе число ");
int b = int.Parse(Console.ReadLine()!);

Console.WriteLine("Проверим является ли первое число квадратом второго");
if (b*b==a){
    Console.WriteLine("Первое число является квадратом второго.");
}
else {
    Console.WriteLine("Первое число не является квадратом второго.");
}
