﻿//Задача 2: Напишите программу,
//которая на вход принимает два числа и выдаёт, 
//какое число большее, а какое меньшее.

Console.Clear();
Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());
if(num1 == num2)
Console.WriteLine("Числа равны");
if(num1 > num2)
Console.WriteLine("Первое число больше второго");
if(num2 > num1)
Console.WriteLine("Второе число больше первого");
