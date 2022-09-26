//Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
//
//456 -> 5
//782 -> 8
//918 -> 1
Console.Write("Введи трёхзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 99 && number < 1000)
{
    string Strnumber = Convert.ToString(number);
    Console.WriteLine("вторая цифра этого числа это - " + Strnumber[1]);
}
else
{
    Console.WriteLine("Вы ввели не трёхзначное число");
}
