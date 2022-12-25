// Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

Console.WriteLine ("Введите размер массива");
int numb = Convert.ToInt32(Console.ReadLine());
int[] array = new int[numb];

for(int i = 0; i < array.Length; i++)
        {
            array[i] = new Random().Next(-20,20);
        }
        for(int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + ", ");
        }
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
   sum = sum + array[i];
Console.WriteLine($" сумма элементов на нечётных позициях = {sum}");

