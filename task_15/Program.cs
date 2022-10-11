// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Clear();
Console.WriteLine("Enter the number: ");
int numberWeek = int.Parse(Console.ReadLine());

if (numberWeek == 6 || numberWeek == 7)
{
    Console.WriteLine("That's weekend!");
}
else {
    Console.WriteLine("This day is not day off");
}
if (numberWeek < 1 || numberWeek > 7)
{
    Console.WriteLine ("That isn't a day of the week!");
    
}