// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
//645 -> 5
//78 -> третьей цифры нет
//32679 -> 6
Console.Write("Введи число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99)
{
    string Strnumber = Convert.ToString(number);
    Console.WriteLine("Третья цифра этого числа это - " + Strnumber[2]);
}
else
{
    Console.WriteLine("Третьей цифры нет");
}
