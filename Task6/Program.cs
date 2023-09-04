// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

Console.WriteLine("Введите число");
int numberA = Convert.ToInt32(Console.ReadLine());

int rem = numberA % 2;
if (rem == 0) 
{
    Console.Write (numberA);
    Console.WriteLine (" - четное");
}
else
{
    Console.Write (numberA);
    Console.WriteLine (" - нечетное");
}
