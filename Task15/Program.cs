// 15 . Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

System.Console.WriteLine("Введите число от 1 до 7");

int number = Convert.ToInt32(Console.ReadLine());

if (number <= 5 )

    System.Console.WriteLine("Будний день");

else 

System.Console.WriteLine("Выходной день");
