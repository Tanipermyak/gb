// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да 

Console.WriteLine("Введите целое число "); 
int number = Convert.ToInt32(Console.ReadLine());  

if (number % 2 ==0) 
{
    Console.WriteLine($"{number} -> да"); 
}
else 
{
    Console.WriteLine($"{number} -> нет");
}
