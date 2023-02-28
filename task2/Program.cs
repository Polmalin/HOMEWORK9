// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов
// в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

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

int GetSumOfNaturalNumbers(int numberM, int numberN)
{
    if (numberN == numberM)
    {
        return numberM;
    }
    else
    {
        return numberM + GetSumOfNaturalNumbers(numberM+1, numberN);
    }
}

int numberM = GetNumber("Введите число: ");
int numberN = GetNumber("Введите число: ");
int sum =0;
Console.WriteLine(GetSumOfNaturalNumbers(numberM,numberN));