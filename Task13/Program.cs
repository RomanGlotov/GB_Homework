// 13. Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

System.Console.WriteLine("Введите число");

int number = Convert.ToInt32(Console.ReadLine());

if (number / 100 == 0)

{
    System.Console.WriteLine("Третьей цифры нет");
    return;
}

while (number > 999)

{
    number /= 10;
}

int a = number % 10;

System.Console.WriteLine(a);
