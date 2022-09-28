//Задача 19
//Запишите метод, который принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
//4212 -> нет
//12821 -> да
//23432 -> да
Console.WriteLine("Введите пятизначное число:");
int number = int.Parse(Console.ReadLine());
if (number < 0) number = -number;
string numberString = Convert.ToString(number);


void CheckingNumber(string numberString)
{
    if (numberString[0] == numberString[4] || numberString[1] == numberString[3])
    {
        Console.WriteLine($"Ваше число: {number} - палиндром.");
    }
    else Console.WriteLine($"Ваше число: {number} - НЕ палиндром.");
}

if (numberString.Length == 5)
{
    CheckingNumber(numberString);
}
else Console.WriteLine($"Вы ввели не пятизначное число. Введите правильное число");
