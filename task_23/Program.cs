﻿/* Задача 23
Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
3 -> 1, 8, 27
5 -> 1, 8, 27, 64, 125
*/
Console.WriteLine("Введите число: ");
int userNumber = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел:");
for (int index = 1; index <= userNumber; index++)
{
    Console.Write($"  {index * index * index}");
}