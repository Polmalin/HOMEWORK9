// Напишите программу вычисления функции Аккермана с помощью рекурсии. 
//Даны два неотрицательных числа m и n.
//m = 2, n = 3 -> A(m,n) = 9
//m = 3, n = 2 -> A(m,n) = 29

int GetNumber(string message)
{
    int result = 0;
    while(true)
    {
        Console.WriteLine(message);
        if(int.TryParse(Console.ReadLine(), out result) && result >=1)
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не корректное число. Повторите ввод");
        }
    }
    return result;
}

int GetAkkerman(int numberM, int numberN)
{
    if (numberM == 0)
    {
        return numberN + 1;
    }
    else if (numberN == 0 && numberM > 0)
    {
        return GetAkkerman(numberM - 1, 1);
    }
    else
    {
        return (GetAkkerman(numberM - 1, GetAkkerman(numberM, numberN - 1)));
    }
}

int numberM = GetNumber("Введите число М: ");
int numberN = GetNumber("Введите число N: ");

Console.WriteLine(GetAkkerman(numberM,numberN));