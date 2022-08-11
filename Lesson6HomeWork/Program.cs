
void Zadacha41()
{
    int count = 5;
    int result = 0;
    for (int i = 0; i < count; i++)
    {
        int number = 0;
        Console.WriteLine($"Введите {i + 1}-е число");
        number = Convert.ToInt32(Console.ReadLine());
        if (number > 0) result++;
    }
    Console.WriteLine($"Количество положительных чисел из {count} введеных = {result}");
}

void Zadacha43()
{
    double k1 = 0; double k2 = 0;
    double b1 = 0; double b2 = 0;
    double x = 0; double y = 0;
    Console.WriteLine("Введите B1");
    b1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите K1");
    k1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите B2");
    b2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите K2");
    k2 = Convert.ToInt32(Console.ReadLine());
    if (k1 == k2 || b1 == b2) Console.WriteLine("Не пересекаются");
    else
    {
        x = (b2 - b1) / (k1 - k2);
        y = k2 * x + b2;
        Console.WriteLine($"Пересечение в точке {x}, {y}");
    }
}
//Zadacha41();
Zadacha43();