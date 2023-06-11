// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. 452 -> 11

Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <= 0) Console.WriteLine("Введено ненатуральное число");
else
{
    int sumDigit = SumDigit (number);
    Console.WriteLine($"Сумма цифр в числе {sumDigit}");
}

int SumDigit(int num)
{
    int result = 0;
    while (number > 0)
    {             
        {
            result += number % 10;
            number = number / 10; 
        }
    }
    return result;
}



// / 10 еще брать остаток деления на 10