﻿// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3


/*Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine()!);

int max = 0;
int min = 0;

if(num1>num2)
{
    max = num1;
    min = num2;
}
else
{
    max = num2;
    min = num1;
}

Console.WriteLine($"{max}>{min}");
*/




// Задача 4: Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.WriteLine("Введите первое число");
int num1 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите второе число");
int num2 = Convert.ToInt32(Console.ReadLine()!);
Console.WriteLine("Введите третье число");
int num3 = Convert.ToInt32(Console.ReadLine()!);

int max = 0;

if (num1 > num2)
{
    max = num1;        
}
else
{
    max = num2;
}
if (max < num3)
{
    max = num3;
}

Console.WriteLine($"Самое большое число {max}");

// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
