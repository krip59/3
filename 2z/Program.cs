//Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6

Console.Clear();
Console.Write("Введите число");
int a= int.Parse(Console.ReadLine());
if (a > 100 && a<1000){    Console.WriteLine ($"{a/10%10}");}  
else if (a > 1000 && a<10000){    Console.WriteLine ($"{a/100%10}");} 
else if (a > 10000 && a<100000){    Console.WriteLine ($"{a/1000%10}");}    
else
{
    Console.WriteLine("Третьей цифры нет");
} 
