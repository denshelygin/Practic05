// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0

int[] arr = new int[5];
Console.WriteLine();   
for (int i = 0; i < arr.Length; i++)
    {
    Random myRnd = new Random();    
    arr[i] = myRnd.Next(0, 100);
    Console.Write(arr[i] + " ");
    }
Console.WriteLine();   

int sum = 0;

for (int i = 0; i < arr.Length; i+=2)
    sum = sum + arr[i];
Console.WriteLine($"всего {arr.Length} чисел, сумма = {sum}");
