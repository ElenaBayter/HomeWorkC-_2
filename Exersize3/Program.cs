﻿// Напишите программу, которая принимает на вход цифру, 
// обозначающую день недели, и проверяет, является ли этот день выходным.

Console.WriteLine("Write a number");
int number = int.Parse(Console.ReadLine());

if (number<=5)
{
    Console.WriteLine("This day is a weekday");
}
if (number>=6)
{
    Console.WriteLine("This day is a weekend");
}