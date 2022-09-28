//Задача 228: Напишите программу, которая принимает на вход семь чисел, и находит их среднее арифметическое
//1 2 3 4 5 6 7-> 4
//10 20 30 40 50 60 70 -> 40
Console.Write("Введите число 1: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 2: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 3: ");
int number3 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 4: ");
int number4 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 5: ");
int number5 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 6: ");
int number6 = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число 7: ");
int number7 = Convert.ToInt32(Console.ReadLine());

int SrArf = (number1 +  number2 + number3 + number4 + number5 + number6 + number7)/7;

Console.WriteLine("Среднее арифметическое этих чисел равно " + SrArf);

//Console.WriteLine("Введите планируемое количество чисел:");
//int count = int.Parse(Console.ReadLine());
//int sum = 0;
//for (int i = 0; i < count; i++)
//{
//Console.WriteLine($"Введите {i + 1}-ое число:");
//int number = int.Parse(Console.ReadLine());
//sum = sum + number;
//}
//float average = sum / count;
//Console.WriteLine(average);