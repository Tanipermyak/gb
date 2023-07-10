// Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

Console.WriteLine("Введите натуральное число");
int number = Convert.ToInt32(Console.ReadLine()); 

CheckNaturalNumbers(number);
NaturalNumbers(number);

bool CheckNaturalNumbers(int num) 
{
    return num % 10 == 0;
}

void NaturalNumbers (int num)
{
    if (num == 0) return;
    Console.Write($"{num} ");
    NaturalNumbers (num - 1);
}

