void Zadacha19()
{
    Console.WriteLine("Введите число");
    string? number = Console.ReadLine();
    int lenght = number!.Length;
    int help = lenght / 2;
    int result = 0;
    for (int i = 0; i <= help; i++)
    {
        if (number[i] == number[lenght - 1 - i]) result += 1;
        else result -= 1;
    }
    if (result < help) Console.WriteLine($"Число: {number} - не палиндром.");
    else Console.WriteLine($"Число: {number} - палиндром.");
}

void Zadacha21()
{
    Console.WriteLine("Введите A[x]");
    int numberAx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите A[y]");
    int numberAy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите A[z]");
    int numberAz = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[x]");
    int numberBx = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[y]");
    int numberBy = Convert.ToInt16(Console.ReadLine());
    Console.WriteLine("Введите B[z]");
    int numberBz = Convert.ToInt16(Console.ReadLine());
    double D = Math.Sqrt((Math.Pow(numberAx - numberBx, 2) + Math.Pow(numberAy - numberBy,2) + Math.Pow(numberAz - numberBz,2)));
    Console.Write("Расстояние между точками = ");
    Console.WriteLine(Math.Truncate(100 * D) / 100);
}

void Zadacha23()
{
    Console.WriteLine("Введите число");
    int number = Convert.ToInt16(Console.ReadLine());
    for (int i = 1; i <= number; i++ )
    {
        Console.Write(i + " в кубе = ");
        Console.WriteLine(i * i * i);
    }
}

//Zadacha19();
//Zadacha21();
Zadacha23();