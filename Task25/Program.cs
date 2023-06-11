// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B. 3, 5 -> 243 (3⁵)

Console.WriteLine("Введите целое число A "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите целое число B "); 
int numberB = Convert.ToInt32(Console.ReadLine()); 
int i = 1;

if (numberB <= 0) Console.WriteLine("Введено ненатуральное число");
else
{
    while (numberB !=0) 
    {
        i = i * numberA; 
        numberB = numberB - 1;
    }
    Console.WriteLine($"Получившаяся экпонента числа {numberA} = {i}");
}



//double Exponent (double numA, double numB) 
//{
//    double expo = Math.Pow(numA, numB); 
//}





// В только натуральным - проверка. Используем метод