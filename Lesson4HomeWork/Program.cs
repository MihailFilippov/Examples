void Zadacha25()
{
    Console.Write("Введите число A: ");
    int numberA = Convert.ToInt16(Console.ReadLine());
    Console.Write("Введите число B: ");
    int numberB = Convert.ToInt16(Console.ReadLine());
    int result = 1;
    for (int i = 1; i <= numberB; i++)
    {
        result *= numberA;
    }
    Console.WriteLine($"{numberA} в степени {numberB} = {result}");
}

void Zadacha27()
{
    Console.Write ("Введите число :");
    int number = Convert.ToInt32(Console.ReadLine ());
    int help = number;
    int result = 0;
    while (number > 0)
    {
        result += number % 10;
        number /= 10;
    }
    Console.WriteLine ($"Сумма цифр в числе {help} = {result}");
}

void Zadacha29()
{
Random random = new Random();
int size = 8;
int[] array = new int[size];
int max = array[0];
Console.WriteLine("Не отсортированный массив");
for (int i = 0; i < array.Length; i++)
{
    array[i] = random.Next(-3, 8);
    Console.Write($"{array[i]} ");
}
Console.WriteLine();
for (int i = 0; i < array.Length; i++)
{

    for (int j = 0; j < array.Length - 1; j++)
    {
        if (Math.Abs(array[j]) > Math.Abs(array[j + 1]))
        {
            max = array[j];
            array[j] = array[j + 1];
            array[j + 1] = max;
        }
    }
}

Console.WriteLine("Отсортированный по модулю массив");
foreach (int num in array)
{
    Console.Write(num + " ");
}
}
//Zadacha25();
//Zadacha27();
Zadacha29();