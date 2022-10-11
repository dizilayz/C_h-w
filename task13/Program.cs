// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string str = number.ToString();
// Console.WriteLine(str[2]);



Console.Write("enter the number: ");
int Number = Convert.ToInt32(Console.ReadLine());
string NumberText = Convert.ToString(Number);
if (NumberText.Length > 2){
  Console.WriteLine("third number -> " + NumberText[2]);
}
else {
  Console.WriteLine("-> no");
}

  

