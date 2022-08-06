//________________Блок методов____________________
//
//________________________________________________
void PrintArray(int[] array)
{
    int size = array.Length;
    Console.Write("Массив {");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + ", ");
    }
    Console.WriteLine("\b\b}");
}

void PrintDouble(double[] array)
{
    int size = array.Length;
    Random random = new Random();
    Console.Write("Массив вещественных чисел {");
    for (int i = 0; i < size; i++)
    {
        Console.Write(array[i] + " | ");
    }
    Console.WriteLine("\b\b}");
}

void FillArray(int[] array, int startNumber = -10, int finishNumber = 10)
{
    finishNumber++;
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = random.Next(startNumber, finishNumber);
    }
}

void FillArrayDouble(double[] array)
{
    int size = array.Length;
    Random random = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round((random.Next(-100, 100) + random.NextDouble()), 2);
    }
}

void SearchResult(double[] array)
{
    double MaxNum = array[0];
    double MinNum = array[0];
    int size = array.Length;
    for (int i = 0; i < size; i++)
    {
        if (MaxNum < array[i])
        {
            MaxNum = array[i];
        }
    }
    for (int i = 0; i < size; i++)
    {
        if (MinNum > array[i])
        {
            MinNum = array[i];
        }
    }
    Console.WriteLine($"Разница между наибольшим({MaxNum}) и наименьшим({MinNum}) вещественным числом в массиве = {MaxNum - MinNum}");
}

void SearchEvenNum(int[] array)
{
    int size = array.Length;
    int EvenNum = 0;
    for (int i = 0; i < size; i++)
    {
        if (array[i] % 2 == 0) EvenNum += 1;
    }
    Console.WriteLine("Четных чисел в массиве " + EvenNum);
}

void SumOddNum(int[] array)
{
    int size = array.Length;
    int SumOddNum = 0;
    for (int i = 1; i < size; i += 2)
    {
        SumOddNum += array[i];
    }
    Console.WriteLine("Сумма чисел нечетных позиций = " + SumOddNum);
}

//_______________Блок описания_____________
//
//_________________________________________

void Zadacha34()
{
    int size = 10;
    int[] array = new int[size];
    FillArray(array, 100, 999);
    PrintArray(array);
    SearchEvenNum(array);
}

void Zadacha36()
{
    int size = 6;
    int[] array = new int[size];
    FillArray(array);
    PrintArray(array);
    SumOddNum(array);
}
 
void Zadacha38()
{
    int size = 4;
    double[] array = new double[size];
    FillArrayDouble(array);
    PrintDouble(array);
    SearchResult(array); 
}


//___________Блок основного кода______________
//
//____________________________________________


//Zadacha34();
//Zadacha36();
Zadacha38();