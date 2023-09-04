// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());


int rem = N % 2;

if (rem != 0) N = N-1;

int Nrem = N / 2;
int[] even = new int[Nrem];


int i = 0;

while (i < Nrem)
    {
        even[i] = N;
        N = N - 2;
        i = i + 1;
    }


Console.WriteLine("Четные числа: ");
var str = string.Join(" ", even);
Console.WriteLine(str);