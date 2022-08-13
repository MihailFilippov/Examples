//_______________________________________________
//______________Блок методов_____________________
//_______________________________________________
void PrintArray(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix, int startNumber = 0, int finishNumber = 9)
{
    finishNumber++;
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void FillArray(double[,] matrix)
{
    Random random = new Random();
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = Math.Round(random.NextDouble() * 10, 1);
        }
    }
}

void FindNum(int[,] matrix, int indexI = 0, int indexJ = 0)
{
    indexI -= 1;
    indexJ -= 1;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    if (indexI > rows || indexJ > columns)
    {
        Console.WriteLine("Выход за пределы массива");
    }
    else Console.WriteLine($"Элемент находящийся на {indexI + 1} строке {indexJ + 1} столбце = {matrix[indexI, indexJ]}");
}

void SearchAverage(int[,] matrix, int rows = 1)
{   
    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        double average = 0;
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            average += matrix[i, j];
        }
        Console.Write($"{Math.Round(average /= rows, 2)}  ");
    }
}

//_______________________________________________
//______________Блок кода________________________
//_______________________________________________

void Zadacha47()
{
    Random random = new Random();
    int rows = random.Next(4, 8);
    int columns = random.Next(4, 8);
    double[,] matrix = new double[rows, columns];
    FillArray(matrix);
    PrintArray(matrix);
}

void Zadacha50()
{
    Random random = new Random();
    int rows = 3;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine("Введите номер строки");
    int indexI = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int indexJ = Convert.ToInt32(Console.ReadLine());
    FindNum(matrix, indexI, indexJ);
}

void Zadacha52()
{
    Random random = new Random();
    int rows = 3;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    Console.WriteLine("Среднее значение чисел в столбцах");
    SearchAverage(matrix, rows);
}


//_______________________________________________
//______________Блок вызова______________________
//_______________________________________________

//Zadacha47();
//Zadacha50();
Zadacha52();
