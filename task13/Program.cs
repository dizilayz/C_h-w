// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

// Console.Write("Enter the number: ");
// int number = Convert.ToInt32(Console.ReadLine());
// string str = number.ToString();
// Console.WriteLine(str[2]);



// Console.Write("enter the number: ");
// int Number = Convert.ToInt32(Console.ReadLine());
// string NumberText = Convert.ToString(Number);
// if (NumberText.Length > 2){
//   Console.WriteLine("third number -> " + NumberText[2]);
// }
// else {
//   Console.WriteLine("-> no");
// }


// Console.Clear();
// // Запрашиваем у пользователя число
// Console.Write("Введите Ваше трехзначное число");
// String number = Console.ReadLine();
// // Приводим данное число из типа string в тип int 
// int num = int.Parse(number);
// // Находим длину строки для введенного числа
// int index = number.Length;
// //Если введеное число является отрицательным
// // приводим его в положительный диапозон 
// // и количество символов в строке уменьшаем на один
// if (num < 0)
// {
//     num *= -1;
//     index--;
// }
// // Если количество символов в строке было меньше трех, то сообщаем пользователю, что третьей цифры нету и прерываем выполнение программы
// if (index < 3)
// {
//     Console.WriteLine($"В вашем числе {number} нету третьей цифры!");
//     return;
// }
// // Для нахождения третьей цифры возводим 10 в степень уменьшенную на 3, чтобы исключить первые числа
// double temp = Math.Pow(10, index -3);
// // Преобразуем полученную 10 в степени в тип int
// index = (int)temp;
// //По формуле находим 3 цифру
// num = num/index%10;
// //Выводим ее пользователю
// Console.WriteLine($"Третьей цифрой числа {number} является {num}");




Console.Clear();
Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
int thirdNumber = 0;
if (num<100)
{
  Console.WriteLine("Третьей цифры нету");
  return;
}
else if (num > 1000)
{
  while (num > 1000)
  {
    num = num/10;
  }
  thirdNumber = num%10;
}

Console.WriteLine($"Третьей цифрой числа {num} является {thirdNumber}");






