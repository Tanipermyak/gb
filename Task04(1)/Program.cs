//  Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7

Console.WriteLine("Введите число A "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите число B "); 
int numberB = Convert.ToInt32(Console.ReadLine());  
Console.WriteLine("Введите число C "); 
int numberC = Convert.ToInt32(Console.ReadLine()); 
int max = numberA;  

if (numberA > numberB) 
{
    Console.WriteLine($" max = {numberA} ");
}
else if (numberB > numberC)
{
    Console.WriteLine($"max = {numberB}");
}
else if (numberC > numberA) 
{
    Console.WriteLine($" max = {numberC} ");  
}
