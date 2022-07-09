void Zadacha1()
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
    }
    if (number == 7)
    {
        Console.WriteLine("Воскресенье");
    }
}

void Zadacha2()
{
    Console.WriteLine ("Введите 2 числа");
    int number1 = Convert.ToInt32(Console.ReadLine());
    int number2 = Convert.ToInt32(Console.ReadLine());
    int max = number2, min = 0;

    if (number1 > number2)
    {
        max = number1 ;
        min = number2 ;
    }
    else
    {
        max = number2;
        min = number1;
    }
    Console.Write ($"max = {max}, min = {min}");
}

void Zadacha4()
{
    Console.WriteLine ("Введите первое число");
    int number1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите второе число");
    int number2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine ("Введите третье число");
    int number3 = Convert.ToInt32(Console.ReadLine());
    int max = 0;

    if (number1 > number2)
    {
        max = number1;
    }
    else
    {
        max = number2;
    }
    if (number3 > max)
    {
        max = number3;
    }
    Console.Write ($"max = {max}");
}

void Zadacha6()
{
    Console.WriteLine ("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    number = Math.Abs(number) % 2;
    if (number > 0)
    {
        Console.WriteLine ("Нечетное");
    }
    else
    {
        Console.WriteLine ("Четное");
    }
}

void Zadacha8()
{
    Console.WriteLine ("Введите число");
    int number = Convert.ToInt32(Console.ReadLine());
    int count = 2;

    while (count < number)
    {
        Console.Write (count+",");
        count += 2;
    }
    Console.WriteLine("\b.");
}
Zadacha1();
// работает для любого числа


//HomeWork
//Zadacha2();
//Zadacha4();
//Zadacha6();
//Zadacha8();
