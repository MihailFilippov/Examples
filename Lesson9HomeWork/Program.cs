//_____________________________________________________________
//_______________________Блок методов__________________________
//_____________________________________________________________
void Kot(int m, int n)
{
    if (m > n)
    {
        return;
    }
    if (m % 3 == 0)
    {
        Console.Write(m + " ");
    }
    m++;
    Kot(m, n);
}

void SumNum(int m, int n, int result = 0)
{
    if (m > n)
    {
        Console.Write(result);
        return;
    }
    result += m;
    m++;
    SumNum(m, n, result);
}

int funcAck(int m, int n)
{
    if (m == 0) return n + 1;
    else if (n == 0) return funcAck(m - 1, 1);
    else return funcAck(m - 1, funcAck(m, n - 1));
}

//_____________________________________________________________
//_______________________Блок кода_____________________________
//_____________________________________________________________

void Zadacha64()
{
    Console.Write("Введите M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    Kot(numM, numN);
}

void Zadacha66()
{
    Console.Write("Введите M: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите N: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    SumNum(numM, numN);
}

void Zadacha68()
{
    Console.Write("Введите 1 положительное число: ");
    int numM = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите 2 положительное число: ");
    int numN = Convert.ToInt32(Console.ReadLine());
    int functionAkkerman = funcAck(numM, numN);
    Console.Write($"Функция Аккермана = {functionAkkerman}");
}

//_____________________________________________________________
//_______________________Блок вызова___________________________
//_____________________________________________________________

//Zadacha64();
//Zadacha66();
Zadacha68();