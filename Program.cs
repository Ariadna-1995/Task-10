//Задача 10: Напишите программу, которая принимает на вход трёхзначное 
//число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число: ");
int num = int.Parse(Console.ReadLine()!);
if(num<100 || num>999)
{
    Console.Write("Вы ввели не трехзначное число ");    
}
else
{
    num = (num%100)/10;
    Console.Write($"{num}");
}
