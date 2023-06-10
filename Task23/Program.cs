// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N. 5 ->  1 | 1 ...


Console.WriteLine("Введите целое число ");
int number = Convert.ToInt32(Console.ReadLine()); 

Cube(number); 

void Cube (int num) 
{
    int count = 1; 
    while (count <= num) 
    {
        Console.WriteLine($"число {count,3}   куб числа {count * count * count,5}"); 
        count++;
    }
}
