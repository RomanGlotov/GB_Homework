// Задача 8. Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

System.Console.WriteLine("Введите число");

int n = Convert.ToInt32(Console.ReadLine());

for (int m = 2; m <= n; m+=2)
    System.Console.Write(m + " ");
