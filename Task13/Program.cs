// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.  645 -> 5 

Console.WriteLine("Введите число  ");
int number = Convert.ToInt32(Console.ReadLine()); 

if (number > 999) 
{
    int result = (number/10) % 10;  
    Console.WriteLine($"Третья цифра заданного числа {result}");
}
else if (number <= 999 && number > 99)
{
    int result = number % 10; 
    Console.WriteLine($"Третья цифра заданного числа {result}");
}
else if (number <= 99)
{
    Console.WriteLine("Третьей цифры нет");
}


