﻿//Задача 5: Напишите программу, которая на вход принимает одно число (N), 
//а на выходе показывает все целые числа в промежутке от -N до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = - N;
while(result <= N)
{
    Console.Write(result);
    result ++;
};


