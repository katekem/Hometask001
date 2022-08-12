//Задача 8: Напишите программу, которая на вход принимает число (N), 
//а на выходе показывает все чётные числа от 1 до N.

Console.Clear();
Console.WriteLine("Введите число: ");
int N = Convert.ToInt32(Console.ReadLine());
int result = 2;
while(result <= N)
{
    Console.Write(result);
    result = result + 2;
}

