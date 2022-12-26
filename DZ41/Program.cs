Console.WriteLine("Введите числа через пробел: ");
string inputText = Console.ReadLine(); 
string[] stringArray = inputText.Split(' ');
int[] arr = new int[stringArray.Length];

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = int.Parse(stringArray[i]);
}

for (int i = 0; i < arr.Length; i++)
{
    Console.Write(arr[i] + " ");
}
int sum = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] > 0)
    sum++;

Console.WriteLine($" {sum}  больше ноля");

