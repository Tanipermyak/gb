// Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7

Console.WriteLine("Введите значение A  "); 
int numberA = Convert.ToInt32(Console.ReadLine()); 
Console.WriteLine("Введите значение B  "); 
int numberB = Convert.ToInt32(Console.ReadLine()); 
int max = numberA;

if (numberA > numberB) 
{
    Console.WriteLine($"max = {numberA}  ");
}
else 
{
    Console.WriteLine($"max = {numberB}");  
}