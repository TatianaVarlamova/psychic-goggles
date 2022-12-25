Console.WriteLine ("Введите размер массива");
int numb = Convert.ToInt32(Console.ReadLine());
double[] Array =new double[numb];
for (int i=0; i<Array.Length; i++)
{
    Array[i] = new Random().Next(1,30);
    Console.Write(Array[i]+ ", ");
}
double min = Array[0];
double max = Array[0];
for(int i = 0; i < Array.Length; i++)
{
    if (Array[i] > max)
        {
            max = Array[i];
        }
    if (Array[i] < min)
        {
            min = Array[i];
        }
}
Console.WriteLine($"Разница между максимальным и минимальным значением = {max - min}");