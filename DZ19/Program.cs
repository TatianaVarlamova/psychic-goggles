Console.WriteLine("Введите пятизначное число");
string num = Console.ReadLine();
if (num[1] == num[3] && num[0] == num[4]) 
{
    Console.Write("да,число является палиндромом");
}
else
{
    Console.Write("нет,это число не является палиндромом");
}