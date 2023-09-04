// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

Console.WriteLine("Введите первое число");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
int numberB = Convert.ToInt32(Console.ReadLine());

if (numberA > numberB)
{
    Console.Write("Наибольшее число = ");
    Console.WriteLine(numberA);
    Console.Write("Наименьшее число = ");
    Console.WriteLine(numberB);
}
else
{
    Console.Write("Наибольшее число = ");
    Console.WriteLine(numberB);
    Console.Write("Наименьшее число = ");
    Console.WriteLine(numberA);
}

