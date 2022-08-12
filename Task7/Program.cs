//Задача 7: Напишите программу, которая принимает на вход трёхзначное число 
//и на выходе показывает последнюю цифру этого числа.

Console.Clear();
Console.WriteLine("Введите трехзначное число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(N < 99 || N > 999)
Console.WriteLine("Это число не трехзначное");
else
{
    int result = N%10;
    Console.WriteLine("Последняя цифра этого числа: " + result);
}
