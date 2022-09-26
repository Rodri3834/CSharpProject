Console.Write("Введите день недели: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 0 && number <8)
{
    if (number > 5)
    {
        Console.WriteLine("Этот день - ВЫХОДНОЙ!!!");
    }
    else
    {
        Console.WriteLine("Это будний день.");
    }
}
else
{
    Console.WriteLine("Вы ввели неправильный день недели.");
}
