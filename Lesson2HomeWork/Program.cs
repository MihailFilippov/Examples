void Zadacha13()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    int res = -1;
    if (num > 100)
    {
        int count = 1;
        while (num > 100 * count)
        {
            count = count * 10;
        }
        int num1 = num % count;
        res = num1 / (count / 10);
        Console.WriteLine("Третья цифра "+res); 
    }
    else Console.WriteLine("Третьей цифры нет");
}

void Zadacha13Text()
{
    Console.Write("Введите число: ");
    int num = Convert.ToInt32(Console.ReadLine());
    string numText = Convert.ToString(num);
    if (numText.Length > 2)
    {
    Console.WriteLine("Третья цифра " + numText[2]);
    }
    else Console.WriteLine("Третьей цифры нет");
}

void Zadacha15()
{
    Console.WriteLine ("Введите число: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number < 1)
    {
        Console.WriteLine ("Введено неверное число");
    }
    while (number > 7)
    {
        number = number - 7;
    }
    if (number == 1)
    {
        Console.WriteLine("Понедельник");
    }
    if (number == 2)
    {
        Console.WriteLine("Вторник");
    }
    if (number == 3)
    {
        Console.WriteLine("Среда");
    }
    if (number == 4)
    {
        Console.WriteLine("Четверг");
    }
    if (number == 5)
    {
        Console.WriteLine("Пятница");
    }
    if (number == 6)
    {
        Console.WriteLine("Суббота");
        Console.WriteLine("Выходной");
    }
    if (number == 7)
    {
        Console.WriteLine("Воскресенье");
        Console.WriteLine("Выходной");
    }
}

//Zadacha13(); // только деление, работает с любыми числами
//Zadacha13Text();// без деления
//Zadacha15();