// Есть магазин "Еда"
// В магазине есть охранник
// Охранник ведёт запись всех, кто заходит в магазин
// Охранник ведёт запись всех, кто выходит из магазин
// 
// Зайти и выйти можно в целый час.
// 
// Выяснить в какой промежуток времени было больше всего
// посетителей
// 
// Данные вводятся парами: приход-уход
// Максимум 100 покупателей
// 
// Входные данные
// 10-12
// 11-13
// 9-12
// 
// Ответ
// 11-12


void LogBuyer(int[] array, int count)
{
    int buyer = 0;
    while (buyer < count)
    {
        FillBuyer(array, GetIntValue(0, 24), GetIntValue(0, 24));
        buyer++;
    }
}


int FindAmountSameItem(int[] array, int item)
{
    int length = array.Length;
    int amount = 0;
    for (int index = 0; index < length; index++)
    {
        if (array[index] == item) amount = amount + 1;
    }
    return amount;
}

int[] FindIndexSameItem(int[] array, int item, int countItem)
{
    int[] arrayIndex = new int[countItem];
    int size = array.Length;
    int pos = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] == item)
        {
            arrayIndex[pos] = i;
            pos++;
        }
    }
    return arrayIndex;
}

int GetIntValue(int min, int max)
{
    return new Random().Next(min, max);
}

int EnterIntNumber()
{
    return int.Parse(Console.ReadLine());
}


int[] CreateArray(int size)
{
    return new int[size];
}

void FillBuyer(int[] array, int min, int max)
{
    if (min > max) 
    {
        int help = min;
        min = max;
        max = help;
    }
    int i = min;
    while (i < max)
    {
        array[i] = array[i] + 1;
        i++;
    }
}


void Print(int[] array)
{
    int i = 0;
    int size = array.Length;
    while (i < size)
    {
        Console.Write(array[i] + " ");
        i++;
    }
    Console.WriteLine();
}

int FindMaximumValue(int[] arr)
{
    int leng = arr.Length;
    int max = arr[0];
    for (int i = 0; i < leng; i++)
    {
        if (arr[i] > max) max = arr[i];
    }
    return max;
}

int[] arrayDay = CreateArray(24);
Console.Write("Введите количество покупателей за день: ");
int count = EnterIntNumber();
for (int buyer = 0; buyer < count; buyer++)
{
    FillBuyer(arrayDay, GetIntValue(0, 25), GetIntValue(0, 25)); 
}
Console.WriteLine("Количество покупателей в каждом часу (от 0 до 24 ч): ");
Print(arrayDay);
int max = FindMaximumValue(arrayDay);
if (max > 0)
{
    Console.WriteLine($"Максимальное количество покупателей ({max}) было в следующие промежутки: ");
    int size = arrayDay.Length;
    for (int m = 0; m < size - 1; m++)
    {
        if (arrayDay[m] == max)
        {
            for (int k = m + 1; k < size; k++)
            {
                if (arrayDay[m] != arrayDay[k])
                {
                    Console.WriteLine($"{m} - {k} ч");
                    m = k;
                    k = size - 1;
                }
                else if (k == size - 1)
                {
                    Console.WriteLine($"{m} - {k + 1} ч");
                    m = k + 1;
                }
            }
        }
    }
}
else Console.WriteLine("Покупателей в течение дня не было");