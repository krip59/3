﻿//Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
//6 -> да
//7 -> да
//1 -> нет
Console.Clear();
Console.WriteLine("Введите число дня недели от 1 до 7");
int a = int.Parse(Console.ReadLine());
if (a>7 && a <1)
{
Console.Write("Это не день недели. Введите день недели с 1-7");
return;
}
 if (a > 5)
{
    Console.Write("Это выходной! Ура, отдохнем!!!");}
else 
{
    Console.Write("Не является выходным, прийдется поработать");
}