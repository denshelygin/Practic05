// Задача 38: Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
// [3 7 22 2 78] -> 76

double[] arr = new double[5];
Console.WriteLine();   
for (int i = 0; i < arr.Length; i++)
    {
    Random myRnd = new Random();    
    arr[i] = myRnd.Next(0, 100);
    Console.Write(arr[i] + " ");
    }
Console.WriteLine();   
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > max)
        {
            max = arr[i];
        }
    if (arr[i] < min)
        {
            min = arr[i];
        }
}
Console.WriteLine($"Макс {max}, Мин {min}");
Console.WriteLine($"Разница {max - min}");
