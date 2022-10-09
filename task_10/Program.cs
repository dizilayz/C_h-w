// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

// 456 -> 5
// 782 -> 8
// 918 -> 1


Console.Clear();
Console.WriteLine("Enter a three-digit number: ");
int number = int.Parse(Console.ReadLine());

int a = number / 100;
int b = number / 10 % 10;
int c = number % 10;
Console.WriteLine($"{a},{b},{c}");
Console.WriteLine($"The second number of {number} is {b}");