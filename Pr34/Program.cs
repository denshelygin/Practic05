// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] arr = new int[10];
Console.WriteLine();   
for (int i = 0; i < arr.Length; i++)
    {
    Random myRnd = new Random();    
    arr[i] = myRnd.Next(99, 999);
    Console.Write(arr[i] + " ");
    }
Console.WriteLine();   
int count = 0;
for (int i = 0; i < arr.Length; i++)
if (arr[i] % 2 == 0)
count++;
Console.WriteLine($"{count} из них чётные");