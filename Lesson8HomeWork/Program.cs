//_________________________________________________________
//_____________________Блок методов________________________
//_________________________________________________________
void PrintMatrix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            Console.Write($"{matrix[i, j]}  ");
        }
        Console.WriteLine();
    }
}

void FillMatrix(int[,] matrix, int startNumber = 0, int finishNumber = 9)

{
    finishNumber++;
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    Random random = new Random();
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            matrix[i, j] = random.Next(startNumber, finishNumber);
        }
    }
}

void Sotrting(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int max = matrix[0, 0];
    for (int i = 0; i < rows; i++)
    {
        for (int k = 0; k < columns; k++)
        {
            for (int j = 0; j < columns - 1; j++)
            {
                if (matrix[i, j] < matrix[i, j + 1])
                {
                    max = matrix[i, j];
                    matrix[i, j] = matrix[i, j + 1];
                    matrix[i, j + 1] = max;
                }
            }
        }
    }
}

void SearchSum(int[,] matrix, int[] array)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            array[i] += matrix[i, j];
        }
    }

}

void SumMin(int[] array)
{
    int minRows = 0;
    int minSum = array[0];
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < minSum)
        {
            minRows = i;
            minSum = array[i];
        }
    }
    Console.WriteLine($"{minRows + 1} строка имеет наименьшую сумму = {minSum}");
}

void FillHelix(int[,] matrix)
{
    int rows = matrix.GetLength(0);
    int columns = matrix.GetLength(1);
    int num = 1;
    int i = 0;
    int j = 0;
    int bias = 1;
    while (num <= rows * columns)
    {
        matrix[i, j] = num;
        num++;
        if (i <= j + bias && i + j < columns - bias)
            j++;
        else if (i < j && i + j >= rows - bias)
            i++;
        else if (i >= j && i + j > columns - bias)
            j--;
        else
            i--;
    }
}

void MultiMatrix(int[,] matrixFirst, int[,] matrixSecond, int[,] matrixResult)
{
    int rows = matrixResult.GetLength(0);
    int columns = matrixResult.GetLength(1);
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            int result = 0;
            for (int m = 0; m < columns; m++)
            {
                result += matrixFirst[i, m] * matrixSecond[m, j];
            }
            matrixResult[i, j] = result;
        }
    }
    Console.WriteLine("Произведение матриц");
}

//_________________________________________________________
//_____________________Блок кода___________________________
//_________________________________________________________

void Zadacha54()
{
    int rows = 4;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillMatrix(matrix);
    Console.WriteLine("Не упорядоченный");
    PrintMatrix(matrix);
    Sotrting(matrix);
    Console.WriteLine("Упорядоченный");
    PrintMatrix(matrix);
}

void Zadacha56()
{
    int rows = 4;
    int columns = 3;
    int[,] matrix = new int[rows, columns];
    int[] array = new int[rows];
    FillMatrix(matrix);
    PrintMatrix(matrix);
    SearchSum(matrix, array);
    SumMin(array);
}

void Zadacha58()
{
    int rows = 4;
    int columns = 4;
    int[,] matrix = new int[rows, columns];
    FillHelix(matrix);
    PrintMatrix(matrix);
}

void Zadacha61()
{
    int rows = 3;
    int columns = 3;
    int[,] matrixFirst = new int[rows, columns];
    int[,] matrixSecond = new int[rows, columns];
    int[,] matrixResult = new int[rows, columns];
    FillMatrix(matrixFirst);
    FillMatrix(matrixSecond);
    Console.WriteLine("Первая матрица");
    PrintMatrix(matrixFirst);
    Console.WriteLine("Вторая матрица");
    PrintMatrix(matrixSecond);
    MultiMatrix(matrixFirst, matrixSecond, matrixResult);
    PrintMatrix(matrixResult);
}

//_________________________________________________________
//_____________________Блок вызова_________________________
//_________________________________________________________

//Zadacha54();
//Zadacha56();
//Zadacha58();
Zadacha61();